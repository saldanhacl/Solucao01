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
            this.LISTA_CLIENTES = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(108, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 28);
            this.panel1.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton3.Location = new System.Drawing.Point(224, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(137, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "FUNDO DE CAIXA";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton2.Location = new System.Drawing.Point(112, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "FIADO";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton1.Location = new System.Drawing.Point(3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VENDA";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.boxPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxPrice.Location = new System.Drawing.Point(280, 341);
            this.boxPrice.MaxLength = 3;
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(193, 24);
            this.boxPrice.TabIndex = 3;
            this.boxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.Location = new System.Drawing.Point(108, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIGITE O VALOR (R$) :";
            // 
            // TXT_SALDOATUAL
            // 
            this.TXT_SALDOATUAL.BackColor = System.Drawing.Color.White;
            this.TXT_SALDOATUAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SALDOATUAL.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_SALDOATUAL.Enabled = false;
            this.TXT_SALDOATUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TXT_SALDOATUAL.ForeColor = System.Drawing.Color.Transparent;
            this.TXT_SALDOATUAL.Location = new System.Drawing.Point(111, 150);
            this.TXT_SALDOATUAL.Name = "TXT_SALDOATUAL";
            this.TXT_SALDOATUAL.ReadOnly = true;
            this.TXT_SALDOATUAL.ShortcutsEnabled = false;
            this.TXT_SALDOATUAL.Size = new System.Drawing.Size(362, 32);
            this.TXT_SALDOATUAL.TabIndex = 18;
            this.TXT_SALDOATUAL.TabStop = false;
            this.TXT_SALDOATUAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_SALDOATUAL.TextChanged += new System.EventHandler(this.TXT_SALDOATUAL_TextChanged);
            // 
            // LISTA_CLIENTES
            // 
            this.LISTA_CLIENTES.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.LISTA_CLIENTES.Enabled = false;
            this.LISTA_CLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.LISTA_CLIENTES.ItemHeight = 17;
            this.LISTA_CLIENTES.Location = new System.Drawing.Point(194, 299);
            this.LISTA_CLIENTES.Name = "LISTA_CLIENTES";
            this.LISTA_CLIENTES.Size = new System.Drawing.Size(279, 25);
            this.LISTA_CLIENTES.TabIndex = 19;
            this.LISTA_CLIENTES.SelectedIndexChanged += new System.EventHandler(this.LISTA_CLIENTES_SelectedIndexChanged);
            this.LISTA_CLIENTES.Click += new System.EventHandler(this.LISTA_CLIENTES_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.Location = new System.Drawing.Point(108, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "CLIENTE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(111, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "ADICIONAR COMANDA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_MONEY;
            this.pictureBox1.Location = new System.Drawing.Point(194, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SAVE;
            this.BTN_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_SAVE.Location = new System.Drawing.Point(433, 383);
            this.BTN_SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(40, 40);
            this.BTN_SAVE.TabIndex = 22;
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // RegEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LISTA_CLIENTES);
            this.Controls.Add(this.TXT_SALDOATUAL);
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
        private System.Windows.Forms.TextBox TXT_SALDOATUAL;
        private System.Windows.Forms.ComboBox LISTA_CLIENTES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_SAVE;
    }
}