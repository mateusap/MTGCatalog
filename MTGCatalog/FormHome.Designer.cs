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
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.pnlCorCMC = new System.Windows.Forms.Panel();
            this.pnlEfeito = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnBuscaTipo = new System.Windows.Forms.Button();
            this.btnBuscaCorCMC = new System.Windows.Forms.Button();
            this.btnBuscaEfeito = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnBuscaNome = new System.Windows.Forms.Button();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.pBoxCard = new System.Windows.Forms.PictureBox();
            this.lblTextR = new System.Windows.Forms.Label();
            this.lblRarityR = new System.Windows.Forms.Label();
            this.lblSetR = new System.Windows.Forms.Label();
            this.lblCorR = new System.Windows.Forms.Label();
            this.lblCmcR = new System.Windows.Forms.Label();
            this.lblNomeR = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblRarity = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCmc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlTipo.SuspendLayout();
            this.pnlCorCMC.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).BeginInit();
            this.pnlNome.SuspendLayout();
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
            this.panelCabecalho.Size = new System.Drawing.Size(753, 30);
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
            this.btnRestaurar.Location = new System.Drawing.Point(687, 0);
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
            this.btnMinimizar.Location = new System.Drawing.Point(651, 0);
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
            this.btnFechar.Location = new System.Drawing.Point(720, 0);
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
            this.btnMaximizar.Location = new System.Drawing.Point(687, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(152, 36);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(593, 312);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 1;
            this.logoPicture.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.pnlStatus);
            this.panelMenu.Controls.Add(this.btnStatus);
            this.panelMenu.Controls.Add(this.btnBuscaTipo);
            this.panelMenu.Controls.Add(this.btnBuscaCorCMC);
            this.panelMenu.Controls.Add(this.btnBuscaEfeito);
            this.panelMenu.Controls.Add(this.lblMenu);
            this.panelMenu.Controls.Add(this.btnBuscaNome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(136, 330);
            this.panelMenu.TabIndex = 2;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStatus.Controls.Add(this.pnlTipo);
            this.pnlStatus.Location = new System.Drawing.Point(41, 281);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(82, 61);
            this.pnlStatus.TabIndex = 0;
            // 
            // pnlTipo
            // 
            this.pnlTipo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlTipo.Controls.Add(this.pnlCorCMC);
            this.pnlTipo.Location = new System.Drawing.Point(20, 13);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(69, 69);
            this.pnlTipo.TabIndex = 0;
            // 
            // pnlCorCMC
            // 
            this.pnlCorCMC.BackColor = System.Drawing.SystemColors.Info;
            this.pnlCorCMC.Controls.Add(this.pnlEfeito);
            this.pnlCorCMC.Location = new System.Drawing.Point(8, 9);
            this.pnlCorCMC.Name = "pnlCorCMC";
            this.pnlCorCMC.Size = new System.Drawing.Size(67, 57);
            this.pnlCorCMC.TabIndex = 0;
            // 
            // pnlEfeito
            // 
            this.pnlEfeito.BackColor = System.Drawing.Color.Orange;
            this.pnlEfeito.Location = new System.Drawing.Point(17, 7);
            this.pnlEfeito.Name = "pnlEfeito";
            this.pnlEfeito.Size = new System.Drawing.Size(34, 47);
            this.pnlEfeito.TabIndex = 0;
            // 
            // btnStatus
            // 
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(0, 225);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(136, 50);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "          Poder e/ou\r\n          Resistência\r\n";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnBuscaTipo
            // 
            this.btnBuscaTipo.FlatAppearance.BorderSize = 0;
            this.btnBuscaTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaTipo.Image")));
            this.btnBuscaTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaTipo.Location = new System.Drawing.Point(0, 175);
            this.btnBuscaTipo.Name = "btnBuscaTipo";
            this.btnBuscaTipo.Size = new System.Drawing.Size(136, 50);
            this.btnBuscaTipo.TabIndex = 4;
            this.btnBuscaTipo.Text = " Tipo\r\n";
            this.btnBuscaTipo.UseVisualStyleBackColor = true;
            this.btnBuscaTipo.Click += new System.EventHandler(this.btnBuscaTipo_Click);
            // 
            // btnBuscaCorCMC
            // 
            this.btnBuscaCorCMC.FlatAppearance.BorderSize = 0;
            this.btnBuscaCorCMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCorCMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCorCMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaCorCMC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCorCMC.Image")));
            this.btnBuscaCorCMC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaCorCMC.Location = new System.Drawing.Point(0, 125);
            this.btnBuscaCorCMC.Name = "btnBuscaCorCMC";
            this.btnBuscaCorCMC.Size = new System.Drawing.Size(136, 50);
            this.btnBuscaCorCMC.TabIndex = 3;
            this.btnBuscaCorCMC.Text = "   Cor e\r\n   Custo\r\n";
            this.btnBuscaCorCMC.UseVisualStyleBackColor = true;
            this.btnBuscaCorCMC.Click += new System.EventHandler(this.btnBuscaCorCMC_Click);
            // 
            // btnBuscaEfeito
            // 
            this.btnBuscaEfeito.FlatAppearance.BorderSize = 0;
            this.btnBuscaEfeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaEfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaEfeito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaEfeito.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaEfeito.Image")));
            this.btnBuscaEfeito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaEfeito.Location = new System.Drawing.Point(0, 75);
            this.btnBuscaEfeito.Name = "btnBuscaEfeito";
            this.btnBuscaEfeito.Size = new System.Drawing.Size(136, 50);
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
            this.btnBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscaNome.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaNome.Image")));
            this.btnBuscaNome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaNome.Location = new System.Drawing.Point(0, 25);
            this.btnBuscaNome.Name = "btnBuscaNome";
            this.btnBuscaNome.Size = new System.Drawing.Size(136, 50);
            this.btnBuscaNome.TabIndex = 0;
            this.btnBuscaNome.Text = "    Nome";
            this.btnBuscaNome.UseVisualStyleBackColor = false;
            this.btnBuscaNome.Click += new System.EventHandler(this.btnBuscaNome_Click);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.pBoxCard);
            this.pnlResultado.Controls.Add(this.lblTextR);
            this.pnlResultado.Controls.Add(this.lblRarityR);
            this.pnlResultado.Controls.Add(this.lblSetR);
            this.pnlResultado.Controls.Add(this.lblCorR);
            this.pnlResultado.Controls.Add(this.lblCmcR);
            this.pnlResultado.Controls.Add(this.lblNomeR);
            this.pnlResultado.Controls.Add(this.lblText);
            this.pnlResultado.Controls.Add(this.lblRarity);
            this.pnlResultado.Controls.Add(this.lblSet);
            this.pnlResultado.Controls.Add(this.lblColor);
            this.pnlResultado.Controls.Add(this.lblCmc);
            this.pnlResultado.Controls.Add(this.lblNome);
            this.pnlResultado.Location = new System.Drawing.Point(136, 122);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(617, 238);
            this.pnlResultado.TabIndex = 3;
            // 
            // pBoxCard
            // 
            this.pBoxCard.Location = new System.Drawing.Point(409, 6);
            this.pBoxCard.Name = "pBoxCard";
            this.pBoxCard.Size = new System.Drawing.Size(158, 220);
            this.pBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCard.TabIndex = 28;
            this.pBoxCard.TabStop = false;
            // 
            // lblTextR
            // 
            this.lblTextR.AutoEllipsis = true;
            this.lblTextR.AutoSize = true;
            this.lblTextR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextR.Location = new System.Drawing.Point(159, 131);
            this.lblTextR.MaximumSize = new System.Drawing.Size(244, 98);
            this.lblTextR.Name = "lblTextR";
            this.lblTextR.Size = new System.Drawing.Size(61, 13);
            this.lblTextR.TabIndex = 27;
            this.lblTextR.Text = "(Resultado)";
            // 
            // lblRarityR
            // 
            this.lblRarityR.AutoSize = true;
            this.lblRarityR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRarityR.Location = new System.Drawing.Point(159, 106);
            this.lblRarityR.Name = "lblRarityR";
            this.lblRarityR.Size = new System.Drawing.Size(71, 15);
            this.lblRarityR.TabIndex = 26;
            this.lblRarityR.Text = "(Resultado)";
            // 
            // lblSetR
            // 
            this.lblSetR.AutoSize = true;
            this.lblSetR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetR.Location = new System.Drawing.Point(159, 81);
            this.lblSetR.Name = "lblSetR";
            this.lblSetR.Size = new System.Drawing.Size(71, 15);
            this.lblSetR.TabIndex = 25;
            this.lblSetR.Text = "(Resultado)";
            // 
            // lblCorR
            // 
            this.lblCorR.AutoSize = true;
            this.lblCorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorR.Location = new System.Drawing.Point(159, 56);
            this.lblCorR.Name = "lblCorR";
            this.lblCorR.Size = new System.Drawing.Size(71, 15);
            this.lblCorR.TabIndex = 24;
            this.lblCorR.Text = "(Resultado)";
            // 
            // lblCmcR
            // 
            this.lblCmcR.AutoSize = true;
            this.lblCmcR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmcR.Location = new System.Drawing.Point(159, 31);
            this.lblCmcR.Name = "lblCmcR";
            this.lblCmcR.Size = new System.Drawing.Size(71, 15);
            this.lblCmcR.TabIndex = 23;
            this.lblCmcR.Text = "(Resultado)";
            // 
            // lblNomeR
            // 
            this.lblNomeR.AutoSize = true;
            this.lblNomeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeR.Location = new System.Drawing.Point(159, 6);
            this.lblNomeR.Name = "lblNomeR";
            this.lblNomeR.Size = new System.Drawing.Size(71, 15);
            this.lblNomeR.TabIndex = 22;
            this.lblNomeR.Text = "(Resultado)";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(32, 131);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(48, 15);
            this.lblText.TabIndex = 21;
            this.lblText.Text = "Efeito:";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRarity.Location = new System.Drawing.Point(31, 106);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(66, 15);
            this.lblRarity.TabIndex = 20;
            this.lblRarity.Text = "Raridade";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(31, 81);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(63, 15);
            this.lblSet.TabIndex = 19;
            this.lblSet.Text = "Coleção:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(31, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 15);
            this.lblColor.TabIndex = 18;
            this.lblColor.Text = "Cor(es):";
            // 
            // lblCmc
            // 
            this.lblCmc.AutoSize = true;
            this.lblCmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmc.Location = new System.Drawing.Point(31, 31);
            this.lblCmc.Name = "lblCmc";
            this.lblCmc.Size = new System.Drawing.Size(107, 15);
            this.lblCmc.TabIndex = 17;
            this.lblCmc.Text = "Custo de Mana:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(31, 6);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome:";
            // 
            // pnlNome
            // 
            this.pnlNome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlNome.Controls.Add(this.btnBuscarNome);
            this.pnlNome.Controls.Add(this.lblDescricao);
            this.pnlNome.Controls.Add(this.tBoxNome);
            this.pnlNome.Location = new System.Drawing.Point(136, 30);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(617, 92);
            this.pnlNome.TabIndex = 16;
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarNome.Location = new System.Drawing.Point(272, 25);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNome.TabIndex = 5;
            this.btnBuscarNome.Text = "Buscar";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.btnBuscarNome_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(93, 51);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(114, 26);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Digite o nome da carta\r\n(não precisa ser exato)";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNome.Location = new System.Drawing.Point(61, 25);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(177, 23);
            this.tBoxNome.TabIndex = 3;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(753, 360);
            this.Controls.Add(this.pnlNome);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlTipo.ResumeLayout(false);
            this.pnlCorCMC.ResumeLayout(false);
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).EndInit();
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnBuscaTipo;
        private System.Windows.Forms.Button btnBuscaCorCMC;
        private System.Windows.Forms.Button btnBuscaEfeito;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnBuscaNome;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Panel pnlEfeito;
        private System.Windows.Forms.Panel pnlCorCMC;
        private System.Windows.Forms.Panel pnlTipo;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.PictureBox pBoxCard;
        private System.Windows.Forms.Label lblTextR;
        private System.Windows.Forms.Label lblRarityR;
        private System.Windows.Forms.Label lblSetR;
        private System.Windows.Forms.Label lblCorR;
        private System.Windows.Forms.Label lblCmcR;
        private System.Windows.Forms.Label lblNomeR;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCmc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnBuscarNome;
    }
}

