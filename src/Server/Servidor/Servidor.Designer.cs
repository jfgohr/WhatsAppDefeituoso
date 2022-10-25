namespace Servidor
{
    partial class Servidor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor));
            this.portLabel = new System.Windows.Forms.Label();
            this.localaddrLabel = new System.Windows.Forms.Label();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaiDeVala = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.iniciarButton = new MetroSet_UI.Controls.MetroSetControlBox();
            this.BotaoLimpar = new MetroSet_UI.Controls.MetroSetButton();
            this.iniciarServidorButton = new MetroSet_UI.Controls.MetroSetButton();
            this.BotaoDesconectar = new MetroSet_UI.Controls.MetroSetButton();
            this.ipTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.senhaTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.portaTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.usuarioTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.portLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.portLabel.Location = new System.Drawing.Point(188, 61);
            this.portLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(46, 17);
            this.portLabel.TabIndex = 22;
            this.portLabel.Text = "Porta:";
            // 
            // localaddrLabel
            // 
            this.localaddrLabel.AutoSize = true;
            this.localaddrLabel.BackColor = System.Drawing.Color.Transparent;
            this.localaddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.localaddrLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.localaddrLabel.Location = new System.Drawing.Point(145, 27);
            this.localaddrLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.localaddrLabel.Name = "localaddrLabel";
            this.localaddrLabel.Size = new System.Drawing.Size(89, 17);
            this.localaddrLabel.TabIndex = 21;
            this.localaddrLabel.Text = "Endereço IP:";
            // 
            // sendTextBox
            // 
            this.sendTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sendTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.sendTextBox.Location = new System.Drawing.Point(459, 417);
            this.sendTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendTextBox.Size = new System.Drawing.Size(406, 23);
            this.sendTextBox.TabIndex = 27;
            this.sendTextBox.TabStop = false;
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnviarMensagemTextBox_KeyDown);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Transparent;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.logLabel.Location = new System.Drawing.Point(456, 165);
            this.logLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(37, 17);
            this.logLabel.TabIndex = 29;
            this.logLabel.Text = "Chat";
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AllowUserToResizeColumns = false;
            this.usuariosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usuariosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usuariosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.usuariosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usuariosDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.usuariosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usuariosDataGridView.ColumnHeadersHeight = 24;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.usuario,
            this.vaiDeVala});
            this.usuariosDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usuariosDataGridView.EnableHeadersVisualStyles = false;
            this.usuariosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.usuariosDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.usuariosDataGridView.Location = new System.Drawing.Point(16, 185);
            this.usuariosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.usuariosDataGridView.MultiSelect = false;
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usuariosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.usuariosDataGridView.RowHeadersVisible = false;
            this.usuariosDataGridView.RowHeadersWidth = 40;
            this.usuariosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.usuariosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.usuariosDataGridView.RowTemplate.Height = 24;
            this.usuariosDataGridView.RowTemplate.ReadOnly = true;
            this.usuariosDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usuariosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosDataGridView.ShowCellErrors = false;
            this.usuariosDataGridView.ShowCellToolTips = false;
            this.usuariosDataGridView.ShowEditingIcon = false;
            this.usuariosDataGridView.ShowRowErrors = false;
            this.usuariosDataGridView.Size = new System.Drawing.Size(406, 225);
            this.usuariosDataGridView.TabIndex = 30;
            this.usuariosDataGridView.TabStop = false;
            this.usuariosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDataGridView_CellClick);
            // 
            // identificador
            // 
            this.identificador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.identificador.DefaultCellStyle = dataGridViewCellStyle3;
            this.identificador.HeaderText = "Codigo";
            this.identificador.MaxInputLength = 20;
            this.identificador.MinimumWidth = 20;
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.usuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.usuario.HeaderText = "Nome";
            this.usuario.MaxInputLength = 20;
            this.usuario.MinimumWidth = 20;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // vaiDeVala
            // 
            this.vaiDeVala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vaiDeVala.DefaultCellStyle = dataGridViewCellStyle5;
            this.vaiDeVala.HeaderText = "Desconectar";
            this.vaiDeVala.MinimumWidth = 20;
            this.vaiDeVala.Name = "vaiDeVala";
            this.vaiDeVala.ReadOnly = true;
            this.vaiDeVala.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vaiDeVala.Text = "Mandar pra vala";
            this.vaiDeVala.UseColumnTextForButtonValue = true;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(13, 145);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(102, 32);
            this.totalLabel.TabIndex = 31;
            this.totalLabel.Text = "Total clients: 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameLabel.Location = new System.Drawing.Point(391, 27);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 17);
            this.usernameLabel.TabIndex = 33;
            this.usernameLabel.Text = "Usuario:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keyLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.keyLabel.Location = new System.Drawing.Point(399, 61);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(53, 17);
            this.keyLabel.TabIndex = 35;
            this.keyLabel.Text = "Senha:";
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBox.Location = new System.Drawing.Point(469, 92);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(116, 22);
            this.checkBox.TabIndex = 42;
            this.checkBox.Text = "Ocultar senha";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // iniciarButton
            // 
            this.iniciarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iniciarButton.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iniciarButton.CloseHoverForeColor = System.Drawing.Color.White;
            this.iniciarButton.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.iniciarButton.DisabledForeColor = System.Drawing.Color.DimGray;
            this.iniciarButton.IsDerivedStyle = true;
            this.iniciarButton.Location = new System.Drawing.Point(779, 0);
            this.iniciarButton.MaximizeBox = false;
            this.iniciarButton.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.iniciarButton.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.iniciarButton.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.iniciarButton.MinimizeBox = true;
            this.iniciarButton.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.iniciarButton.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.iniciarButton.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(100, 25);
            this.iniciarButton.Style = MetroSet_UI.Enums.Style.Light;
            this.iniciarButton.StyleManager = null;
            this.iniciarButton.TabIndex = 43;
            this.iniciarButton.Text = "metroSetControlBox1";
            this.iniciarButton.ThemeAuthor = "Narwin";
            this.iniciarButton.ThemeName = "MetroLite";
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoLimpar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoLimpar.DisabledForeColor = System.Drawing.Color.Gray;
            this.BotaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BotaoLimpar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BotaoLimpar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BotaoLimpar.HoverTextColor = System.Drawing.Color.White;
            this.BotaoLimpar.IsDerivedStyle = true;
            this.BotaoLimpar.Location = new System.Drawing.Point(749, 150);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoLimpar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoLimpar.NormalTextColor = System.Drawing.Color.White;
            this.BotaoLimpar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotaoLimpar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotaoLimpar.PressTextColor = System.Drawing.Color.White;
            this.BotaoLimpar.Size = new System.Drawing.Size(116, 32);
            this.BotaoLimpar.Style = MetroSet_UI.Enums.Style.Light;
            this.BotaoLimpar.StyleManager = null;
            this.BotaoLimpar.TabIndex = 44;
            this.BotaoLimpar.Text = "Limpar";
            this.BotaoLimpar.ThemeAuthor = "Narwin";
            this.BotaoLimpar.ThemeName = "MetroLite";
            this.BotaoLimpar.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // BotaoIniciar
            // 
            this.iniciarServidorButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.iniciarServidorButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.iniciarServidorButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.iniciarServidorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iniciarServidorButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.iniciarServidorButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.iniciarServidorButton.HoverTextColor = System.Drawing.Color.White;
            this.iniciarServidorButton.IsDerivedStyle = true;
            this.iniciarServidorButton.Location = new System.Drawing.Point(597, 24);
            this.iniciarServidorButton.Name = "BotaoIniciar";
            this.iniciarServidorButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.iniciarServidorButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.iniciarServidorButton.NormalTextColor = System.Drawing.Color.White;
            this.iniciarServidorButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.iniciarServidorButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.iniciarServidorButton.PressTextColor = System.Drawing.Color.White;
            this.iniciarServidorButton.Size = new System.Drawing.Size(116, 32);
            this.iniciarServidorButton.Style = MetroSet_UI.Enums.Style.Light;
            this.iniciarServidorButton.StyleManager = null;
            this.iniciarServidorButton.TabIndex = 45;
            this.iniciarServidorButton.Text = "Iniciar";
            this.iniciarServidorButton.ThemeAuthor = "Narwin";
            this.iniciarServidorButton.ThemeName = "MetroLite";
            this.iniciarServidorButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // BotaoDesconectar
            // 
            this.BotaoDesconectar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoDesconectar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoDesconectar.DisabledForeColor = System.Drawing.Color.Gray;
            this.BotaoDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BotaoDesconectar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BotaoDesconectar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BotaoDesconectar.HoverTextColor = System.Drawing.Color.White;
            this.BotaoDesconectar.IsDerivedStyle = true;
            this.BotaoDesconectar.Location = new System.Drawing.Point(306, 148);
            this.BotaoDesconectar.Name = "BotaoDesconectar";
            this.BotaoDesconectar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoDesconectar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotaoDesconectar.NormalTextColor = System.Drawing.Color.White;
            this.BotaoDesconectar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotaoDesconectar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotaoDesconectar.PressTextColor = System.Drawing.Color.White;
            this.BotaoDesconectar.Size = new System.Drawing.Size(116, 32);
            this.BotaoDesconectar.Style = MetroSet_UI.Enums.Style.Light;
            this.BotaoDesconectar.StyleManager = null;
            this.BotaoDesconectar.TabIndex = 46;
            this.BotaoDesconectar.Text = "Desconectar";
            this.BotaoDesconectar.ThemeAuthor = "Narwin";
            this.BotaoDesconectar.ThemeName = "MetroLite";
            this.BotaoDesconectar.Click += new System.EventHandler(this.DesconectarButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.AutoCompleteCustomSource = null;
            this.ipTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ipTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ipTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ipTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ipTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ipTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ipTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ipTextBox.Image = null;
            this.ipTextBox.IsDerivedStyle = true;
            this.ipTextBox.Lines = null;
            this.ipTextBox.Location = new System.Drawing.Point(241, 24);
            this.ipTextBox.MaxLength = 20;
            this.ipTextBox.Multiline = false;
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.ReadOnly = false;
            this.ipTextBox.Size = new System.Drawing.Size(132, 25);
            this.ipTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.ipTextBox.StyleManager = null;
            this.ipTextBox.TabIndex = 47;
            this.ipTextBox.Text = "127.0.0.1";
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipTextBox.ThemeAuthor = "Narwin";
            this.ipTextBox.ThemeName = "MetroDark";
            this.ipTextBox.UseSystemPasswordChar = false;
            this.ipTextBox.WatermarkText = "";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.AutoCompleteCustomSource = null;
            this.senhaTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.senhaTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.senhaTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.senhaTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.senhaTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.senhaTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.senhaTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.senhaTextBox.Image = null;
            this.senhaTextBox.IsDerivedStyle = true;
            this.senhaTextBox.Lines = null;
            this.senhaTextBox.Location = new System.Drawing.Point(459, 60);
            this.senhaTextBox.MaxLength = 20;
            this.senhaTextBox.Multiline = false;
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.ReadOnly = false;
            this.senhaTextBox.Size = new System.Drawing.Size(132, 25);
            this.senhaTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.senhaTextBox.StyleManager = null;
            this.senhaTextBox.TabIndex = 48;
            this.senhaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senhaTextBox.ThemeAuthor = "Narwin";
            this.senhaTextBox.ThemeName = "MetroDark";
            this.senhaTextBox.UseSystemPasswordChar = true;
            this.senhaTextBox.WatermarkText = "";
            // 
            // portaTextBox
            // 
            this.portaTextBox.AutoCompleteCustomSource = null;
            this.portaTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.portaTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.portaTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.portaTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.portaTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.portaTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.portaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.portaTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.portaTextBox.Image = null;
            this.portaTextBox.IsDerivedStyle = true;
            this.portaTextBox.Lines = null;
            this.portaTextBox.Location = new System.Drawing.Point(241, 57);
            this.portaTextBox.MaxLength = 20;
            this.portaTextBox.Multiline = false;
            this.portaTextBox.Name = "portaTextBox";
            this.portaTextBox.ReadOnly = false;
            this.portaTextBox.Size = new System.Drawing.Size(132, 25);
            this.portaTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.portaTextBox.StyleManager = null;
            this.portaTextBox.TabIndex = 49;
            this.portaTextBox.Text = "8080";
            this.portaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portaTextBox.ThemeAuthor = "Narwin";
            this.portaTextBox.ThemeName = "MetroDark";
            this.portaTextBox.UseSystemPasswordChar = false;
            this.portaTextBox.WatermarkText = "";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.AutoCompleteCustomSource = null;
            this.usuarioTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usuarioTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usuarioTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.usuarioTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.usuarioTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usuarioTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usuarioTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.usuarioTextBox.Image = null;
            this.usuarioTextBox.IsDerivedStyle = true;
            this.usuarioTextBox.Lines = null;
            this.usuarioTextBox.Location = new System.Drawing.Point(459, 24);
            this.usuarioTextBox.MaxLength = 30;
            this.usuarioTextBox.Multiline = false;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.ReadOnly = false;
            this.usuarioTextBox.Size = new System.Drawing.Size(132, 25);
            this.usuarioTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.usuarioTextBox.StyleManager = null;
            this.usuarioTextBox.TabIndex = 50;
            this.usuarioTextBox.Text = "Servidor";
            this.usuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuarioTextBox.ThemeAuthor = "Narwin";
            this.usuarioTextBox.ThemeName = "MetroDark";
            this.usuarioTextBox.UseSystemPasswordChar = false;
            this.usuarioTextBox.WatermarkText = "";
            // 
            // chatTextBox
            // 
            this.chatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.chatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chatTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chatTextBox.Location = new System.Drawing.Point(459, 185);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatTextBox.Size = new System.Drawing.Size(406, 225);
            this.chatTextBox.TabIndex = 52;
            // 
            // Servidor
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(879, 463);
            this.ControlBox = false;
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.portaTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.BotaoDesconectar);
            this.Controls.Add(this.iniciarServidorButton);
            this.Controls.Add(this.BotaoLimpar);
            this.Controls.Add(this.iniciarButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.localaddrLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DropShadowEffect = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Servidor";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowBorder = true;
            this.ShowTitle = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Servidor";
            this.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.ThemeName = "MetroDark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FromClosing);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label localaddrLabel;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private MetroSet_UI.Controls.MetroSetControlBox iniciarButton;
        private MetroSet_UI.Controls.MetroSetButton BotaoLimpar;
        private MetroSet_UI.Controls.MetroSetButton iniciarServidorButton;
        private MetroSet_UI.Controls.MetroSetButton BotaoDesconectar;
        private MetroSet_UI.Controls.MetroSetTextBox ipTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox senhaTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox portaTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox usuarioTextBox;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewButtonColumn vaiDeVala;
    }
}

