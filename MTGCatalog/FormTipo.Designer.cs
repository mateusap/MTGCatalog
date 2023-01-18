namespace MTGCatalog
{
    partial class FormTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipo));
            this.pnlCor = new System.Windows.Forms.Panel();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipos = new System.Windows.Forms.ComboBox();
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
            this.btnFnTipo = new System.Windows.Forms.Button();
            this.pnlCor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCor
            // 
            this.pnlCor.AutoSize = true;
            this.pnlCor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlCor.Controls.Add(this.txtTipo);
            this.pnlCor.Controls.Add(this.lblTipo);
            this.pnlCor.Controls.Add(this.cbTipos);
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
            this.pnlCor.Controls.Add(this.btnFnTipo);
            this.pnlCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCor.Location = new System.Drawing.Point(0, 0);
            this.pnlCor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(618, 347);
            this.pnlCor.TabIndex = 50;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(162, 165);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(200, 14);
            this.txtTipo.TabIndex = 63;
            this.txtTipo.Text = "(Resultado)";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(31, 165);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 15);
            this.lblTipo.TabIndex = 62;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbTipos
            // 
            this.cbTipos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(35, 14);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(191, 23);
            this.cbTipos.TabIndex = 61;
            this.cbTipos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipos_KeyDown);
            // 
            // qtResultado
            // 
            this.qtResultado.AutoSize = true;
            this.qtResultado.Location = new System.Drawing.Point(500, 114);
            this.qtResultado.Name = "qtResultado";
            this.qtResultado.Size = new System.Drawing.Size(0, 13);
            this.qtResultado.TabIndex = 60;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(162, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 34);
            this.listBox1.TabIndex = 57;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // txtRarityR
            // 
            this.txtRarityR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRarityR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRarityR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRarityR.Location = new System.Drawing.Point(162, 214);
            this.txtRarityR.Name = "txtRarityR";
            this.txtRarityR.ReadOnly = true;
            this.txtRarityR.Size = new System.Drawing.Size(100, 14);
            this.txtRarityR.TabIndex = 56;
            this.txtRarityR.Text = "(Resultado)";
            // 
            // txtSetR
            // 
            this.txtSetR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSetR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetR.Location = new System.Drawing.Point(162, 189);
            this.txtSetR.Name = "txtSetR";
            this.txtSetR.ReadOnly = true;
            this.txtSetR.Size = new System.Drawing.Size(250, 14);
            this.txtSetR.TabIndex = 55;
            this.txtSetR.Text = "(Resultado)";
            // 
            // txtCorR
            // 
            this.txtCorR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCorR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorR.Location = new System.Drawing.Point(162, 139);
            this.txtCorR.Name = "txtCorR";
            this.txtCorR.ReadOnly = true;
            this.txtCorR.Size = new System.Drawing.Size(100, 14);
            this.txtCorR.TabIndex = 54;
            this.txtCorR.Text = "(Resultado)";
            // 
            // txtCmcR
            // 
            this.txtCmcR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCmcR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCmcR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmcR.Location = new System.Drawing.Point(162, 114);
            this.txtCmcR.Name = "txtCmcR";
            this.txtCmcR.ReadOnly = true;
            this.txtCmcR.Size = new System.Drawing.Size(100, 14);
            this.txtCmcR.TabIndex = 53;
            this.txtCmcR.Text = "(Resultado)";
            // 
            // txtNomeR
            // 
            this.txtNomeR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNomeR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeR.Location = new System.Drawing.Point(162, 75);
            this.txtNomeR.Name = "txtNomeR";
            this.txtNomeR.ReadOnly = true;
            this.txtNomeR.Size = new System.Drawing.Size(250, 14);
            this.txtNomeR.TabIndex = 52;
            this.txtNomeR.Text = "(Resultado)";
            // 
            // richTextR
            // 
            this.richTextR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextR.Location = new System.Drawing.Point(162, 239);
            this.richTextR.Name = "richTextR";
            this.richTextR.ReadOnly = true;
            this.richTextR.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextR.Size = new System.Drawing.Size(260, 97);
            this.richTextR.TabIndex = 51;
            this.richTextR.Text = "(Resultado)";
            // 
            // pBoxCard
            // 
            this.pBoxCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxCard.BackgroundImage")));
            this.pBoxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxCard.InitialImage = null;
            this.pBoxCard.Location = new System.Drawing.Point(460, 131);
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
            this.lblText.Location = new System.Drawing.Point(31, 239);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(48, 15);
            this.lblText.TabIndex = 49;
            this.lblText.Text = "Efeito:";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRarity.Location = new System.Drawing.Point(31, 214);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(66, 15);
            this.lblRarity.TabIndex = 48;
            this.lblRarity.Text = "Raridade";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(31, 189);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(63, 15);
            this.lblSet.TabIndex = 47;
            this.lblSet.Text = "Coleção:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(31, 139);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 15);
            this.lblColor.TabIndex = 46;
            this.lblColor.Text = "Cor(es):";
            // 
            // lblCmc
            // 
            this.lblCmc.AutoSize = true;
            this.lblCmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmc.Location = new System.Drawing.Point(31, 114);
            this.lblCmc.Name = "lblCmc";
            this.lblCmc.Size = new System.Drawing.Size(107, 15);
            this.lblCmc.TabIndex = 45;
            this.lblCmc.Text = "Custo de Mana:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(31, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 44;
            this.lblNome.Text = "Nome:";
            // 
            // listEfeito
            // 
            this.listEfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEfeito.FormattingEnabled = true;
            this.listEfeito.Location = new System.Drawing.Point(418, 3);
            this.listEfeito.Name = "listEfeito";
            this.listEfeito.Size = new System.Drawing.Size(188, 108);
            this.listEfeito.TabIndex = 43;
            this.listEfeito.DoubleClick += new System.EventHandler(this.listEfeito_DoubleClick);
            // 
            // btnFnTipo
            // 
            this.btnFnTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFnTipo.Location = new System.Drawing.Point(295, 13);
            this.btnFnTipo.Name = "btnFnTipo";
            this.btnFnTipo.Size = new System.Drawing.Size(75, 23);
            this.btnFnTipo.TabIndex = 42;
            this.btnFnTipo.Text = "Buscar";
            this.btnFnTipo.UseVisualStyleBackColor = true;
            this.btnFnTipo.Click += new System.EventHandler(this.btnFnTipo_Click);
            // 
            // FormTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 347);
            this.Controls.Add(this.pnlCor);
            this.Name = "FormTipo";
            this.Text = "FormTipo";
            this.pnlCor.ResumeLayout(false);
            this.pnlCor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.ComboBox cbTipos;
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
        private System.Windows.Forms.Button btnFnTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}