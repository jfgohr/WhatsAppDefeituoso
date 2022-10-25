using System.ComponentModel;

namespace Client
{
    partial class ClienteApp
    {

        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteApp));
            this.logLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new MetroSet_UI.Controls.MetroSetButton();
            this.clearButton = new MetroSet_UI.Controls.MetroSetButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usuarioTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.portaTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.senhaTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.enderecoIpTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.SuspendLayout();
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.logLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.logLabel.Location = new System.Drawing.Point(13, 159);
            this.logLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(37, 17);
            this.logLabel.TabIndex = 31;
            this.logLabel.Text = "Chat";
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.logTextBox.Location = new System.Drawing.Point(15, 184);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(567, 270);
            this.logTextBox.TabIndex = 30;
            this.logTextBox.TabStop = false;
            // 
            // sendTextBox
            // 
            this.sendTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sendTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.sendTextBox.Location = new System.Drawing.Point(16, 462);
            this.sendTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendTextBox.Size = new System.Drawing.Size(565, 23);
            this.sendTextBox.TabIndex = 32;
            this.sendTextBox.TabStop = false;
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // connectButton
            // 
            this.connectButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connectButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connectButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.connectButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.connectButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.connectButton.HoverTextColor = System.Drawing.Color.White;
            this.connectButton.IsDerivedStyle = true;
            this.connectButton.Location = new System.Drawing.Point(245, 97);
            this.connectButton.Name = "connectButton";
            this.connectButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connectButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connectButton.NormalTextColor = System.Drawing.Color.White;
            this.connectButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.connectButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.connectButton.PressTextColor = System.Drawing.Color.White;
            this.connectButton.Size = new System.Drawing.Size(116, 32);
            this.connectButton.Style = MetroSet_UI.Enums.Style.Dark;
            this.connectButton.StyleManager = null;
            this.connectButton.TabIndex = 47;
            this.connectButton.Text = "Conectar";
            this.connectButton.ThemeAuthor = "Narwin";
            this.connectButton.ThemeName = "MetroDark";
            this.connectButton.Click += new System.EventHandler(this.ConectarButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.clearButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.clearButton.HoverTextColor = System.Drawing.Color.White;
            this.clearButton.IsDerivedStyle = true;
            this.clearButton.Location = new System.Drawing.Point(466, 145);
            this.clearButton.Name = "clearButton";
            this.clearButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearButton.NormalTextColor = System.Drawing.Color.White;
            this.clearButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.clearButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.clearButton.PressTextColor = System.Drawing.Color.White;
            this.clearButton.Size = new System.Drawing.Size(116, 32);
            this.clearButton.Style = MetroSet_UI.Enums.Style.Light;
            this.clearButton.StyleManager = null;
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Limpar";
            this.clearButton.ThemeAuthor = "Narwin";
            this.clearButton.ThemeName = "MetroLite";
            this.clearButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(387, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(379, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(176, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Porta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(133, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Endereço IP:";
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
            this.usuarioTextBox.Location = new System.Drawing.Point(447, 36);
            this.usuarioTextBox.MaxLength = 30;
            this.usuarioTextBox.Multiline = false;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.ReadOnly = false;
            this.usuarioTextBox.Size = new System.Drawing.Size(132, 25);
            this.usuarioTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.usuarioTextBox.StyleManager = null;
            this.usuarioTextBox.TabIndex = 55;
            this.usuarioTextBox.Text = "Usuario";
            this.usuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuarioTextBox.ThemeAuthor = "Narwin";
            this.usuarioTextBox.ThemeName = "MetroDark";
            this.usuarioTextBox.UseSystemPasswordChar = false;
            this.usuarioTextBox.WatermarkText = "";
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
            this.portaTextBox.Location = new System.Drawing.Point(229, 66);
            this.portaTextBox.MaxLength = 20;
            this.portaTextBox.Multiline = false;
            this.portaTextBox.Name = "portaTextBox";
            this.portaTextBox.ReadOnly = false;
            this.portaTextBox.Size = new System.Drawing.Size(132, 25);
            this.portaTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.portaTextBox.StyleManager = null;
            this.portaTextBox.TabIndex = 54;
            this.portaTextBox.Text = "8080";
            this.portaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portaTextBox.ThemeAuthor = "Narwin";
            this.portaTextBox.ThemeName = "MetroDark";
            this.portaTextBox.UseSystemPasswordChar = false;
            this.portaTextBox.WatermarkText = "";
            // 
            // keyTextBox
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
            this.senhaTextBox.Location = new System.Drawing.Point(447, 66);
            this.senhaTextBox.MaxLength = 20;
            this.senhaTextBox.Multiline = false;
            this.senhaTextBox.Name = "keyTextBox";
            this.senhaTextBox.ReadOnly = false;
            this.senhaTextBox.Size = new System.Drawing.Size(132, 25);
            this.senhaTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.senhaTextBox.StyleManager = null;
            this.senhaTextBox.TabIndex = 53;
            this.senhaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senhaTextBox.ThemeAuthor = "Narwin";
            this.senhaTextBox.ThemeName = "MetroDark";
            this.senhaTextBox.UseSystemPasswordChar = true;
            this.senhaTextBox.WatermarkText = "";
            // 
            // enderecoIpTextBox
            // 
            this.enderecoIpTextBox.AutoCompleteCustomSource = null;
            this.enderecoIpTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.enderecoIpTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.enderecoIpTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.enderecoIpTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.enderecoIpTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enderecoIpTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enderecoIpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enderecoIpTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.enderecoIpTextBox.Image = null;
            this.enderecoIpTextBox.IsDerivedStyle = true;
            this.enderecoIpTextBox.Lines = null;
            this.enderecoIpTextBox.Location = new System.Drawing.Point(229, 36);
            this.enderecoIpTextBox.MaxLength = 20;
            this.enderecoIpTextBox.Multiline = false;
            this.enderecoIpTextBox.Name = "enderecoIpTextBox";
            this.enderecoIpTextBox.ReadOnly = false;
            this.enderecoIpTextBox.Size = new System.Drawing.Size(132, 25);
            this.enderecoIpTextBox.Style = MetroSet_UI.Enums.Style.Dark;
            this.enderecoIpTextBox.StyleManager = null;
            this.enderecoIpTextBox.TabIndex = 52;
            this.enderecoIpTextBox.Text = "127.0.0.1";
            this.enderecoIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enderecoIpTextBox.ThemeAuthor = "Narwin";
            this.enderecoIpTextBox.ThemeName = "MetroDark";
            this.enderecoIpTextBox.UseSystemPasswordChar = false;
            this.enderecoIpTextBox.WatermarkText = "";
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBox.Location = new System.Drawing.Point(463, 98);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(116, 22);
            this.checkBox.TabIndex = 56;
            this.checkBox.Text = "Ocultar senha";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(482, 5);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 57;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // ClienteApp
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(594, 501);
            this.ControlBox = false;
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.portaTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.enderecoIpTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.DropShadowEffect = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClienteApp";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowBorder = true;
            this.ShowTitle = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Cliente";
            this.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.ThemeName = "MetroDark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox sendTextBox;
        private MetroSet_UI.Controls.MetroSetButton connectButton;
        private MetroSet_UI.Controls.MetroSetButton clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroSet_UI.Controls.MetroSetTextBox usuarioTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox portaTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox senhaTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox enderecoIpTextBox;
        private System.Windows.Forms.CheckBox checkBox;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}

