﻿namespace Sagrado
{
    partial class GerenClienteAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenClienteAdm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BTN_ADD_CLIENTE = new System.Windows.Forms.Button();
            this.BTN_CONSUL_CLIENTE = new System.Windows.Forms.Button();
            this.BTN_EDIT_CLIENTE = new System.Windows.Forms.Button();
            this.BTN_EXCLUIR_CLIENTE = new System.Windows.Forms.Button();
            this.tROCARUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "ADICIONAR CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(430, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "CONSULTAR CLIENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "ALTERAR CLIENTE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(197, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "EXCLUIR CLIENTE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tROCARUSUÁRIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BTN_ADD_CLIENTE
            // 
            this.BTN_ADD_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_ADD_CLIENTE;
            this.BTN_ADD_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ADD_CLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_CLIENTE.Location = new System.Drawing.Point(162, 123);
            this.BTN_ADD_CLIENTE.Name = "BTN_ADD_CLIENTE";
            this.BTN_ADD_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_ADD_CLIENTE.TabIndex = 2;
            this.BTN_ADD_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_ADD_CLIENTE.Click += new System.EventHandler(this.BTN_ADD_CLIENTE_Click);
            // 
            // BTN_CONSUL_CLIENTE
            // 
            this.BTN_CONSUL_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CONSULTAR_CLIENTE;
            this.BTN_CONSUL_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_CONSUL_CLIENTE.Location = new System.Drawing.Point(406, 299);
            this.BTN_CONSUL_CLIENTE.Name = "BTN_CONSUL_CLIENTE";
            this.BTN_CONSUL_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_CONSUL_CLIENTE.TabIndex = 5;
            this.BTN_CONSUL_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_CONSUL_CLIENTE.Click += new System.EventHandler(this.BTN_CONSUL_CLIENTE_Click);
            // 
            // BTN_EDIT_CLIENTE
            // 
            this.BTN_EDIT_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EDIT_CLIENTE;
            this.BTN_EDIT_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_EDIT_CLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT_CLIENTE.Location = new System.Drawing.Point(406, 123);
            this.BTN_EDIT_CLIENTE.Name = "BTN_EDIT_CLIENTE";
            this.BTN_EDIT_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_EDIT_CLIENTE.TabIndex = 3;
            this.BTN_EDIT_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_EDIT_CLIENTE.Click += new System.EventHandler(this.BTN_EDIT_CLIENTE_Click);
            // 
            // BTN_EXCLUIR_CLIENTE
            // 
            this.BTN_EXCLUIR_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EXCLUIR;
            this.BTN_EXCLUIR_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_EXCLUIR_CLIENTE.Location = new System.Drawing.Point(162, 299);
            this.BTN_EXCLUIR_CLIENTE.Name = "BTN_EXCLUIR_CLIENTE";
            this.BTN_EXCLUIR_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_EXCLUIR_CLIENTE.TabIndex = 4;
            this.BTN_EXCLUIR_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_EXCLUIR_CLIENTE.Click += new System.EventHandler(this.BTN_EXCLUIR_CLIENTE_Click);
            // 
            // tROCARUSUÁRIOToolStripMenuItem
            // 
            this.tROCARUSUÁRIOToolStripMenuItem.Name = "tROCARUSUÁRIOToolStripMenuItem";
            this.tROCARUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.tROCARUSUÁRIOToolStripMenuItem.Text = "TROCAR USUÁRIO";
            this.tROCARUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.tROCARUSUÁRIOToolStripMenuItem_Click);
            // 
            // GerenClienteAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BTN_ADD_CLIENTE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_CONSUL_CLIENTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_EDIT_CLIENTE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_EXCLUIR_CLIENTE);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenClienteAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIAR CLIENTE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ADD_CLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CONSUL_CLIENTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_EDIT_CLIENTE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_EXCLUIR_CLIENTE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tROCARUSUÁRIOToolStripMenuItem;
    }
}