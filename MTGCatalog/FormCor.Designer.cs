﻿namespace MTGCatalog
{
    partial class FormCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCor));
            this.pnlCor = new System.Windows.Forms.Panel();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cBoxCmc = new System.Windows.Forms.ComboBox();
            this.cBoxCorIndic = new System.Windows.Forms.ComboBox();
            this.qtResultado = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.cListCores = new System.Windows.Forms.CheckedListBox();
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
            this.btnFnCor = new System.Windows.Forms.Button();
            this.pnlCor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCor
            // 
            this.pnlCor.AutoSize = true;
            this.pnlCor.BackColor = System.Drawing.Color.DarkGray;
            this.pnlCor.Controls.Add(this.txtTipo);
            this.pnlCor.Controls.Add(this.lblTipo);
            this.pnlCor.Controls.Add(this.cBoxCmc);
            this.pnlCor.Controls.Add(this.cBoxCorIndic);
            this.pnlCor.Controls.Add(this.qtResultado);
            this.pnlCor.Controls.Add(this.txtCusto);
            this.pnlCor.Controls.Add(this.cListCores);
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
            this.pnlCor.Controls.Add(this.btnFnCor);
            this.pnlCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCor.Location = new System.Drawing.Point(0, 0);
            this.pnlCor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(685, 412);
            this.pnlCor.TabIndex = 49;
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
            // cBoxCmc
            // 
            this.cBoxCmc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCmc.FormattingEnabled = true;
            this.cBoxCmc.Location = new System.Drawing.Point(180, 65);
            this.cBoxCmc.Name = "cBoxCmc";
            this.cBoxCmc.Size = new System.Drawing.Size(121, 21);
            this.cBoxCmc.TabIndex = 62;
            // 
            // cBoxCorIndic
            // 
            this.cBoxCorIndic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCorIndic.FormattingEnabled = true;
            this.cBoxCorIndic.Location = new System.Drawing.Point(180, 14);
            this.cBoxCorIndic.Name = "cBoxCorIndic";
            this.cBoxCorIndic.Size = new System.Drawing.Size(121, 21);
            this.cBoxCorIndic.TabIndex = 61;
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
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.ForeColor = System.Drawing.Color.LightGray;
            this.txtCusto.Location = new System.Drawing.Point(331, 65);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(75, 20);
            this.txtCusto.TabIndex = 59;
            this.txtCusto.Text = "Custo";
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCusto.Enter += new System.EventHandler(this.txtCusto_Enter);
            this.txtCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusto_KeyDown);
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // cListCores
            // 
            this.cListCores.CheckOnClick = true;
            this.cListCores.FormattingEnabled = true;
            this.cListCores.Location = new System.Drawing.Point(28, 12);
            this.cListCores.Name = "cListCores";
            this.cListCores.Size = new System.Drawing.Size(120, 94);
            this.cListCores.TabIndex = 58;
            this.cListCores.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cListCores_ItemCheck);
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
            // btnFnCor
            // 
            this.btnFnCor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFnCor.Location = new System.Drawing.Point(422, 12);
            this.btnFnCor.Name = "btnFnCor";
            this.btnFnCor.Size = new System.Drawing.Size(75, 23);
            this.btnFnCor.TabIndex = 42;
            this.btnFnCor.Text = "Buscar";
            this.btnFnCor.UseVisualStyleBackColor = true;
            this.btnFnCor.Click += new System.EventHandler(this.btnFnCor_Click);
            // 
            // FormCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.pnlCor);
            this.Name = "FormCor";
            this.Text = "FormCor";
            this.pnlCor.ResumeLayout(false);
            this.pnlCor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCor;
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
        private System.Windows.Forms.Button btnFnCor;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.CheckedListBox cListCores;
        private System.Windows.Forms.Label qtResultado;
        private System.Windows.Forms.ComboBox cBoxCmc;
        private System.Windows.Forms.ComboBox cBoxCorIndic;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}