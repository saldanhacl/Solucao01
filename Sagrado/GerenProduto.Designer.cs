namespace Sagrado
{
    partial class GerenProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenProduto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pAINELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tROCARUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNCERRARSISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_ADD_PRODUTO = new System.Windows.Forms.Button();
            this.BTN_CONSUL_PRODUTO = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "ADICIONAR PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(425, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "GERENCIAR PRODUTO";
            // 
            // BTN_ADD_PRODUTO
            // 
            this.BTN_ADD_PRODUTO.BackgroundImage = global::Sagrado.Properties.Resources.BTN_ADD_PRODUTO;
            this.BTN_ADD_PRODUTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_ADD_PRODUTO.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_PRODUTO.Location = new System.Drawing.Point(170, 134);
            this.BTN_ADD_PRODUTO.Name = "BTN_ADD_PRODUTO";
            this.BTN_ADD_PRODUTO.Size = new System.Drawing.Size(200, 100);
            this.BTN_ADD_PRODUTO.TabIndex = 2;
            this.BTN_ADD_PRODUTO.UseVisualStyleBackColor = true;
            this.BTN_ADD_PRODUTO.Click += new System.EventHandler(this.BTN_ADD_PRODUTO_Click);
            // 
            // BTN_CONSUL_PRODUTO
            // 
            this.BTN_CONSUL_PRODUTO.Image = global::Sagrado.Properties.Resources.BTN_CONSULTAR_PRODUTO;
            this.BTN_CONSUL_PRODUTO.Location = new System.Drawing.Point(403, 134);
            this.BTN_CONSUL_PRODUTO.Name = "BTN_CONSUL_PRODUTO";
            this.BTN_CONSUL_PRODUTO.Size = new System.Drawing.Size(200, 100);
            this.BTN_CONSUL_PRODUTO.TabIndex = 5;
            this.BTN_CONSUL_PRODUTO.UseVisualStyleBackColor = true;
            this.BTN_CONSUL_PRODUTO.Click += new System.EventHandler(this.BTN_CONSUL_PRODUTO_Click);
            // 
            // GerenProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BTN_ADD_PRODUTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_CONSUL_PRODUTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIAR PRODUTO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pAINELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tROCARUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNCERRARSISTEMAToolStripMenuItem;
        private System.Windows.Forms.Button BTN_ADD_PRODUTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CONSUL_PRODUTO;
        private System.Windows.Forms.Label label2;
    }
}