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
            this.TXT_SALDOATUAL = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.Location = new System.Drawing.Point(121, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "VALOR RETIRADA (R$):";
            // 
            // TXT_VALOR_RETIRADA
            // 
            this.TXT_VALOR_RETIRADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TXT_VALOR_RETIRADA.Location = new System.Drawing.Point(307, 225);
            this.TXT_VALOR_RETIRADA.MaxLength = 10;
            this.TXT_VALOR_RETIRADA.Name = "TXT_VALOR_RETIRADA";
            this.TXT_VALOR_RETIRADA.Size = new System.Drawing.Size(139, 23);
            this.TXT_VALOR_RETIRADA.TabIndex = 1;
            this.TXT_VALOR_RETIRADA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_VALOR_RETIRADA_KeyPress);
            // 
            // TXT_SALDOATUAL
            // 
            this.TXT_SALDOATUAL.BackColor = System.Drawing.Color.White;
            this.TXT_SALDOATUAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SALDOATUAL.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_SALDOATUAL.Enabled = false;
            this.TXT_SALDOATUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TXT_SALDOATUAL.Location = new System.Drawing.Point(124, 159);
            this.TXT_SALDOATUAL.Name = "TXT_SALDOATUAL";
            this.TXT_SALDOATUAL.ReadOnly = true;
            this.TXT_SALDOATUAL.Size = new System.Drawing.Size(322, 32);
            this.TXT_SALDOATUAL.TabIndex = 16;
            this.TXT_SALDOATUAL.TabStop = false;
            this.TXT_SALDOATUAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_SALDOATUAL.TextChanged += new System.EventHandler(this.TXT_SALDOATUAL_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_RETIRAR_DINHEIRO2;
            this.pictureBox1.Location = new System.Drawing.Point(182, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SAVE;
            this.BTN_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_SAVE.Location = new System.Drawing.Point(406, 275);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(40, 40);
            this.BTN_SAVE.TabIndex = 17;
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // RegRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.TXT_SALDOATUAL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_VALOR_RETIRADA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegRetirada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR RETIRADA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_VALOR_RETIRADA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_SALDOATUAL;
        private System.Windows.Forms.Button BTN_SAVE;
    }
}

