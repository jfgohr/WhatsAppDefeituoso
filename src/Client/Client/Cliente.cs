using Helpers;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Client
{
    public partial class ClienteApp : MetroSetForm
    {
        private bool _conexaoEstabelecida = false;
        private Task _threadDoCliente = null;
        private ClienteLocal _cliente;
        private Task _taskDeEnvio = null;
        private bool _sair = false;
        private struct ClienteLocal
        {
            public string Usuario;
            public string Senha;
            public TcpClient TcpClient;
            public NetworkStream NetworkStream;
            public byte[] Buffer;
            public StringBuilder Dados;
            public EventWaitHandle Evento;
        };

        public ClienteApp()
            => InitializeComponent();
        
        private void ExibirMensagemNoChat(string mensagem = "")
        {
            if (_sair)
                return;

            logTextBox.Invoke(PrintarMensagem(mensagem));
        }

        private Action PrintarMensagem(string mensagem)
            => () =>
            {
                if (mensagem.HasValue())
                    logTextBox.AppendText($"[ {DateTime.Now:t} ] {mensagem}{Environment.NewLine}");

                else
                    logTextBox.Clear();
            };

        private string MensagemAutomatica(string mensagem, bool erro = false)
            => $"{(erro ? "Erro" : "Sistema")}: {mensagem}";
        
        private void AlternarConexao(bool status)
        {
            if (_sair)
                return;

            connectButton.Invoke(EstabelecerConexao(status));
        }

        private Action EstabelecerConexao(bool status)
            => () => 
            {
                _conexaoEstabelecida = status;
                InverterStatusDosCampos(!status);
            };
        

        private void InverterStatusDosCampos(bool habilitar)
        {
            enderecoIpTextBox.Enabled = habilitar;
            portaTextBox.Enabled = habilitar;
            usuarioTextBox.Enabled = habilitar;
            senhaTextBox.Enabled = habilitar;
            connectButton.Text = habilitar ? "Conectar" : "Desconectar";
            ExibirMensagemNoChat(MensagemAutomatica(habilitar ? "Você foi desconectado" : "Você está conectado"));
        }

        private void LerDadosDaRede(IAsyncResult resultado)
        {
            int bytes = 0;
            if (_cliente.TcpClient.Connected)
            {
                try
                {
                    bytes = _cliente.NetworkStream.EndRead(resultado);
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                }
            }

            if (bytes.HasValue())
            {
                _cliente.Dados.Append(Encoding.UTF8.GetString(_cliente.Buffer, 0, bytes));
                try
                {
                    if (_cliente.NetworkStream.DataAvailable)
                        _cliente.NetworkStream.BeginRead(_cliente.Buffer, 0, _cliente.Buffer.Length, new AsyncCallback(LerDadosDaRede), null);
                    
                    else
                    {
                        ExibirMensagemNoChat(_cliente.Dados.ToString());
                        LimparDadosDoClienteELiberarThread();
                    }
                }
                catch (Exception ex)
                {
                    LimparDadosDoClienteELiberarThread();
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message));
                }
            }
            else
            {
                FecharConexaoTcp();
                LiberarThread();
            }
        }

        private void LimparDadosDoClienteELiberarThread()
        {
            _cliente.Dados.Clear();
            LiberarThread();
        }

        private void LiberarThread()
            => _cliente.Evento.Set();
        
        private void FecharConexaoTcp()
            => _cliente.TcpClient.Close();
        
        private void ConfirmarAutorizacao(IAsyncResult result)
        {
            int bytes = 0;

            if (_cliente.TcpClient.Connected)
            {
                try
                {
                    bytes = _cliente.NetworkStream.EndRead(result);
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message, erro: true));
                }
            }

            if (bytes.HasValue())
            {
                _cliente.Dados.Append(Encoding.UTF8.GetString(_cliente.Buffer, 0, bytes));
                try
                {
                    if (_cliente.NetworkStream.DataAvailable)
                        _cliente.NetworkStream.BeginRead(_cliente.Buffer, 0, _cliente.Buffer.Length, new AsyncCallback(ConfirmarAutorizacao), null);
                    
                    else
                    {
                        var json = new JavaScriptSerializer();
                        var data = json.Deserialize<Dictionary<string, string>>(_cliente.Dados.ToString());
                        if (data.ContainsKey("status") && data["status"].Equals("autorizado"))
                            AlternarConexao(true);
                    }
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message));
                }
                finally
                {
                    LimparDadosDoClienteELiberarThread();
                }
            }
            else
            {
                FecharConexaoTcp();
                LiberarThread();
            }
        }

        private bool AutorizarConexao()
        {
            var sucesso = false;
            var dados = new Dictionary<string, string>
            {
                { "usuario", _cliente.Usuario },
                { "senha", _cliente.Senha }
            };
            var dadosSerializados = new JavaScriptSerializer().Serialize(dados);

            MontarTaskDeEnvio(dadosSerializados);

            while (_cliente.TcpClient.Connected)
            {
                try
                {
                    _cliente.NetworkStream.BeginRead(_cliente.Buffer, 0, _cliente.Buffer.Length, new AsyncCallback(ConfirmarAutorizacao), null);
                    _cliente.Evento.WaitOne();

                    if (_conexaoEstabelecida)
                    {
                        sucesso = true;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    ExibirMensagemNoChat(MensagemAutomatica(ex.Message));
                }
            }

            if (!_conexaoEstabelecida)
                ExibirMensagemNoChat(MensagemAutomatica("Não autorizado"));
            
            return sucesso;
        }

        private void EfetuarConexao(IPAddress ip, int porta, string usuario, string senha)
        {
            try
            {
                _cliente = new ClienteLocal
                {
                    Usuario = usuario,
                    Senha = senha,
                    TcpClient = new TcpClient(),
                    Dados = new StringBuilder(),
                    Evento = new EventWaitHandle(false, EventResetMode.AutoReset),
                };

                _cliente.TcpClient.Connect(ip, porta);
                _cliente.Buffer = new byte[_cliente.TcpClient.ReceiveBufferSize];
                _cliente.NetworkStream = _cliente.TcpClient.GetStream();
                
                if (AutorizarConexao())
                {
                    while (_cliente.TcpClient.Connected)
                    {
                        try
                        {
                            _cliente.NetworkStream.BeginRead(_cliente.Buffer, 0, _cliente.Buffer.Length, new AsyncCallback(LerDadosDaRede), null);
                            _cliente.Evento.WaitOne();
                        }
                        catch (Exception ex)
                        {
                            ExibirMensagemNoChat(MensagemAutomatica(ex.Message));
                        }
                    }
                    _cliente.TcpClient.Close();
                    AlternarConexao(false);
                }
            }
            catch (Exception ex)
            {
                ExibirMensagemNoChat(MensagemAutomatica(ex.Message));
            }
        }

        private void ConectarButton_Click(object sender, EventArgs e)
        {
            if (_conexaoEstabelecida)
            {
                DesconectarCliente();
                return;
            }

            bool taskEstaExecutando = _threadDoCliente != null && !_threadDoCliente.IsCompleted;
            if (!taskEstaExecutando)
            {
                var endereco = ObterValorDoCampo(enderecoIpTextBox);
                var porta = ObterValorDoCampo(portaTextBox);
                var usuario = ObterValorDoCampo(usuarioTextBox);
                var ocorreuUmErro = false;

                IPAddress ip = null;

                if (!endereco.HasValue())
                {
                    ocorreuUmErro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("IP é obrigatório"));
                }
                else
                {
                    try
                    {
                        ip = Dns.Resolve(endereco).AddressList[0];
                    }
                    catch
                    {
                        ocorreuUmErro = true;
                        ExibirMensagemNoChat(MensagemAutomatica("Ip não é válido"));
                    }
                }

                int portaTemp = -1;
                if (!porta.HasValue())
                {
                    ocorreuUmErro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Porta é obrigatória"));
                }
                else if (!int.TryParse(porta, out portaTemp))
                {
                    ocorreuUmErro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Porta inválida"));
                }
                else if (portaTemp < 0 || portaTemp > 65535)
                {
                    ocorreuUmErro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Porta fora dos limites"));
                }
                if (!usuario.HasValue())
                {
                    ocorreuUmErro = true;
                    ExibirMensagemNoChat(MensagemAutomatica("Usuário é obrigatório"));
                }

                if (ocorreuUmErro)
                    return;

                _threadDoCliente = Task.Factory.StartNew(() => EfetuarConexao(ip, portaTemp, usuario, senhaTextBox.Text));
            }
        }

        private string ObterValorDoCampo(MetroSet_UI.Controls.MetroSetTextBox campo)
            => campo.Text.Trim();
        
        private void DesconectarCliente()
            => _cliente.TcpClient.Close();
        
        private void Escrever(IAsyncResult result)
        {
            if (!_cliente.TcpClient.Connected)
                return;

            try
            {
                _cliente.NetworkStream.EndWrite(result);
            }
            catch (Exception ex)
            {
                ExibirMensagemNoChat(MensagemAutomatica(ex.Message));
            }
        }

        private void Escrever(string mensagem)
        {
            var mensagemEncodada = Encoding.UTF8.GetBytes(mensagem);

            if (!_cliente.TcpClient.Connected)
                return;

            try
            {
                _cliente.NetworkStream.BeginWrite(mensagemEncodada, 0, mensagemEncodada.Length, new AsyncCallback(Escrever), null);
            }
            catch (Exception ex)
            {
                ExibirMensagemNoChat(MensagemAutomatica(ex.Message));
            }
        }

        private void MontarTaskDeEnvio(string mensagem)
        {
            if (_taskDeEnvio == null || _taskDeEnvio.IsCompleted)
                _taskDeEnvio = Task.Factory.StartNew(() => Escrever(mensagem));
            
            else
                _taskDeEnvio.ContinueWith(x => Escrever(mensagem));
        }

        private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (!sendTextBox.Text.HasValue())
                    return;
                
                var mensagem = sendTextBox.Text;
                sendTextBox.Clear();
                ExibirMensagemNoChat($"{_cliente.Usuario} (Você): {mensagem}");

                if (_conexaoEstabelecida)
                    MontarTaskDeEnvio(mensagem);
            }
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sair = true;
            if (_conexaoEstabelecida)
                _cliente.TcpClient.Close();
            
        }

        private void LimparButton_Click(object sender, EventArgs e)
            => ExibirMensagemNoChat();
        

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
            => senhaTextBox.UseSystemPasswordChar = checkBox.Checked;
    }
}