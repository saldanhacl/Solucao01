namespace Sagrado
{
    partial class RegEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegEntrada));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SALDOATUAL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTN_PLUS = new System.Windows.Forms.PictureBox();
            this.BTN_CANCELAR = new System.Windows.Forms.PictureBox();
            this.BTN_CONFIRMAR = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PLUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(113, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 49);
            this.panel1.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton3.Location = new System.Drawing.Point(207, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(137, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "FUNDO DE CAIXA";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton2.Location = new System.Drawing.Point(107, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "FIADO";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton1.Location = new System.Drawing.Point(3, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VENDA";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxPrice.Location = new System.Drawing.Point(275, 328);
            this.boxPrice.MaxLength = 3;
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(185, 23);
            this.boxPrice.TabIndex = 3;
            this.boxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(110, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIGITE O VALOR (R$) :";
            // 
            // TXT_SALDOATUAL
            // 
            this.TXT_SALDOATUAL.BackColor = System.Drawing.Color.White;
            this.TXT_SALDOATUAL.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_SALDOATUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TXT_SALDOATUAL.Location = new System.Drawing.Point(314, 170);
            this.TXT_SALDOATUAL.Name = "TXT_SALDOATUAL";
            this.TXT_SALDOATUAL.ReadOnly = true;
            this.TXT_SALDOATUAL.Size = new System.Drawing.Size(139, 35);
            this.TXT_SALDOATUAL.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(126, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "SALDO (R$):";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // BTN_PLUS
            // 
            this.BTN_PLUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_PLUS.Location = new System.Drawing.Point(116, 277);
            this.BTN_PLUS.Name = "BTN_PLUS";
            this.BTN_PLUS.Size = new System.Drawing.Size(30, 30);
            this.BTN_PLUS.TabIndex = 111;
            this.BTN_PLUS.TabStop = false;
            this.BTN_PLUS.Click += new System.EventHandler(this.BTN_PLUS_Click);
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(340, 374);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CANCELAR.TabIndex = 8;
            this.BTN_CANCELAR.TabStop = false;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // BTN_CONFIRMAR
            // 
            this.BTN_CONFIRMAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK;
            this.BTN_CONFIRMAR.Location = new System.Drawing.Point(410, 373);
            this.BTN_CONFIRMAR.Name = "BTN_CONFIRMAR";
            this.BTN_CONFIRMAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_CONFIRMAR.TabIndex = 7;
            this.BTN_CONFIRMAR.TabStop = false;
            this.BTN_CONFIRMAR.Click += new System.EventHandler(this.BTN_CONFIRMAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_MONEY;
            this.pictureBox1.Location = new System.Drawing.Point(182, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // RegEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BTN_PLUS);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TXT_SALDOATUAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BTN_CONFIRMAR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR ENTRADA";
            this.Load += new System.EventHandler(this.RegEntrada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PLUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BTN_CONFIRMAR;
        private System.Windows.Forms.PictureBox BTN_CANCELAR;
        private System.Windows.Forms.TextBox TXT_SALDOATUAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox BTN_PLUS;
    }
}