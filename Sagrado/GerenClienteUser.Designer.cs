namespace Sagrado
{
    partial class GerenClienteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenClienteUser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tROCARUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_ADD_CLIENTE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_CONSUL_CLIENTE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_EDIT_CLIENTE = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // tROCARUSUÁRIOToolStripMenuItem
            // 
            this.tROCARUSUÁRIOToolStripMenuItem.Name = "tROCARUSUÁRIOToolStripMenuItem";
            this.tROCARUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.tROCARUSUÁRIOToolStripMenuItem.Text = "TROCAR USUÁRIO";
            this.tROCARUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.tROCARUSUÁRIOToolStripMenuItem_Click);
            // 
            // BTN_ADD_CLIENTE
            // 
            this.BTN_ADD_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_ADD_CLIENTE;
            this.BTN_ADD_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_ADD_CLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_CLIENTE.Location = new System.Drawing.Point(44, 216);
            this.BTN_ADD_CLIENTE.Name = "BTN_ADD_CLIENTE";
            this.BTN_ADD_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_ADD_CLIENTE.TabIndex = 2;
            this.BTN_ADD_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_ADD_CLIENTE.Click += new System.EventHandler(this.BTN_ADD_CLIENTE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "ADICIONAR CLIENTE";
            // 
            // BTN_CONSUL_CLIENTE
            // 
            this.BTN_CONSUL_CLIENTE.Image = global::Sagrado.Properties.Resources.BTN_CONSULTAR_CLIENTE;
            this.BTN_CONSUL_CLIENTE.Location = new System.Drawing.Point(533, 216);
            this.BTN_CONSUL_CLIENTE.Name = "BTN_CONSUL_CLIENTE";
            this.BTN_CONSUL_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_CONSUL_CLIENTE.TabIndex = 4;
            this.BTN_CONSUL_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_CONSUL_CLIENTE.Click += new System.EventHandler(this.BTN_CONSUL_CLIENTE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(557, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "CONSULTAR CLIENTE";
            // 
            // BTN_EDIT_CLIENTE
            // 
            this.BTN_EDIT_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EDIT_CLIENTE;
            this.BTN_EDIT_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_EDIT_CLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT_CLIENTE.Location = new System.Drawing.Point(288, 216);
            this.BTN_EDIT_CLIENTE.Name = "BTN_EDIT_CLIENTE";
            this.BTN_EDIT_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_EDIT_CLIENTE.TabIndex = 3;
            this.BTN_EDIT_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_EDIT_CLIENTE.Click += new System.EventHandler(this.BTN_EDIT_CLIENTE_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "ALTERAR CLIENTE";
            // 
            // GerenClienteUser
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenClienteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIAR CLIENTE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tROCARUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.Button BTN_ADD_CLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CONSUL_CLIENTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_EDIT_CLIENTE;
        private System.Windows.Forms.Label label7;
    }
}