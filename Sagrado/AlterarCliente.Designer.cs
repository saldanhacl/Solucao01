namespace Sagrado
{
    partial class AlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCliente));
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_NOME_CLIENTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_CPF_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.TXT_TEL_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.TXT_CEL_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.BTN_CONF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label8.Location = new System.Drawing.Point(305, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 117;
            this.label8.Text = "CEL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label12.Location = new System.Drawing.Point(71, 237);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 116;
            this.label12.Text = "TEL:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label11.Location = new System.Drawing.Point(52, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 111;
            this.label11.Text = "NOME:";
            // 
            // TXT_NOME_CLIENTE
            // 
            this.TXT_NOME_CLIENTE.BackColor = System.Drawing.Color.White;
            this.TXT_NOME_CLIENTE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_NOME_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_NOME_CLIENTE.Location = new System.Drawing.Point(123, 188);
            this.TXT_NOME_CLIENTE.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXT_NOME_CLIENTE.MaxLength = 45;
            this.TXT_NOME_CLIENTE.Name = "TXT_NOME_CLIENTE";
            this.TXT_NOME_CLIENTE.Size = new System.Drawing.Size(401, 24);
            this.TXT_NOME_CLIENTE.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.Location = new System.Drawing.Point(126, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 109;
            this.label5.Text = "CPF:";
            // 
            // TXT_CPF_CLIENTE
            // 
            this.TXT_CPF_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_CPF_CLIENTE.Location = new System.Drawing.Point(181, 136);
            this.TXT_CPF_CLIENTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CPF_CLIENTE.Mask = "000.000.000-00";
            this.TXT_CPF_CLIENTE.Name = "TXT_CPF_CLIENTE";
            this.TXT_CPF_CLIENTE.Size = new System.Drawing.Size(211, 24);
            this.TXT_CPF_CLIENTE.TabIndex = 1;
            this.TXT_CPF_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_TEL_CLIENTE
            // 
            this.TXT_TEL_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_TEL_CLIENTE.Location = new System.Drawing.Point(123, 231);
            this.TXT_TEL_CLIENTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_TEL_CLIENTE.Mask = "(00) 0000-0000";
            this.TXT_TEL_CLIENTE.Name = "TXT_TEL_CLIENTE";
            this.TXT_TEL_CLIENTE.Size = new System.Drawing.Size(160, 24);
            this.TXT_TEL_CLIENTE.TabIndex = 3;
            this.TXT_TEL_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_CEL_CLIENTE
            // 
            this.TXT_CEL_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_CEL_CLIENTE.Location = new System.Drawing.Point(364, 231);
            this.TXT_CEL_CLIENTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CEL_CLIENTE.Mask = "(00) 00000-0000";
            this.TXT_CEL_CLIENTE.Name = "TXT_CEL_CLIENTE";
            this.TXT_CEL_CLIENTE.Size = new System.Drawing.Size(160, 24);
            this.TXT_CEL_CLIENTE.TabIndex = 4;
            this.TXT_CEL_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EDIT_CLIENTE;
            this.pictureBox1.Location = new System.Drawing.Point(187, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SEARCH2;
            this.BTN_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_SEARCH.Location = new System.Drawing.Point(409, 134);
            this.BTN_SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(30, 30);
            this.BTN_SEARCH.TabIndex = 2;
            this.BTN_SEARCH.UseVisualStyleBackColor = true;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // BTN_CONF
            // 
            this.BTN_CONF.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SAVE;
            this.BTN_CONF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONF.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CONF.Location = new System.Drawing.Point(484, 283);
            this.BTN_CONF.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CONF.Name = "BTN_CONF";
            this.BTN_CONF.Size = new System.Drawing.Size(40, 40);
            this.BTN_CONF.TabIndex = 5;
            this.BTN_CONF.UseVisualStyleBackColor = true;
            this.BTN_CONF.Click += new System.EventHandler(this.BTN_CONF_Click);
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXT_CEL_CLIENTE);
            this.Controls.Add(this.TXT_TEL_CLIENTE);
            this.Controls.Add(this.TXT_CPF_CLIENTE);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.BTN_CONF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_NOME_CLIENTE);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTERAR CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_NOME_CLIENTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_CONF;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.MaskedTextBox TXT_CPF_CLIENTE;
        private System.Windows.Forms.MaskedTextBox TXT_TEL_CLIENTE;
        private System.Windows.Forms.MaskedTextBox TXT_CEL_CLIENTE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}