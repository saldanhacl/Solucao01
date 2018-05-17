namespace Sagrado
{
    partial class ConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_DIVIDA_CLIENTE = new System.Windows.Forms.TextBox();
            this.text_Willer = new System.Windows.Forms.TextBox();
            this.BTN_CONF = new System.Windows.Forms.Button();
            this.IMG_CONSULT_CLIENTE = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_CPF_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.TXT_TEL_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.TXT_CEL_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CONSULT_CLIENTE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.Location = new System.Drawing.Point(138, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label3.Location = new System.Drawing.Point(64, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label6.Location = new System.Drawing.Point(79, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "TEL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label7.Location = new System.Drawing.Point(317, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "CEL:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.textBox2.Location = new System.Drawing.Point(128, 215);
            this.textBox2.MaxLength = 45;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(401, 24);
            this.textBox2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label8.Location = new System.Drawing.Point(288, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "PAGAR (R$):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label9.Location = new System.Drawing.Point(27, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "DÍVIDA (R$):";
            // 
            // TXT_DIVIDA_CLIENTE
            // 
            this.TXT_DIVIDA_CLIENTE.BackColor = System.Drawing.Color.White;
            this.TXT_DIVIDA_CLIENTE.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_DIVIDA_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.TXT_DIVIDA_CLIENTE.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TXT_DIVIDA_CLIENTE.Location = new System.Drawing.Point(128, 298);
            this.TXT_DIVIDA_CLIENTE.Name = "TXT_DIVIDA_CLIENTE";
            this.TXT_DIVIDA_CLIENTE.ReadOnly = true;
            this.TXT_DIVIDA_CLIENTE.Size = new System.Drawing.Size(138, 24);
            this.TXT_DIVIDA_CLIENTE.TabIndex = 7;
            this.TXT_DIVIDA_CLIENTE.TextChanged += new System.EventHandler(this.TXT_DIVIDA_CLIENTE_TextChanged);
            // 
            // text_Willer
            // 
            this.text_Willer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.text_Willer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_Willer.Location = new System.Drawing.Point(390, 298);
            this.text_Willer.MaxLength = 3;
            this.text_Willer.Name = "text_Willer";
            this.text_Willer.Size = new System.Drawing.Size(139, 24);
            this.text_Willer.TabIndex = 8;
            this.text_Willer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Willer_KeyPressed);
            // 
            // BTN_CONF
            // 
            this.BTN_CONF.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SAVE;
            this.BTN_CONF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONF.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CONF.Location = new System.Drawing.Point(489, 333);
            this.BTN_CONF.Name = "BTN_CONF";
            this.BTN_CONF.Size = new System.Drawing.Size(40, 40);
            this.BTN_CONF.TabIndex = 10;
            this.BTN_CONF.UseVisualStyleBackColor = true;
            this.BTN_CONF.Click += new System.EventHandler(this.BTN_CONF_Click);
            // 
            // IMG_CONSULT_CLIENTE
            // 
            this.IMG_CONSULT_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CONSULTAR_CLIENTE;
            this.IMG_CONSULT_CLIENTE.Location = new System.Drawing.Point(193, 64);
            this.IMG_CONSULT_CLIENTE.Name = "IMG_CONSULT_CLIENTE";
            this.IMG_CONSULT_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.IMG_CONSULT_CLIENTE.TabIndex = 49;
            this.IMG_CONSULT_CLIENTE.TabStop = false;
            this.IMG_CONSULT_CLIENTE.Click += new System.EventHandler(this.IMG_CONSULT_CLIENTE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SEARCH2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(411, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.botaoConsultar);
            // 
            // TXT_CPF_CLIENTE
            // 
            this.TXT_CPF_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_CPF_CLIENTE.Location = new System.Drawing.Point(193, 171);
            this.TXT_CPF_CLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CPF_CLIENTE.Mask = "000.000.000-00";
            this.TXT_CPF_CLIENTE.Name = "TXT_CPF_CLIENTE";
            this.TXT_CPF_CLIENTE.Size = new System.Drawing.Size(211, 24);
            this.TXT_CPF_CLIENTE.TabIndex = 50;
            this.TXT_CPF_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_TEL_CLIENTE
            // 
            this.TXT_TEL_CLIENTE.Enabled = false;
            this.TXT_TEL_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_TEL_CLIENTE.Location = new System.Drawing.Point(128, 258);
            this.TXT_TEL_CLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_TEL_CLIENTE.Mask = "(00) 0000-0000";
            this.TXT_TEL_CLIENTE.Name = "TXT_TEL_CLIENTE";
            this.TXT_TEL_CLIENTE.Size = new System.Drawing.Size(160, 24);
            this.TXT_TEL_CLIENTE.TabIndex = 51;
            this.TXT_TEL_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_CEL_CLIENTE
            // 
            this.TXT_CEL_CLIENTE.Enabled = false;
            this.TXT_CEL_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_CEL_CLIENTE.Location = new System.Drawing.Point(365, 258);
            this.TXT_CEL_CLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CEL_CLIENTE.Mask = "(00) 00000-0000";
            this.TXT_CEL_CLIENTE.Name = "TXT_CEL_CLIENTE";
            this.TXT_CEL_CLIENTE.Size = new System.Drawing.Size(160, 24);
            this.TXT_CEL_CLIENTE.TabIndex = 52;
            this.TXT_CEL_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.TXT_CEL_CLIENTE);
            this.Controls.Add(this.TXT_TEL_CLIENTE);
            this.Controls.Add(this.TXT_CPF_CLIENTE);
            this.Controls.Add(this.BTN_CONF);
            this.Controls.Add(this.text_Willer);
            this.Controls.Add(this.TXT_DIVIDA_CLIENTE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IMG_CONSULT_CLIENTE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR CLIENTE";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CONSULT_CLIENTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox IMG_CONSULT_CLIENTE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_DIVIDA_CLIENTE;
        private System.Windows.Forms.TextBox text_Willer;
        private System.Windows.Forms.Button BTN_CONF;
        private System.Windows.Forms.MaskedTextBox TXT_CPF_CLIENTE;
        private System.Windows.Forms.MaskedTextBox TXT_TEL_CLIENTE;
        private System.Windows.Forms.MaskedTextBox TXT_CEL_CLIENTE;
    }
}