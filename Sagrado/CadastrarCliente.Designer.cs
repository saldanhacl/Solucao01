namespace Sagrado
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPF_CLIE = new System.Windows.Forms.MaskedTextBox();
            this.TEL_CLIE = new System.Windows.Forms.MaskedTextBox();
            this.CEL_CLIE = new System.Windows.Forms.MaskedTextBox();
            this.BTN_CANC = new System.Windows.Forms.Button();
            this.BTN_CONF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.Location = new System.Drawing.Point(52, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "NOME:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.textBox1.Location = new System.Drawing.Point(123, 223);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 40;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.Location = new System.Drawing.Point(68, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "CPF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label12.Location = new System.Drawing.Point(304, 267);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 18);
            this.label12.TabIndex = 52;
            this.label12.Text = "CEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.Location = new System.Drawing.Point(71, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "TEL:";
            // 
            // CPF_CLIE
            // 
            this.CPF_CLIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.CPF_CLIE.Location = new System.Drawing.Point(123, 184);
            this.CPF_CLIE.Mask = "000.000.000-00";
            this.CPF_CLIE.Name = "CPF_CLIE";
            this.CPF_CLIE.Size = new System.Drawing.Size(200, 24);
            this.CPF_CLIE.TabIndex = 1;
            this.CPF_CLIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CPF_CLIE.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // TEL_CLIE
            // 
            this.TEL_CLIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TEL_CLIE.Location = new System.Drawing.Point(123, 262);
            this.TEL_CLIE.Mask = "(00) 0000-0000";
            this.TEL_CLIE.Name = "TEL_CLIE";
            this.TEL_CLIE.Size = new System.Drawing.Size(160, 24);
            this.TEL_CLIE.TabIndex = 3;
            this.TEL_CLIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TEL_CLIE.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // CEL_CLIE
            // 
            this.CEL_CLIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.CEL_CLIE.Location = new System.Drawing.Point(364, 262);
            this.CEL_CLIE.Mask = "(00) 00000-0000";
            this.CEL_CLIE.Name = "CEL_CLIE";
            this.CEL_CLIE.Size = new System.Drawing.Size(160, 24);
            this.CEL_CLIE.TabIndex = 4;
            this.CEL_CLIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_CANC
            // 
            this.BTN_CANC.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CANC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANC.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CANC.Location = new System.Drawing.Point(395, 316);
            this.BTN_CANC.Name = "BTN_CANC";
            this.BTN_CANC.Size = new System.Drawing.Size(0, 0);
            this.BTN_CANC.TabIndex = 5;
            this.BTN_CANC.UseVisualStyleBackColor = true;
            this.BTN_CANC.Click += new System.EventHandler(this.BTN_CANC_Click);
            // 
            // BTN_CONF
            // 
            this.BTN_CONF.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SAVE;
            this.BTN_CONF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONF.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CONF.Location = new System.Drawing.Point(484, 316);
            this.BTN_CONF.Name = "BTN_CONF";
            this.BTN_CONF.Size = new System.Drawing.Size(40, 40);
            this.BTN_CONF.TabIndex = 6;
            this.BTN_CONF.UseVisualStyleBackColor = true;
            this.BTN_CONF.Click += new System.EventHandler(this.BTN_CONF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_ADD_CLIENTE;
            this.pictureBox1.Location = new System.Drawing.Point(187, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.CEL_CLIE);
            this.Controls.Add(this.TEL_CLIE);
            this.Controls.Add(this.CPF_CLIE);
            this.Controls.Add(this.BTN_CANC);
            this.Controls.Add(this.BTN_CONF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_CANC;
        private System.Windows.Forms.Button BTN_CONF;
        private System.Windows.Forms.MaskedTextBox CPF_CLIE;
        private System.Windows.Forms.MaskedTextBox TEL_CLIE;
        private System.Windows.Forms.MaskedTextBox CEL_CLIE;
    }
}