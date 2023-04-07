namespace MTGCatalog
{
    partial class FormAvancado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvancado));
            this.pnlCor = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cBoxLoyal = new System.Windows.Forms.ComboBox();
            this.txtLoyal = new System.Windows.Forms.TextBox();
            this.cBoxResist = new System.Windows.Forms.ComboBox();
            this.txtResist = new System.Windows.Forms.TextBox();
            this.cBoxPoder = new System.Windows.Forms.ComboBox();
            this.txtPoder = new System.Windows.Forms.TextBox();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.cBoxCmc = new System.Windows.Forms.ComboBox();
            this.cBoxCorIndic = new System.Windows.Forms.ComboBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.cListCores = new System.Windows.Forms.CheckedListBox();
            this.tBoxEfeito = new System.Windows.Forms.TextBox();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.btnFnBusca = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.qtResultado = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtRarityR = new System.Windows.Forms.TextBox();
            this.txtSetR = new System.Windows.Forms.TextBox();
            this.txtCorR = new System.Windows.Forms.TextBox();
            this.txtCmcR = new System.Windows.Forms.TextBox();
            this.txtNomeR = new System.Windows.Forms.TextBox();
            this.richTextR = new System.Windows.Forms.RichTextBox();
            this.pBoxCard = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblRarity = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCmc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.listEfeito = new System.Windows.Forms.ListBox();
            this.pnlCor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCor
            // 
            this.pnlCor.AutoSize = true;
            this.pnlCor.BackColor = System.Drawing.Color.Gray;
            this.pnlCor.Controls.Add(this.comboBox1);
            this.pnlCor.Controls.Add(this.cBoxLoyal);
            this.pnlCor.Controls.Add(this.txtLoyal);
            this.pnlCor.Controls.Add(this.cBoxResist);
            this.pnlCor.Controls.Add(this.txtResist);
            this.pnlCor.Controls.Add(this.cBoxPoder);
            this.pnlCor.Controls.Add(this.txtPoder);
            this.pnlCor.Controls.Add(this.cbTipos);
            this.pnlCor.Controls.Add(this.cBoxCmc);
            this.pnlCor.Controls.Add(this.cBoxCorIndic);
            this.pnlCor.Controls.Add(this.txtCusto);
            this.pnlCor.Controls.Add(this.cListCores);
            this.pnlCor.Controls.Add(this.tBoxEfeito);
            this.pnlCor.Controls.Add(this.tBoxNome);
            this.pnlCor.Controls.Add(this.btnFnBusca);
            this.pnlCor.Controls.Add(this.txtTipo);
            this.pnlCor.Controls.Add(this.lblTipo);
            this.pnlCor.Controls.Add(this.qtResultado);
            this.pnlCor.Controls.Add(this.listBox1);
            this.pnlCor.Controls.Add(this.txtRarityR);
            this.pnlCor.Controls.Add(this.txtSetR);
            this.pnlCor.Controls.Add(this.txtCorR);
            this.pnlCor.Controls.Add(this.txtCmcR);
            this.pnlCor.Controls.Add(this.txtNomeR);
            this.pnlCor.Controls.Add(this.richTextR);
            this.pnlCor.Controls.Add(this.pBoxCard);
            this.pnlCor.Controls.Add(this.lblText);
            this.pnlCor.Controls.Add(this.lblRarity);
            this.pnlCor.Controls.Add(this.lblSet);
            this.pnlCor.Controls.Add(this.lblColor);
            this.pnlCor.Controls.Add(this.lblCmc);
            this.pnlCor.Controls.Add(this.lblNome);
            this.pnlCor.Controls.Add(this.listEfeito);
            this.pnlCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCor.Location = new System.Drawing.Point(0, 0);
            this.pnlCor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(685, 412);
            this.pnlCor.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Selecione",
            "Criatura",
            "Planeswalker"});
            this.comboBox1.Location = new System.Drawing.Point(12, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 23);
            this.comboBox1.TabIndex = 81;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cBoxLoyal
            // 
            this.cBoxLoyal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLoyal.FormattingEnabled = true;
            this.cBoxLoyal.Location = new System.Drawing.Point(141, 98);
            this.cBoxLoyal.Name = "cBoxLoyal";
            this.cBoxLoyal.Size = new System.Drawing.Size(93, 21);
            this.cBoxLoyal.TabIndex = 80;
            // 
            // txtLoyal
            // 
            this.txtLoyal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoyal.ForeColor = System.Drawing.Color.LightGray;
            this.txtLoyal.Location = new System.Drawing.Point(240, 98);
            this.txtLoyal.Name = "txtLoyal";
            this.txtLoyal.Size = new System.Drawing.Size(59, 21);
            this.txtLoyal.TabIndex = 79;
            this.txtLoyal.Text = "Lealdade";
            this.txtLoyal.Enter += new System.EventHandler(this.txtLoyal_Enter);
            this.txtLoyal.Leave += new System.EventHandler(this.txtLoyal_Leave);
            // 
            // cBoxResist
            // 
            this.cBoxResist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxResist.FormattingEnabled = true;
            this.cBoxResist.Location = new System.Drawing.Point(313, 98);
            this.cBoxResist.Name = "cBoxResist";
            this.cBoxResist.Size = new System.Drawing.Size(93, 21);
            this.cBoxResist.TabIndex = 78;
            // 
            // txtResist
            // 
            this.txtResist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResist.ForeColor = System.Drawing.Color.LightGray;
            this.txtResist.Location = new System.Drawing.Point(412, 98);
            this.txtResist.Name = "txtResist";
            this.txtResist.Size = new System.Drawing.Size(59, 21);
            this.txtResist.TabIndex = 77;
            this.txtResist.Text = "Resist.";
            this.txtResist.Enter += new System.EventHandler(this.txtResist_Enter);
            this.txtResist.Leave += new System.EventHandler(this.txtResist_Leave);
            // 
            // cBoxPoder
            // 
            this.cBoxPoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPoder.FormattingEnabled = true;
            this.cBoxPoder.Location = new System.Drawing.Point(141, 98);
            this.cBoxPoder.Name = "cBoxPoder";
            this.cBoxPoder.Size = new System.Drawing.Size(93, 21);
            this.cBoxPoder.TabIndex = 76;
            // 
            // txtPoder
            // 
            this.txtPoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoder.ForeColor = System.Drawing.Color.LightGray;
            this.txtPoder.Location = new System.Drawing.Point(240, 98);
            this.txtPoder.Name = "txtPoder";
            this.txtPoder.Size = new System.Drawing.Size(59, 21);
            this.txtPoder.TabIndex = 75;
            this.txtPoder.Text = "Poder";
            this.txtPoder.Enter += new System.EventHandler(this.txtPoder_Enter);
            this.txtPoder.Leave += new System.EventHandler(this.txtPoder_Leave);
            // 
            // cbTipos
            // 
            this.cbTipos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(277, 39);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(191, 23);
            this.cbTipos.TabIndex = 74;
            this.cbTipos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipos_KeyDown);
            // 
            // cBoxCmc
            // 
            this.cBoxCmc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCmc.FormattingEnabled = true;
            this.cBoxCmc.Location = new System.Drawing.Point(141, 69);
            this.cBoxCmc.Name = "cBoxCmc";
            this.cBoxCmc.Size = new System.Drawing.Size(121, 21);
            this.cBoxCmc.TabIndex = 73;
            // 
            // cBoxCorIndic
            // 
            this.cBoxCorIndic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCorIndic.FormattingEnabled = true;
            this.cBoxCorIndic.Location = new System.Drawing.Point(141, 41);
            this.cBoxCorIndic.Name = "cBoxCorIndic";
            this.cBoxCorIndic.Size = new System.Drawing.Size(121, 21);
            this.cBoxCorIndic.TabIndex = 72;
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.ForeColor = System.Drawing.Color.LightGray;
            this.txtCusto.Location = new System.Drawing.Point(277, 68);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(75, 20);
            this.txtCusto.TabIndex = 71;
            this.txtCusto.Text = "Custo";
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCusto.Enter += new System.EventHandler(this.txtCusto_Enter);
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // cListCores
            // 
            this.cListCores.CheckOnClick = true;
            this.cListCores.FormattingEnabled = true;
            this.cListCores.Location = new System.Drawing.Point(12, 41);
            this.cListCores.Name = "cListCores";
            this.cListCores.Size = new System.Drawing.Size(120, 49);
            this.cListCores.TabIndex = 70;
            // 
            // tBoxEfeito
            // 
            this.tBoxEfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEfeito.ForeColor = System.Drawing.Color.LightGray;
            this.tBoxEfeito.Location = new System.Drawing.Point(219, 12);
            this.tBoxEfeito.Name = "tBoxEfeito";
            this.tBoxEfeito.Size = new System.Drawing.Size(177, 23);
            this.tBoxEfeito.TabIndex = 69;
            this.tBoxEfeito.Text = "Digite parte do texto";
            this.tBoxEfeito.Enter += new System.EventHandler(this.tBoxEfeito_Enter);
            this.tBoxEfeito.Leave += new System.EventHandler(this.tBoxEfeito_Leave);
            // 
            // tBoxNome
            // 
            this.tBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNome.ForeColor = System.Drawing.Color.LightGray;
            this.tBoxNome.Location = new System.Drawing.Point(12, 12);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(177, 23);
            this.tBoxNome.TabIndex = 68;
            this.tBoxNome.Text = "Digite o nome da carta";
            this.tBoxNome.Enter += new System.EventHandler(this.tBoxNome_Enter);
            this.tBoxNome.Leave += new System.EventHandler(this.tBoxNome_Leave);
            // 
            // btnFnBusca
            // 
            this.btnFnBusca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFnBusca.Location = new System.Drawing.Point(422, 12);
            this.btnFnBusca.Name = "btnFnBusca";
            this.btnFnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnFnBusca.TabIndex = 52;
            this.btnFnBusca.Text = "Buscar";
            this.btnFnBusca.UseVisualStyleBackColor = true;
            this.btnFnBusca.Click += new System.EventHandler(this.btnFnBusca_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.Gray;
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(156, 224);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(200, 14);
            this.txtTipo.TabIndex = 67;
            this.txtTipo.Text = "(Resultado)";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(25, 224);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 15);
            this.lblTipo.TabIndex = 66;
            this.lblTipo.Text = "Tipo:";
            // 
            // qtResultado
            // 
            this.qtResultado.AutoSize = true;
            this.qtResultado.Location = new System.Drawing.Point(542, 180);
            this.qtResultado.Name = "qtResultado";
            this.qtResultado.Size = new System.Drawing.Size(108, 13);
            this.qtResultado.TabIndex = 60;
            this.qtResultado.Text = "Resultados da Busca";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(156, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 34);
            this.listBox1.TabIndex = 57;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // txtRarityR
            // 
            this.txtRarityR.BackColor = System.Drawing.Color.Gray;
            this.txtRarityR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRarityR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRarityR.Location = new System.Drawing.Point(156, 274);
            this.txtRarityR.Name = "txtRarityR";
            this.txtRarityR.ReadOnly = true;
            this.txtRarityR.Size = new System.Drawing.Size(100, 14);
            this.txtRarityR.TabIndex = 56;
            this.txtRarityR.Text = "(Resultado)";
            // 
            // txtSetR
            // 
            this.txtSetR.BackColor = System.Drawing.Color.Gray;
            this.txtSetR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetR.Location = new System.Drawing.Point(156, 249);
            this.txtSetR.Name = "txtSetR";
            this.txtSetR.ReadOnly = true;
            this.txtSetR.Size = new System.Drawing.Size(250, 14);
            this.txtSetR.TabIndex = 55;
            this.txtSetR.Text = "(Resultado)";
            // 
            // txtCorR
            // 
            this.txtCorR.BackColor = System.Drawing.Color.Gray;
            this.txtCorR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorR.Location = new System.Drawing.Point(156, 199);
            this.txtCorR.Name = "txtCorR";
            this.txtCorR.ReadOnly = true;
            this.txtCorR.Size = new System.Drawing.Size(100, 14);
            this.txtCorR.TabIndex = 54;
            this.txtCorR.Text = "(Resultado)";
            // 
            // txtCmcR
            // 
            this.txtCmcR.BackColor = System.Drawing.Color.Gray;
            this.txtCmcR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCmcR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmcR.Location = new System.Drawing.Point(156, 174);
            this.txtCmcR.Name = "txtCmcR";
            this.txtCmcR.ReadOnly = true;
            this.txtCmcR.Size = new System.Drawing.Size(100, 14);
            this.txtCmcR.TabIndex = 53;
            this.txtCmcR.Text = "(Resultado)";
            // 
            // txtNomeR
            // 
            this.txtNomeR.BackColor = System.Drawing.Color.Gray;
            this.txtNomeR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeR.Location = new System.Drawing.Point(156, 135);
            this.txtNomeR.Name = "txtNomeR";
            this.txtNomeR.ReadOnly = true;
            this.txtNomeR.Size = new System.Drawing.Size(250, 14);
            this.txtNomeR.TabIndex = 52;
            this.txtNomeR.Text = "(Resultado)";
            // 
            // richTextR
            // 
            this.richTextR.BackColor = System.Drawing.Color.Gray;
            this.richTextR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextR.Location = new System.Drawing.Point(156, 299);
            this.richTextR.Name = "richTextR";
            this.richTextR.ReadOnly = true;
            this.richTextR.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextR.Size = new System.Drawing.Size(341, 97);
            this.richTextR.TabIndex = 51;
            this.richTextR.Text = "(Resultado)";
            // 
            // pBoxCard
            // 
            this.pBoxCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxCard.BackgroundImage")));
            this.pBoxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxCard.InitialImage = null;
            this.pBoxCard.Location = new System.Drawing.Point(527, 196);
            this.pBoxCard.Name = "pBoxCard";
            this.pBoxCard.Size = new System.Drawing.Size(146, 204);
            this.pBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCard.TabIndex = 50;
            this.pBoxCard.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(25, 299);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(48, 15);
            this.lblText.TabIndex = 49;
            this.lblText.Text = "Efeito:";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRarity.Location = new System.Drawing.Point(25, 274);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(66, 15);
            this.lblRarity.TabIndex = 48;
            this.lblRarity.Text = "Raridade";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(25, 249);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(63, 15);
            this.lblSet.TabIndex = 47;
            this.lblSet.Text = "Coleção:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(25, 199);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 15);
            this.lblColor.TabIndex = 46;
            this.lblColor.Text = "Cor(es):";
            // 
            // lblCmc
            // 
            this.lblCmc.AutoSize = true;
            this.lblCmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmc.Location = new System.Drawing.Point(25, 174);
            this.lblCmc.Name = "lblCmc";
            this.lblCmc.Size = new System.Drawing.Size(107, 15);
            this.lblCmc.TabIndex = 45;
            this.lblCmc.Text = "Custo de Mana:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 135);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 44;
            this.lblNome.Text = "Nome:";
            // 
            // listEfeito
            // 
            this.listEfeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEfeito.FormattingEnabled = true;
            this.listEfeito.Location = new System.Drawing.Point(527, 3);
            this.listEfeito.Name = "listEfeito";
            this.listEfeito.Size = new System.Drawing.Size(146, 173);
            this.listEfeito.TabIndex = 43;
            this.listEfeito.DoubleClick += new System.EventHandler(this.listEfeito_DoubleClick);
            // 
            // FormAvancado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.pnlCor);
            this.Name = "FormAvancado";
            this.Text = "FormAvancado";
            this.pnlCor.ResumeLayout(false);
            this.pnlCor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label qtResultado;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtRarityR;
        private System.Windows.Forms.TextBox txtSetR;
        private System.Windows.Forms.TextBox txtCorR;
        private System.Windows.Forms.TextBox txtCmcR;
        private System.Windows.Forms.TextBox txtNomeR;
        private System.Windows.Forms.RichTextBox richTextR;
        private System.Windows.Forms.PictureBox pBoxCard;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCmc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox listEfeito;
        private System.Windows.Forms.Button btnFnBusca;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.TextBox tBoxEfeito;
        private System.Windows.Forms.CheckedListBox cListCores;
        private System.Windows.Forms.ComboBox cBoxCmc;
        private System.Windows.Forms.ComboBox cBoxCorIndic;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cBoxLoyal;
        private System.Windows.Forms.TextBox txtLoyal;
        private System.Windows.Forms.ComboBox cBoxResist;
        private System.Windows.Forms.TextBox txtResist;
        private System.Windows.Forms.ComboBox cBoxPoder;
        private System.Windows.Forms.TextBox txtPoder;
    }
}