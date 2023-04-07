namespace MTGCatalog
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAvanc = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnBuscaTipo = new System.Windows.Forms.Button();
            this.btnBuscaCorCMC = new System.Windows.Forms.Button();
            this.btnBuscaEfeito = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnBuscaNome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.iconSenha = new System.Windows.Forms.PictureBox();
            this.iconNome = new System.Windows.Forms.PictureBox();
            this.iconSenhaLogin = new System.Windows.Forms.PictureBox();
            this.iconUserLogin = new System.Windows.Forms.PictureBox();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenhaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(48)))), ((int)(((byte)(33)))));
            this.panelCabecalho.Controls.Add(this.header);
            this.panelCabecalho.Controls.Add(this.btnRestaurar);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(821, 30);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.Gainsboro;
            this.header.Location = new System.Drawing.Point(12, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(114, 20);
            this.header.TabIndex = 4;
            this.header.Text = "MTG Catalog";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(755, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(719, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(788, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(755, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.btnAvanc);
            this.panelMenu.Controls.Add(this.btnStatus);
            this.panelMenu.Controls.Add(this.btnBuscaTipo);
            this.panelMenu.Controls.Add(this.btnBuscaCorCMC);
            this.panelMenu.Controls.Add(this.btnBuscaEfeito);
            this.panelMenu.Controls.Add(this.lblMenu);
            this.panelMenu.Controls.Add(this.btnBuscaNome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(136, 412);
            this.panelMenu.TabIndex = 2;
            // 
            // btnAvanc
            // 
            this.btnAvanc.FlatAppearance.BorderSize = 0;
            this.btnAvanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAvanc.Image = ((System.Drawing.Image)(resources.GetObject("btnAvanc.Image")));
            this.btnAvanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvanc.Location = new System.Drawing.Point(0, 253);
            this.btnAvanc.Name = "btnAvanc";
            this.btnAvanc.Size = new System.Drawing.Size(136, 44);
            this.btnAvanc.TabIndex = 6;
            this.btnAvanc.Text = "     Busca\r\n     Avançada\r\n";
            this.btnAvanc.UseVisualStyleBackColor = true;
            this.btnAvanc.Click += new System.EventHandler(this.btnAvanc_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(0, 209);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(136, 44);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "          Poder e/ou\r\n          Resistência\r\n";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnBuscaTipo
            // 
            this.btnBuscaTipo.FlatAppearance.BorderSize = 0;
            this.btnBuscaTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaTipo.Image")));
            this.btnBuscaTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaTipo.Location = new System.Drawing.Point(0, 165);
            this.btnBuscaTipo.Name = "btnBuscaTipo";
            this.btnBuscaTipo.Size = new System.Drawing.Size(136, 44);
            this.btnBuscaTipo.TabIndex = 4;
            this.btnBuscaTipo.Text = " Tipo\r\n";
            this.btnBuscaTipo.UseVisualStyleBackColor = true;
            this.btnBuscaTipo.Click += new System.EventHandler(this.btnBuscaTipo_Click);
            // 
            // btnBuscaCorCMC
            // 
            this.btnBuscaCorCMC.FlatAppearance.BorderSize = 0;
            this.btnBuscaCorCMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCorCMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCorCMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaCorCMC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCorCMC.Image")));
            this.btnBuscaCorCMC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaCorCMC.Location = new System.Drawing.Point(0, 121);
            this.btnBuscaCorCMC.Name = "btnBuscaCorCMC";
            this.btnBuscaCorCMC.Size = new System.Drawing.Size(136, 44);
            this.btnBuscaCorCMC.TabIndex = 3;
            this.btnBuscaCorCMC.Text = "   Cor e\r\n   Custo\r\n";
            this.btnBuscaCorCMC.UseVisualStyleBackColor = true;
            this.btnBuscaCorCMC.Click += new System.EventHandler(this.btnBuscaCorCMC_Click);
            // 
            // btnBuscaEfeito
            // 
            this.btnBuscaEfeito.FlatAppearance.BorderSize = 0;
            this.btnBuscaEfeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaEfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaEfeito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaEfeito.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaEfeito.Image")));
            this.btnBuscaEfeito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaEfeito.Location = new System.Drawing.Point(0, 77);
            this.btnBuscaEfeito.Name = "btnBuscaEfeito";
            this.btnBuscaEfeito.Size = new System.Drawing.Size(136, 44);
            this.btnBuscaEfeito.TabIndex = 2;
            this.btnBuscaEfeito.Text = "   Efeito";
            this.btnBuscaEfeito.UseVisualStyleBackColor = true;
            this.btnBuscaEfeito.Click += new System.EventHandler(this.btnBuscaEfeito_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenu.Location = new System.Drawing.Point(4, 3);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(119, 17);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Critério de busca:";
            // 
            // btnBuscaNome
            // 
            this.btnBuscaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBuscaNome.FlatAppearance.BorderSize = 0;
            this.btnBuscaNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaNome.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaNome.Image")));
            this.btnBuscaNome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaNome.Location = new System.Drawing.Point(0, 33);
            this.btnBuscaNome.Name = "btnBuscaNome";
            this.btnBuscaNome.Size = new System.Drawing.Size(136, 44);
            this.btnBuscaNome.TabIndex = 0;
            this.btnBuscaNome.Text = "    Nome";
            this.btnBuscaNome.UseVisualStyleBackColor = false;
            this.btnBuscaNome.Click += new System.EventHandler(this.btnBuscaNome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnlog);
            this.panel1.Controls.Add(this.btnreg);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(136, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 412);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.iconNome);
            this.panel2.Controls.Add(this.iconSenha);
            this.panel2.Controls.Add(this.iconUser);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(160, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 288);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.iconSenhaLogin);
            this.panel3.Controls.Add(this.iconUserLogin);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(473, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 213);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRE-SE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "LOGIN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(60, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(74, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(74, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(210, 33);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 2;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(310, 33);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(75, 23);
            this.btnlog.TabIndex = 3;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // iconUser
            // 
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(16, 94);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(33, 33);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconUser.TabIndex = 5;
            this.iconUser.TabStop = false;
            // 
            // iconSenha
            // 
            this.iconSenha.Image = ((System.Drawing.Image)(resources.GetObject("iconSenha.Image")));
            this.iconSenha.Location = new System.Drawing.Point(16, 156);
            this.iconSenha.Name = "iconSenha";
            this.iconSenha.Size = new System.Drawing.Size(33, 33);
            this.iconSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconSenha.TabIndex = 6;
            this.iconSenha.TabStop = false;
            // 
            // iconNome
            // 
            this.iconNome.Image = ((System.Drawing.Image)(resources.GetObject("iconNome.Image")));
            this.iconNome.Location = new System.Drawing.Point(16, 44);
            this.iconNome.Name = "iconNome";
            this.iconNome.Size = new System.Drawing.Size(33, 33);
            this.iconNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconNome.TabIndex = 7;
            this.iconNome.TabStop = false;
            // 
            // iconSenhaLogin
            // 
            this.iconSenhaLogin.Image = ((System.Drawing.Image)(resources.GetObject("iconSenhaLogin.Image")));
            this.iconSenhaLogin.Location = new System.Drawing.Point(22, 90);
            this.iconSenhaLogin.Name = "iconSenhaLogin";
            this.iconSenhaLogin.Size = new System.Drawing.Size(33, 33);
            this.iconSenhaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconSenhaLogin.TabIndex = 8;
            this.iconSenhaLogin.TabStop = false;
            // 
            // iconUserLogin
            // 
            this.iconUserLogin.Image = ((System.Drawing.Image)(resources.GetObject("iconUserLogin.Image")));
            this.iconUserLogin.Location = new System.Drawing.Point(22, 43);
            this.iconUserLogin.Name = "iconUserLogin";
            this.iconUserLogin.Size = new System.Drawing.Size(33, 33);
            this.iconUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconUserLogin.TabIndex = 7;
            this.iconUserLogin.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(821, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenhaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnBuscaTipo;
        private System.Windows.Forms.Button btnBuscaCorCMC;
        private System.Windows.Forms.Button btnBuscaEfeito;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnBuscaNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAvanc;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconSenhaLogin;
        private System.Windows.Forms.PictureBox iconUserLogin;
        private System.Windows.Forms.PictureBox iconNome;
        private System.Windows.Forms.PictureBox iconSenha;
        private System.Windows.Forms.PictureBox iconUser;
    }
}

