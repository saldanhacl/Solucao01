namespace Sagrado
{
    partial class RegRetirada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegRetirada));
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_VALOR_RETIRADA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_SALDOATUAL = new System.Windows.Forms.TextBox();
            this.BTN_CANCELAR = new System.Windows.Forms.PictureBox();
            this.BTN_CONFIRMAR = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.Location = new System.Drawing.Point(121, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "VALOR RETIRADA (R$):";
            // 
            // TXT_VALOR_RETIRADA
            // 
            this.TXT_VALOR_RETIRADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TXT_VALOR_RETIRADA.Location = new System.Drawing.Point(307, 229);
            this.TXT_VALOR_RETIRADA.MaxLength = 10;
            this.TXT_VALOR_RETIRADA.Name = "TXT_VALOR_RETIRADA";
            this.TXT_VALOR_RETIRADA.Size = new System.Drawing.Size(139, 23);
            this.TXT_VALOR_RETIRADA.TabIndex = 1;
            this.TXT_VALOR_RETIRADA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_VALOR_RETIRADA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(119, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "SALDO (R$):";
            // 
            // TXT_SALDOATUAL
            // 
            this.TXT_SALDOATUAL.BackColor = System.Drawing.Color.White;
            this.TXT_SALDOATUAL.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_SALDOATUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TXT_SALDOATUAL.Location = new System.Drawing.Point(307, 176);
            this.TXT_SALDOATUAL.Name = "TXT_SALDOATUAL";
            this.TXT_SALDOATUAL.ReadOnly = true;
            this.TXT_SALDOATUAL.Size = new System.Drawing.Size(139, 35);
            this.TXT_SALDOATUAL.TabIndex = 16;
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(326, 273);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CANCELAR.TabIndex = 13;
            this.BTN_CANCELAR.TabStop = false;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // BTN_CONFIRMAR
            // 
            this.BTN_CONFIRMAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK;
            this.BTN_CONFIRMAR.Location = new System.Drawing.Point(396, 272);
            this.BTN_CONFIRMAR.Name = "BTN_CONFIRMAR";
            this.BTN_CONFIRMAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CONFIRMAR.TabIndex = 12;
            this.BTN_CONFIRMAR.TabStop = false;
            this.BTN_CONFIRMAR.Click += new System.EventHandler(this.BTN_CONFIRMAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_RETIRAR_DINHEIRO2;
            this.pictureBox1.Location = new System.Drawing.Point(182, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RegRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.TXT_SALDOATUAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BTN_CONFIRMAR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_VALOR_RETIRADA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegRetirada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR RETIRADA";
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_VALOR_RETIRADA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BTN_CANCELAR;
        private System.Windows.Forms.PictureBox BTN_CONFIRMAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_SALDOATUAL;
    }
}

