﻿namespace MTGCatalog
{
    partial class FormNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNome));
            this.pnlNome = new System.Windows.Forms.Panel();
            this.btnFnNome = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
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
            this.pnlNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNome
            // 
            this.pnlNome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlNome.Controls.Add(this.listBox1);
            this.pnlNome.Controls.Add(this.txtRarityR);
            this.pnlNome.Controls.Add(this.txtSetR);
            this.pnlNome.Controls.Add(this.txtCorR);
            this.pnlNome.Controls.Add(this.txtCmcR);
            this.pnlNome.Controls.Add(this.txtNomeR);
            this.pnlNome.Controls.Add(this.richTextR);
            this.pnlNome.Controls.Add(this.pBoxCard);
            this.pnlNome.Controls.Add(this.lblText);
            this.pnlNome.Controls.Add(this.lblRarity);
            this.pnlNome.Controls.Add(this.lblSet);
            this.pnlNome.Controls.Add(this.lblColor);
            this.pnlNome.Controls.Add(this.lblCmc);
            this.pnlNome.Controls.Add(this.lblNome);
            this.pnlNome.Controls.Add(this.btnFnNome);
            this.pnlNome.Controls.Add(this.lblDescricao);
            this.pnlNome.Controls.Add(this.tBoxNome);
            this.pnlNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNome.Location = new System.Drawing.Point(0, 0);
            this.pnlNome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(618, 314);
            this.pnlNome.TabIndex = 17;
            // 
            // btnFnNome
            // 
            this.btnFnNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFnNome.Location = new System.Drawing.Point(234, 12);
            this.btnFnNome.Name = "btnFnNome";
            this.btnFnNome.Size = new System.Drawing.Size(75, 23);
            this.btnFnNome.TabIndex = 45;
            this.btnFnNome.Text = "Buscar";
            this.btnFnNome.UseVisualStyleBackColor = true;
            this.btnFnNome.Click += new System.EventHandler(this.btnFnNome_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(34, 38);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(177, 26);
            this.lblDescricao.TabIndex = 44;
            this.lblDescricao.Text = "Digite o nome da carta\r\n(não precisa ser exato)";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNome.Location = new System.Drawing.Point(34, 12);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(177, 23);
            this.tBoxNome.TabIndex = 43;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(162, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 34);
            this.listBox1.TabIndex = 59;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // txtRarityR
            // 
            this.txtRarityR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRarityR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRarityR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRarityR.Location = new System.Drawing.Point(162, 189);
            this.txtRarityR.Name = "txtRarityR";
            this.txtRarityR.ReadOnly = true;
            this.txtRarityR.Size = new System.Drawing.Size(100, 14);
            this.txtRarityR.TabIndex = 58;
            this.txtRarityR.Text = "(Resultado)";
            // 
            // txtSetR
            // 
            this.txtSetR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSetR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetR.Location = new System.Drawing.Point(162, 164);
            this.txtSetR.Name = "txtSetR";
            this.txtSetR.ReadOnly = true;
            this.txtSetR.Size = new System.Drawing.Size(250, 14);
            this.txtSetR.TabIndex = 57;
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
            this.txtCorR.TabIndex = 56;
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
            this.txtCmcR.TabIndex = 55;
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
            this.txtNomeR.TabIndex = 54;
            this.txtNomeR.Text = "(Resultado)";
            // 
            // richTextR
            // 
            this.richTextR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextR.Location = new System.Drawing.Point(162, 214);
            this.richTextR.Name = "richTextR";
            this.richTextR.ReadOnly = true;
            this.richTextR.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextR.Size = new System.Drawing.Size(260, 97);
            this.richTextR.TabIndex = 53;
            this.richTextR.Text = "(Resultado)";
            // 
            // pBoxCard
            // 
            this.pBoxCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxCard.BackgroundImage")));
            this.pBoxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxCard.Location = new System.Drawing.Point(448, 90);
            this.pBoxCard.Name = "pBoxCard";
            this.pBoxCard.Size = new System.Drawing.Size(158, 220);
            this.pBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCard.TabIndex = 52;
            this.pBoxCard.TabStop = false;
            this.pBoxCard.WaitOnLoad = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(32, 214);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(48, 15);
            this.lblText.TabIndex = 51;
            this.lblText.Text = "Efeito:";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRarity.Location = new System.Drawing.Point(31, 189);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(66, 15);
            this.lblRarity.TabIndex = 50;
            this.lblRarity.Text = "Raridade";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(31, 164);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(63, 15);
            this.lblSet.TabIndex = 49;
            this.lblSet.Text = "Coleção:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(31, 139);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 15);
            this.lblColor.TabIndex = 48;
            this.lblColor.Text = "Cor(es):";
            // 
            // lblCmc
            // 
            this.lblCmc.AutoSize = true;
            this.lblCmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmc.Location = new System.Drawing.Point(31, 114);
            this.lblCmc.Name = "lblCmc";
            this.lblCmc.Size = new System.Drawing.Size(107, 15);
            this.lblCmc.TabIndex = 47;
            this.lblCmc.Text = "Custo de Mana:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(31, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome:";
            // 
            // FormNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 314);
            this.Controls.Add(this.pnlNome);
            this.Name = "FormNome";
            this.Text = "FormNome";
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.Button btnFnNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tBoxNome;
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
    }
}