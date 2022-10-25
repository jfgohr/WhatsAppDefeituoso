using Helpers;
using MetroSet_UI.Forms;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Servidor : MetroSetForm
    {
        private bool _estaAtivo = false;
        private Task _listener = null;
        private long _id = 0;
        private struct Cliente
        {
            public long Id;
            public StringBuilder Usuario;
            public TcpClient TcpClient;
            public NetworkStream NetworkStream;
            public byte[] Buffer;
            public StringBuilder Dados;
            public EventWaitHandle Evento;
        };
        private ConcurrentDictionary<long, Cliente> _usuarios = new ConcurrentDictionary<long, Cliente>();
        private Task _taskDeEnvio = null;
        private Task _taskParaDesconectarUsuario = null;
        private bool _sair = false;

        public Servidor()
            => InitializeComponent();

        private void ExibirMensagemNoChat(string mensagem = "") // clear the log if message is not supplied or is empty
        {
            if (!_sair)
            {
                chatTextBox.Invoke(PrintarMensagem(mensagem));
            }
        }

        private Action PrintarMensagem(string mensagem)
            => () =>
            {
                if (mensagem.HasValue())
                    chatTextBox.AppendText($"[ {DateTime.Now:t} ] {mensagem}{Environment.NewLine}");

                else
                    chatTextBox.ResetText();
            };

        private string MensagemAutomatica(string mensagem, bool erro = false)
             => $"{(erro ? "Erro" : "Sistema")}: {mensagem}";

        private void Iniciar(bool status)
        {
            if (!_sair)
                iniciarButton.Invoke(IniciarServidor(status));
        }

        private Action IniciarServidor(bool status)
        {
            return () =>
            {
                _estaAtivo = status;
                InverterStatusDosCampos();
            };
        }

        private void InverterStatusDosCampos()
        {
            ipTextBox.Enabled = !_estaAtivo;
            portaTextBox.Enabled = !_estaAtivo;
            usuarioTextBox.Enabled = !_estaAtivo;
            senhaTextBox.Enabled = !_estaAtivo;
            iniciarServidorButton.Text = !_estaAtivo ? "Iniciar" : "Parar";
            ExibirMensagemNoChat(MensagemAutomatica(!_estaAtivo ? "O servidor foi parado!" : "Servidor iniciado!"));
        }

        private void AdicionarUsuarioAoGridDeConectados(long id, string nome)
        {
            if (!_sair)
                usuariosDataGridView.Invoke(AdicionarLinhaDeUsuario(id, nome));
        }

        private Action AdicionarLinhaDeUsuario(long id, string nome)
            => () =>
            {
                var linha = new string[] { id.ToString(), nome };
                usuariosDataGridView.Rows.Add(linha);
                AtualizarQuantidadeDeClientes(usuariosDataGridView.Rows.Count);
            };

        private void AtualizarQuantidadeDeClientes(int quantidadeDeClientes)
            => totalLabel.Text = $"Quantidades de clientes: {quantidadeDeClientes}";

        private void RemoverUsuarioDoGridDeConectados(long id)
        {
            if (!_sair)
                usuariosDataGridView.Invoke(RemoverLinhaDeUsuario(id));
        }

        private Action RemoverLinhaDeUsuario(long id)
            => () =>
            {
                var linhaDoUsuario = usuariosDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(x => x.Cells["identificador"].Value.Equals(id));

                if (linhaDoUsuario.HasValue())
                    usuariosDataGridView.Rows.RemoveAt(linhaDoUsuario.Index);

                AtualizarQuantidadeDeClientes(usuariosDataGridView.Rows.Count);
            };

        private void LerDados(IAsyncResult resultado)
        {
            var cliente = (Cliente)resultado.AsyncState;
            int bytes = 0;

            if (cliente.TcpClient.Connected)
            {
                try
                {
                    bytes = cliente.NetworkStream.EndRead(resultado);
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                }
            }

            if (bytes > 0)
            {
                var bytesEncodados = Encoding.UTF8.GetString(cliente.Buffer, 0, bytes);
                cliente.Dados.Append($"{bytesEncodados}");

                try
                {
                    PostarMensagemDoCliente(cliente);
                }
                catch (Exception ex)
                {
                    cliente.Dados.Clear();
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                    cliente.Evento.Set();
                }
            }
            else
            {
                cliente.TcpClient.Close();
                cliente.Evento.Set();
            }
        }

        private void PostarMensagemDoCliente(Cliente cliente)
        {
            if (cliente.NetworkStream.DataAvailable)
                cliente.NetworkStream.BeginRead(cliente.Buffer, 0, cliente.Buffer.Length, new AsyncCallback(LerDados), cliente);

            else
            {
                var mensagem = $"{cliente.Usuario}: {cliente.Dados}";
                ExibirMensagemNoChat(mensagem);
                InicializarTaskDeEnvio(mensagem, cliente.Id);
                cliente.Dados.Clear();
                cliente.Evento.Set();
            }
        }

        private void LerAutorizacao(IAsyncResult resultado)
        {
            var cliente = (Cliente)resultado.AsyncState;
            int bytes = 0;
            if (cliente.TcpClient.Connected)
            {
                try
                {
                    bytes = cliente.NetworkStream.EndRead(resultado);
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                }
            }

            if (bytes > 0)
            {
                var bytesEncodados = Encoding.UTF8.GetString(cliente.Buffer, 0, bytes);
                cliente.Dados.Append($"{bytesEncodados}");

                try
                {
                    if (cliente.NetworkStream.DataAvailable)
                        cliente.NetworkStream.BeginRead(cliente.Buffer, 0, cliente.Buffer.Length, new AsyncCallback(LerAutorizacao), cliente);
                    
                    else
                    {
                        var json = new JavaScriptSerializer(); 
                        var dados = json.Deserialize<Dictionary<string, string>>(cliente.Dados.ToString());
                        if (!dados.ContainsKey("usuario") || !dados["usuario"].HasValue() || !dados.ContainsKey("senha") || !dados["senha"].Equals(senhaTextBox.Text))
                            cliente.TcpClient.Close();
                        
                        else
                        {
                            cliente.Usuario.Append(dados["usuario"].Length > 200 ? dados["usuario"].Substring(0, 200) : dados["usuario"]);
                            Enviar("{\"status\": \"autorizado\"}", cliente);
                        }

                        cliente.Dados.Clear();
                        cliente.Evento.Set();
                    }
                }
                catch (Exception ex)
                {
                    cliente.Dados.Clear();
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                    cliente.Evento.Set();
                }
            }
            else
            {
                cliente.TcpClient.Close();
                cliente.Evento.Set();
            }
        }

        private bool Autorizar(Cliente cliente)
        {
            bool sucesso = false;
            while (cliente.TcpClient.Connected)
            {
                try
                {
                    cliente.NetworkStream.BeginRead(cliente.Buffer, 0, cliente.Buffer.Length, new AsyncCallback(LerAutorizacao), cliente);
                    cliente.Evento.WaitOne();
                    if (cliente.Usuario.Length > 0)
                    {
                        sucesso = true;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                }
            }
            return sucesso;
        }

        private void Conectar(Cliente cliente)
        {
            if (Autorizar(cliente))
            {
                _usuarios.TryAdd(cliente.Id, cliente);
                AdicionarUsuarioAoGridDeConectados(cliente.Id, cliente.Usuario.ToString());

                var mensagem = $"{cliente.Usuario} entrou no chat!";
                ExibirMensagemNoChat(MensagemAutomatica(mensagem));
                InicializarTaskDeEnvio(MensagemAutomatica(mensagem), cliente.Id);

                while (cliente.TcpClient.Connected)
                {
                    try
                    {
                        cliente.NetworkStream.BeginRead(cliente.Buffer, 0, cliente.Buffer.Length, new AsyncCallback(LerDados), cliente);
                        cliente.Evento.WaitOne();
                    }
                    catch (Exception ex)
                    { 
                        ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                    }
                }

                cliente.TcpClient.Close();
                _usuarios.TryRemove(cliente.Id, out Cliente clienteTempo);
                RemoverUsuarioDoGridDeConectados(clienteTempo.Id);
                mensagem = $"{clienteTempo.Usuario} foi desconectado!";
                ExibirMensagemNoChat(MensagemAutomatica(mensagem));
                InicializarTaskDeEnvio(mensagem, clienteTempo.Id);
            }
        }

        private void Listener(IPAddress ip, int porta)
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(ip, porta);
                listener.Start();
                Iniciar(true);

                while (_estaAtivo)
                {
                    if (listener.Pending())
                    {
                        try
                        {
                            var cliente = new Cliente
                            {
                                Id = _id,
                                Usuario = new StringBuilder(),
                                Dados = new StringBuilder(),
                                Evento = new EventWaitHandle(false, EventResetMode.AutoReset),
                                TcpClient = listener.AcceptTcpClient()
                            };
                            cliente.NetworkStream = cliente.TcpClient.GetStream();
                            cliente.Buffer = new byte[cliente.TcpClient.ReceiveBufferSize];
                            Task.Factory.StartNew(() => Conectar(cliente));
                            _id++;
                        }
                        catch (Exception ex)
                        {
                            ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                        }
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }

                Iniciar(false);
            }
            catch (Exception ex)
            {
                ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
            }
            finally
            {
                if (listener != null)
                {
                    listener.Server.Close();
                }
            }
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            if (_estaAtivo)
            {
                _estaAtivo = false;
                return;
            }

            bool taskEstaExecutando = _listener != null && !_listener.IsCompleted;
            if (!taskEstaExecutando)
            {
                var address = ipTextBox.Text.Trim();
                var porta = portaTextBox.Text.Trim();
                var usuario = usuarioTextBox.Text.Trim();
                var houveHerro = false;
                IPAddress ip = null;

                if (!address.HasValue())
                {
                    houveHerro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("IP é obrigatório"));
                }
                else
                {
                    try
                    {
                        ip = Dns.Resolve(address).AddressList[0];
                    }
                    catch
                    {
                        houveHerro = true;
                        ExibirMensagemNoChat(MensagemAutomatica("IP inválido"));
                    }
                }

                int portaTemp = -1;
                if (!porta.HasValue())
                {
                    houveHerro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Porta é obrigatória"));
                }
                else if (!int.TryParse(porta, out portaTemp))
                {
                    houveHerro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Porta inválida"));
                }
                else if (portaTemp < 0 || portaTemp > 65535)
                {
                    houveHerro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Porta fora do intervalo"));
                }
                if (!usuario.HasValue())
                {
                    houveHerro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Usuário é obrigatório"));
                }

                if (!houveHerro)
                    _listener = Task.Factory.StartNew(() => Listener(ip, portaTemp));
                
            }
        }

        private void Escrever(IAsyncResult resultado)
        {
            var cliente = (Cliente)resultado.AsyncState;
            if (cliente.TcpClient.Connected)
            {
                try
                {
                    cliente.NetworkStream.EndWrite(resultado);
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                }
            }
        }

        private void IniciarEscrita(string mensagem, Cliente cliente)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(mensagem);
            if (cliente.TcpClient.Connected)
            {
                try
                {
                    cliente.NetworkStream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Escrever), cliente);
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                }
            }
        }

        private void Escrever(string mensagem, long? id = null) // send the message to everyone except the sender or set ID to lesser than zero to send to everyone
        {
            var buffer = Encoding.UTF8.GetBytes(mensagem);

            foreach (var item in _usuarios)
            {
                if (id != item.Value.Id && item.Value.TcpClient.Connected)
                {
                    try
                    {
                        item.Value.NetworkStream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Escrever), item.Value);
                    }
                    catch (Exception ex)
                    {
                        ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                    }
                }
            }
        }

        private void Enviar(string mensagem, Cliente cliente)
        {
            if (_taskDeEnvio == null || _taskDeEnvio.IsCompleted)
            {
                _taskDeEnvio = Task.Factory.StartNew(() => IniciarEscrita(mensagem, cliente));
                return;
            }
            
            _taskDeEnvio.ContinueWith(antecendent => IniciarEscrita(mensagem, cliente));
        }

        private void InicializarTaskDeEnvio(string mensagem, long? id = null)
        {
            if (_taskDeEnvio == null || _taskDeEnvio.IsCompleted)
            {
                _taskDeEnvio = Task.Factory.StartNew(() => Escrever(mensagem, id));
                return;
            }
            
            _taskDeEnvio.ContinueWith(antecendent => Escrever(mensagem, id));
        }

        private void EnviarMensagemTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (sendTextBox.Text.HasValue())
                {
                    var mensagem = sendTextBox.Text;
                    sendTextBox.ResetText();
                    ExibirMensagemNoChat($"{usuarioTextBox.Text.Trim()} (Você): {mensagem}");
                    InicializarTaskDeEnvio($"{usuarioTextBox.Text.Trim()}: {mensagem}");
                }
            }
        }

        private void Desconectar(long? id = null)
        {
            if (_taskParaDesconectarUsuario != null && !_taskParaDesconectarUsuario.IsCompleted)
                return;

            _taskParaDesconectarUsuario = Task.Factory.StartNew(() =>
            {
                if (id is long castedLong)
                {
                    _usuarios.TryGetValue(castedLong, out var cliente);
                    cliente.TcpClient.Close();
                    RemoverUsuarioDoGridDeConectados(cliente.Id);
                    return;
                }
                
                DesconectarTodosUsuarios();
                
            });
        }

        private void DesconectarTodosUsuarios()
        {
            foreach (var item in _usuarios)
            {
                item.Value.TcpClient.Close();
                RemoverUsuarioDoGridDeConectados(item.Value.Id);
            }
        }

        private void DesconectarButton_Click(object sender, EventArgs e)
            => Desconectar();
        
        private void Server_FromClosing(object sender, FormClosingEventArgs e)
        {
            _sair = true;
            _estaAtivo = false;
            Desconectar();
        }

        private void ClientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == usuariosDataGridView.Columns["vaiDeVala"].Index)
            {
                long.TryParse(usuariosDataGridView.Rows[e.RowIndex].Cells["identificador"].Value.ToString(), out long id);
                Desconectar(id);
            }
        }

        private void LimparButton_Click(object sender, EventArgs e)
            => ExibirMensagemNoChat();
        

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
            => senhaTextBox.UseSystemPasswordChar = checkBox.Checked;
    }
}
