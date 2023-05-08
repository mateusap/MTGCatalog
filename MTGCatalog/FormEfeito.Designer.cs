namespace MTGCatalog
{
    partial class FormEfeito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEfeito));
            this.pnlEfeito = new System.Windows.Forms.Panel();
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
            this.btnFnEfeito = new System.Windows.Forms.Button();
            this.tBoxEfeito = new System.Windows.Forms.TextBox();
            this.pnlEfeito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEfeito
            // 
            this.pnlEfeito.AutoSize = true;
            this.pnlEfeito.BackColor = System.Drawing.Color.DarkGray;
            this.pnlEfeito.Controls.Add(this.txtTipo);
            this.pnlEfeito.Controls.Add(this.lblTipo);
            this.pnlEfeito.Controls.Add(this.qtResultado);
            this.pnlEfeito.Controls.Add(this.listBox1);
            this.pnlEfeito.Controls.Add(this.txtRarityR);
            this.pnlEfeito.Controls.Add(this.txtSetR);
            this.pnlEfeito.Controls.Add(this.txtCorR);
            this.pnlEfeito.Controls.Add(this.txtCmcR);
            this.pnlEfeito.Controls.Add(this.txtNomeR);
            this.pnlEfeito.Controls.Add(this.richTextR);
            this.pnlEfeito.Controls.Add(this.pBoxCard);
            this.pnlEfeito.Controls.Add(this.lblText);
            this.pnlEfeito.Controls.Add(this.lblRarity);
            this.pnlEfeito.Controls.Add(this.lblSet);
            this.pnlEfeito.Controls.Add(this.lblColor);
            this.pnlEfeito.Controls.Add(this.lblCmc);
            this.pnlEfeito.Controls.Add(this.lblNome);
            this.pnlEfeito.Controls.Add(this.listEfeito);
            this.pnlEfeito.Controls.Add(this.btnFnEfeito);
            this.pnlEfeito.Controls.Add(this.tBoxEfeito);
            this.pnlEfeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEfeito.Location = new System.Drawing.Point(0, 0);
            this.pnlEfeito.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEfeito.Name = "pnlEfeito";
            this.pnlEfeito.Size = new System.Drawing.Size(685, 412);
            this.pnlEfeito.TabIndex = 48;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.DarkGray;
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(156, 224);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(200, 14);
            this.txtTipo.TabIndex = 65;
            this.txtTipo.Text = "(Resultado)";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(25, 224);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 15);
            this.lblTipo.TabIndex = 64;
            this.lblTipo.Text = "Tipo:";
            // 
            // qtResultado
            // 
            this.qtResultado.AutoSize = true;
            this.qtResultado.Location = new System.Drawing.Point(542, 180);
            this.qtResultado.Name = "qtResultado";
            this.qtResultado.Size = new System.Drawing.Size(108, 13);
            this.qtResultado.TabIndex = 58;
            this.qtResultado.Text = "Resultados de Busca";
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
            this.txtRarityR.BackColor = System.Drawing.Color.DarkGray;
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
            this.txtSetR.BackColor = System.Drawing.Color.DarkGray;
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
            this.txtCorR.BackColor = System.Drawing.Color.DarkGray;
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
            this.txtCmcR.BackColor = System.Drawing.Color.DarkGray;
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
            this.txtNomeR.BackColor = System.Drawing.Color.DarkGray;
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
            this.richTextR.BackColor = System.Drawing.Color.DarkGray;
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
            this.listEfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEfeito.FormattingEnabled = true;
            this.listEfeito.Location = new System.Drawing.Point(527, 3);
            this.listEfeito.Name = "listEfeito";
            this.listEfeito.Size = new System.Drawing.Size(146, 173);
            this.listEfeito.TabIndex = 43;
            this.listEfeito.DoubleClick += new System.EventHandler(this.listEfeito_DoubleClick);
            // 
            // btnFnEfeito
            // 
            this.btnFnEfeito.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFnEfeito.Location = new System.Drawing.Point(422, 12);
            this.btnFnEfeito.Name = "btnFnEfeito";
            this.btnFnEfeito.Size = new System.Drawing.Size(75, 23);
            this.btnFnEfeito.TabIndex = 42;
            this.btnFnEfeito.Text = "Buscar";
            this.btnFnEfeito.UseVisualStyleBackColor = true;
            this.btnFnEfeito.Click += new System.EventHandler(this.btnFnEfeito_Click);
            // 
            // tBoxEfeito
            // 
            this.tBoxEfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEfeito.ForeColor = System.Drawing.Color.LightGray;
            this.tBoxEfeito.Location = new System.Drawing.Point(28, 25);
            this.tBoxEfeito.Name = "tBoxEfeito";
            this.tBoxEfeito.Size = new System.Drawing.Size(177, 23);
            this.tBoxEfeito.TabIndex = 40;
            this.tBoxEfeito.Text = "Digite parte do texto";
            this.tBoxEfeito.TextChanged += new System.EventHandler(this.tBoxEfeito_TextChanged);
            this.tBoxEfeito.Enter += new System.EventHandler(this.tBoxEfeito_Enter);
            this.tBoxEfeito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxEfeito_KeyDown);
            this.tBoxEfeito.Leave += new System.EventHandler(this.tBoxEfeito_Leave);
            // 
            // FormEfeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.pnlEfeito);
            this.Name = "FormEfeito";
            this.Text = "FormEfeito";
            this.pnlEfeito.ResumeLayout(false);
            this.pnlEfeito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlEfeito;
        private System.Windows.Forms.ListBox listEfeito;
        private System.Windows.Forms.Button btnFnEfeito;
        private System.Windows.Forms.TextBox tBoxEfeito;
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
        private System.Windows.Forms.Label qtResultado;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}