namespace Sagrado
{
    partial class ExcluirUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirUser));
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_CANC = new System.Windows.Forms.Button();
            this.BTN_CONF = new System.Windows.Forms.Button();
            this.TXT_CPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.Location = new System.Drawing.Point(242, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "CPF:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EXCLUIR;
            this.pictureBox1.Location = new System.Drawing.Point(288, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_CANC
            // 
            this.BTN_CANC.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CANC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANC.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CANC.Location = new System.Drawing.Point(364, 299);
            this.BTN_CANC.Name = "BTN_CANC";
            this.BTN_CANC.Size = new System.Drawing.Size(51, 51);
            this.BTN_CANC.TabIndex = 2;
            this.BTN_CANC.UseVisualStyleBackColor = true;
            this.BTN_CANC.Click += new System.EventHandler(this.BTN_CANC_Click);
            // 
            // BTN_CONF
            // 
            this.BTN_CONF.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK;
            this.BTN_CONF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONF.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CONF.Location = new System.Drawing.Point(437, 299);
            this.BTN_CONF.Name = "BTN_CONF";
            this.BTN_CONF.Size = new System.Drawing.Size(51, 51);
            this.BTN_CONF.TabIndex = 3;
            this.BTN_CONF.UseVisualStyleBackColor = true;
            this.BTN_CONF.Click += new System.EventHandler(this.BTN_CONF_Click);
            // 
            // TXT_CPF
            // 
            this.TXT_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_CPF.Location = new System.Drawing.Point(291, 249);
            this.TXT_CPF.Mask = "000.000.000-00";
            this.TXT_CPF.Name = "TXT_CPF";
            this.TXT_CPF.Size = new System.Drawing.Size(200, 24);
            this.TXT_CPF.TabIndex = 99;
            this.TXT_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExcluirUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TXT_CPF);
            this.Controls.Add(this.BTN_CANC);
            this.Controls.Add(this.BTN_CONF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcluirUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXCLUIR USUÁRIO";
            this.Load += new System.EventHandler(this.ExcluirUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_CANC;
        private System.Windows.Forms.Button BTN_CONF;
        private System.Windows.Forms.MaskedTextBox TXT_CPF;
    }
}