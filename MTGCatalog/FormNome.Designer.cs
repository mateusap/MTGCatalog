namespace MTGCatalog
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
            this.pnlResultado = new System.Windows.Forms.Panel();
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
            this.btnFnNome = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.pnlNome.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNome
            // 
            this.pnlNome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlNome.Controls.Add(this.pnlResultado);
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
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.txtRarityR);
            this.pnlResultado.Controls.Add(this.txtSetR);
            this.pnlResultado.Controls.Add(this.txtCorR);
            this.pnlResultado.Controls.Add(this.txtCmcR);
            this.pnlResultado.Controls.Add(this.txtNomeR);
            this.pnlResultado.Controls.Add(this.richTextR);
            this.pnlResultado.Controls.Add(this.pBoxCard);
            this.pnlResultado.Controls.Add(this.lblText);
            this.pnlResultado.Controls.Add(this.lblRarity);
            this.pnlResultado.Controls.Add(this.lblSet);
            this.pnlResultado.Controls.Add(this.lblColor);
            this.pnlResultado.Controls.Add(this.lblCmc);
            this.pnlResultado.Controls.Add(this.lblNome);
            this.pnlResultado.Location = new System.Drawing.Point(0, 83);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(617, 231);
            this.pnlResultado.TabIndex = 46;
            // 
            // txtRarityR
            // 
            this.txtRarityR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRarityR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRarityR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRarityR.Location = new System.Drawing.Point(161, 106);
            this.txtRarityR.Name = "txtRarityR";
            this.txtRarityR.ReadOnly = true;
            this.txtRarityR.Size = new System.Drawing.Size(100, 14);
            this.txtRarityR.TabIndex = 35;
            this.txtRarityR.Text = "(Resultado)";
            // 
            // txtSetR
            // 
            this.txtSetR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSetR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetR.Location = new System.Drawing.Point(161, 81);
            this.txtSetR.Name = "txtSetR";
            this.txtSetR.ReadOnly = true;
            this.txtSetR.Size = new System.Drawing.Size(250, 14);
            this.txtSetR.TabIndex = 34;
            this.txtSetR.Text = "(Resultado)";
            // 
            // txtCorR
            // 
            this.txtCorR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCorR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorR.Location = new System.Drawing.Point(161, 56);
            this.txtCorR.Name = "txtCorR";
            this.txtCorR.ReadOnly = true;
            this.txtCorR.Size = new System.Drawing.Size(100, 14);
            this.txtCorR.TabIndex = 33;
            this.txtCorR.Text = "(Resultado)";
            // 
            // txtCmcR
            // 
            this.txtCmcR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCmcR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCmcR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmcR.Location = new System.Drawing.Point(161, 31);
            this.txtCmcR.Name = "txtCmcR";
            this.txtCmcR.ReadOnly = true;
            this.txtCmcR.Size = new System.Drawing.Size(100, 14);
            this.txtCmcR.TabIndex = 32;
            this.txtCmcR.Text = "(Resultado)";
            // 
            // txtNomeR
            // 
            this.txtNomeR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNomeR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeR.Location = new System.Drawing.Point(161, 6);
            this.txtNomeR.Name = "txtNomeR";
            this.txtNomeR.ReadOnly = true;
            this.txtNomeR.Size = new System.Drawing.Size(250, 14);
            this.txtNomeR.TabIndex = 31;
            this.txtNomeR.Text = "(Resultado)";
            // 
            // richTextR
            // 
            this.richTextR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextR.Location = new System.Drawing.Point(161, 131);
            this.richTextR.Name = "richTextR";
            this.richTextR.ReadOnly = true;
            this.richTextR.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextR.Size = new System.Drawing.Size(260, 97);
            this.richTextR.TabIndex = 30;
            this.richTextR.Text = "(Resultado)";
            // 
            // pBoxCard
            // 
            this.pBoxCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxCard.BackgroundImage")));
            this.pBoxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxCard.Location = new System.Drawing.Point(447, 6);
            this.pBoxCard.Name = "pBoxCard";
            this.pBoxCard.Size = new System.Drawing.Size(158, 220);
            this.pBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCard.TabIndex = 28;
            this.pBoxCard.TabStop = false;
            this.pBoxCard.WaitOnLoad = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(31, 131);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(48, 15);
            this.lblText.TabIndex = 21;
            this.lblText.Text = "Efeito:";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRarity.Location = new System.Drawing.Point(30, 106);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(66, 15);
            this.lblRarity.TabIndex = 20;
            this.lblRarity.Text = "Raridade";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(30, 81);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(63, 15);
            this.lblSet.TabIndex = 19;
            this.lblSet.Text = "Coleção:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(30, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 15);
            this.lblColor.TabIndex = 18;
            this.lblColor.Text = "Cor(es):";
            // 
            // lblCmc
            // 
            this.lblCmc.AutoSize = true;
            this.lblCmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmc.Location = new System.Drawing.Point(30, 31);
            this.lblCmc.Name = "lblCmc";
            this.lblCmc.Size = new System.Drawing.Size(107, 15);
            this.lblCmc.TabIndex = 17;
            this.lblCmc.Text = "Custo de Mana:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(30, 6);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome:";
            // 
            // btnFnNome
            // 
            this.btnFnNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFnNome.Location = new System.Drawing.Point(259, 22);
            this.btnFnNome.Name = "btnFnNome";
            this.btnFnNome.Size = new System.Drawing.Size(75, 23);
            this.btnFnNome.TabIndex = 45;
            this.btnFnNome.Text = "Buscar";
            this.btnFnNome.UseVisualStyleBackColor = true;
            this.btnFnNome.Click += new System.EventHandler(this.btnFnNome_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(80, 48);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(114, 26);
            this.lblDescricao.TabIndex = 44;
            this.lblDescricao.Text = "Digite o nome da carta\r\n(não precisa ser exato)";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNome.Location = new System.Drawing.Point(48, 22);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(177, 23);
            this.tBoxNome.TabIndex = 43;
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
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.Button btnFnNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Panel pnlResultado;
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