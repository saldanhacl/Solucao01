namespace Sagrado
{
    partial class TelaDeConsultaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_cliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_DIVIDA_CLIENTE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_CANCELAR = new System.Windows.Forms.PictureBox();
            this.BTN_CONFIRMAR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cliente.Location = new System.Drawing.Point(261, 26);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(57, 20);
            this.label_cliente.TabIndex = 1;
            this.label_cliente.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(98, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "DÍVIDA (R$):";
            // 
            // TXT_DIVIDA_CLIENTE
            // 
            this.TXT_DIVIDA_CLIENTE.BackColor = System.Drawing.Color.White;
            this.TXT_DIVIDA_CLIENTE.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_DIVIDA_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TXT_DIVIDA_CLIENTE.Location = new System.Drawing.Point(265, 117);
            this.TXT_DIVIDA_CLIENTE.Name = "TXT_DIVIDA_CLIENTE";
            this.TXT_DIVIDA_CLIENTE.ReadOnly = true;
            this.TXT_DIVIDA_CLIENTE.Size = new System.Drawing.Size(139, 35);
            this.TXT_DIVIDA_CLIENTE.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(96, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "DIGITE O VALOR (R$) :";
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxPrice.Location = new System.Drawing.Point(265, 241);
            this.boxPrice.MaxLength = 3;
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(185, 23);
            this.boxPrice.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(182, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pagamento da dívida:";
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(323, 313);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CANCELAR.TabIndex = 23;
            this.BTN_CANCELAR.TabStop = false;
            // 
            // BTN_CONFIRMAR
            // 
            this.BTN_CONFIRMAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK;
            this.BTN_CONFIRMAR.Location = new System.Drawing.Point(400, 313);
            this.BTN_CONFIRMAR.Name = "BTN_CONFIRMAR";
            this.BTN_CONFIRMAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CONFIRMAR.TabIndex = 24;
            this.BTN_CONFIRMAR.TabStop = false;
            // 
            // TelaDeConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BTN_CONFIRMAR);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_DIVIDA_CLIENTE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.label1);
            this.Name = "TelaDeConsultaCliente";
            this.Text = "TelaConsultaCliente";
            this.Load += new System.EventHandler(this.TelaDeConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_DIVIDA_CLIENTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BTN_CANCELAR;
        private System.Windows.Forms.PictureBox BTN_CONFIRMAR;
    }
}