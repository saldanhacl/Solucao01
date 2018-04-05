namespace Sagrado
{
    partial class MenuFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFunc));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tROCARUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNCERRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerencia = new System.Windows.Forms.Button();
            this.btnGerenUser = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "REGISTRAR ENTRADA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(439, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "CADASTRAR CLIENTE";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tROCARUSUÁRIOToolStripMenuItem,
            this.eNCERRARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tROCARUSUÁRIOToolStripMenuItem
            // 
            this.tROCARUSUÁRIOToolStripMenuItem.Name = "tROCARUSUÁRIOToolStripMenuItem";
            this.tROCARUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.tROCARUSUÁRIOToolStripMenuItem.Text = "TROCAR USUÁRIO";
            this.tROCARUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.tROCARUSUÁRIOToolStripMenuItem_Click);
            // 
            // eNCERRARToolStripMenuItem
            // 
            this.eNCERRARToolStripMenuItem.Name = "eNCERRARToolStripMenuItem";
            this.eNCERRARToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.eNCERRARToolStripMenuItem.Text = "ENCERRAR SISTEMA";
            this.eNCERRARToolStripMenuItem.Click += new System.EventHandler(this.eNCERRARToolStripMenuItem_Click);
            // 
            // btnGerencia
            // 
            this.btnGerencia.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CAIXA2;
            this.btnGerencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerencia.ForeColor = System.Drawing.Color.White;
            this.btnGerencia.Location = new System.Drawing.Point(171, 203);
            this.btnGerencia.Name = "btnGerencia";
            this.btnGerencia.Size = new System.Drawing.Size(200, 100);
            this.btnGerencia.TabIndex = 1;
            this.btnGerencia.UseVisualStyleBackColor = true;
            this.btnGerencia.Click += new System.EventHandler(this.btnGerencia_Click);
            // 
            // btnGerenUser
            // 
            this.btnGerenUser.Image = global::Sagrado.Properties.Resources.BTN_ADDCLIENTE;
            this.btnGerenUser.Location = new System.Drawing.Point(415, 203);
            this.btnGerenUser.Name = "btnGerenUser";
            this.btnGerenUser.Size = new System.Drawing.Size(200, 100);
            this.btnGerenUser.TabIndex = 2;
            this.btnGerenUser.UseVisualStyleBackColor = true;
            this.btnGerenUser.Click += new System.EventHandler(this.btnGerenUser_Click);
            // 
            // MenuFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnGerencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGerenUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAINEL FUNCIONÁRIO";
            this.Load += new System.EventHandler(this.MenuFunc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGerencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGerenUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tROCARUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNCERRARToolStripMenuItem;
    }
}