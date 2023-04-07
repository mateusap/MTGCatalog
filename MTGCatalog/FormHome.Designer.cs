﻿namespace MTGCatalog
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
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(136, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 412);
            this.panel1.TabIndex = 46;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
    }
}

