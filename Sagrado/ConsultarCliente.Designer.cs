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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_DIVIDA_CLIENTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.BTN_CONFIRMAR = new System.Windows.Forms.PictureBox();
            this.BTN_CANCELAR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botaoConsultar);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOME COMPLETO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TEL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CEL:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(284, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(208, 219);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(213, 264);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(456, 264);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 20);
            this.textBox7.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(171, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "DÍVIDA (R$):";
            // 
            // TXT_DIVIDA_CLIENTE
            // 
            this.TXT_DIVIDA_CLIENTE.BackColor = System.Drawing.Color.White;
            this.TXT_DIVIDA_CLIENTE.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_DIVIDA_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TXT_DIVIDA_CLIENTE.Location = new System.Drawing.Point(334, 312);
            this.TXT_DIVIDA_CLIENTE.Name = "TXT_DIVIDA_CLIENTE";
            this.TXT_DIVIDA_CLIENTE.ReadOnly = true;
            this.TXT_DIVIDA_CLIENTE.Size = new System.Drawing.Size(139, 35);
            this.TXT_DIVIDA_CLIENTE.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(172, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Pagamento da dívida:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(173, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "DIGITE O VALOR (R$) :";
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxPrice.Location = new System.Drawing.Point(334, 399);
            this.boxPrice.MaxLength = 3;
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(185, 23);
            this.boxPrice.TabIndex = 30;
            // 
            // BTN_CONFIRMAR
            // 
            this.BTN_CONFIRMAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK;
            this.BTN_CONFIRMAR.Location = new System.Drawing.Point(678, 413);
            this.BTN_CONFIRMAR.Name = "BTN_CONFIRMAR";
            this.BTN_CONFIRMAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CONFIRMAR.TabIndex = 25;
            this.BTN_CONFIRMAR.TabStop = false;
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(605, 413);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CANCELAR.TabIndex = 24;
            this.BTN_CANCELAR.TabStop = false;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_DIVIDA_CLIENTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_CONFIRMAR);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR CLIENTE";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox BTN_CANCELAR;
        private System.Windows.Forms.PictureBox BTN_CONFIRMAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_DIVIDA_CLIENTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxPrice;
    }
}