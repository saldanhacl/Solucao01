namespace Sagrado
{
    partial class GerenUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pAINELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tROCARUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNCERRARSISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_ADD_USER = new System.Windows.Forms.Button();
            this.BTN_CONSUL_USER = new System.Windows.Forms.Button();
            this.BTN_EDIT_USER = new System.Windows.Forms.Button();
            this.BTN_EXCLUIR_USER = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "ADICIONAR USUÁRIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(428, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "CONSULTAR USUÁRIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "ALTERAR USUÁRIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(195, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "EXCLUIR USUÁRIO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pAINELToolStripMenuItem,
            this.tROCARUSUÁRIOToolStripMenuItem,
            this.eNCERRARSISTEMAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pAINELToolStripMenuItem
            // 
            this.pAINELToolStripMenuItem.Name = "pAINELToolStripMenuItem";
            this.pAINELToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pAINELToolStripMenuItem.Text = "PAINEL";
            this.pAINELToolStripMenuItem.Click += new System.EventHandler(this.pAINELToolStripMenuItem_Click);
            // 
            // tROCARUSUÁRIOToolStripMenuItem
            // 
            this.tROCARUSUÁRIOToolStripMenuItem.Name = "tROCARUSUÁRIOToolStripMenuItem";
            this.tROCARUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.tROCARUSUÁRIOToolStripMenuItem.Text = "TROCAR USUÁRIO";
            this.tROCARUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.tROCARUSUÁRIOToolStripMenuItem_Click);
            // 
            // eNCERRARSISTEMAToolStripMenuItem
            // 
            this.eNCERRARSISTEMAToolStripMenuItem.Name = "eNCERRARSISTEMAToolStripMenuItem";
            this.eNCERRARSISTEMAToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.eNCERRARSISTEMAToolStripMenuItem.Text = "ENCERRAR SISTEMA";
            this.eNCERRARSISTEMAToolStripMenuItem.Click += new System.EventHandler(this.eNCERRARSISTEMAToolStripMenuItem_Click);
            // 
            // BTN_ADD_USER
            // 
            this.BTN_ADD_USER.BackgroundImage = global::Sagrado.Properties.Resources.BTN_ADD_USER;
            this.BTN_ADD_USER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_ADD_USER.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_USER.Location = new System.Drawing.Point(160, 117);
            this.BTN_ADD_USER.Name = "BTN_ADD_USER";
            this.BTN_ADD_USER.Size = new System.Drawing.Size(200, 100);
            this.BTN_ADD_USER.TabIndex = 62;
            this.BTN_ADD_USER.UseVisualStyleBackColor = true;
            this.BTN_ADD_USER.Click += new System.EventHandler(this.BTN_ADD_USER_Click);
            // 
            // BTN_CONSUL_USER
            // 
            this.BTN_CONSUL_USER.Image = global::Sagrado.Properties.Resources.BTN_CONSULTAR_USER;
            this.BTN_CONSUL_USER.Location = new System.Drawing.Point(404, 293);
            this.BTN_CONSUL_USER.Name = "BTN_CONSUL_USER";
            this.BTN_CONSUL_USER.Size = new System.Drawing.Size(200, 100);
            this.BTN_CONSUL_USER.TabIndex = 60;
            this.BTN_CONSUL_USER.UseVisualStyleBackColor = true;
            this.BTN_CONSUL_USER.Click += new System.EventHandler(this.BTN_CONSUL_USER_Click);
            // 
            // BTN_EDIT_USER
            // 
            this.BTN_EDIT_USER.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EDIT_USER;
            this.BTN_EDIT_USER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_EDIT_USER.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT_USER.Location = new System.Drawing.Point(404, 117);
            this.BTN_EDIT_USER.Name = "BTN_EDIT_USER";
            this.BTN_EDIT_USER.Size = new System.Drawing.Size(200, 100);
            this.BTN_EDIT_USER.TabIndex = 58;
            this.BTN_EDIT_USER.UseVisualStyleBackColor = true;
            this.BTN_EDIT_USER.Click += new System.EventHandler(this.BTN_EDIT_USER_Click);
            // 
            // BTN_EXCLUIR_USER
            // 
            this.BTN_EXCLUIR_USER.Image = global::Sagrado.Properties.Resources.BTN_EXCLUIR_USER;
            this.BTN_EXCLUIR_USER.Location = new System.Drawing.Point(160, 293);
            this.BTN_EXCLUIR_USER.Name = "BTN_EXCLUIR_USER";
            this.BTN_EXCLUIR_USER.Size = new System.Drawing.Size(200, 100);
            this.BTN_EXCLUIR_USER.TabIndex = 56;
            this.BTN_EXCLUIR_USER.UseVisualStyleBackColor = true;
            this.BTN_EXCLUIR_USER.Click += new System.EventHandler(this.BTN_EXCLUIR_USER_Click);
            // 
            // GerenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BTN_ADD_USER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_CONSUL_USER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_EDIT_USER);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_EXCLUIR_USER);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GerenUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIAMENTO DE USUÁRIO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button BTN_ADD_USER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CONSUL_USER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_EDIT_USER;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_EXCLUIR_USER;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pAINELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tROCARUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNCERRARSISTEMAToolStripMenuItem;
    }
}