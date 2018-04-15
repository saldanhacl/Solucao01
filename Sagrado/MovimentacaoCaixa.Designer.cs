namespace Sagrado
{
    partial class MovimentacaoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimentacaoCaixa));
            this.IMG_CARTEIRA = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BTN_DATE = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BNT_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_CARTEIRA
            // 
            this.IMG_CARTEIRA.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SALDO;
            this.IMG_CARTEIRA.Location = new System.Drawing.Point(289, 31);
            this.IMG_CARTEIRA.Name = "IMG_CARTEIRA";
            this.IMG_CARTEIRA.Size = new System.Drawing.Size(200, 100);
            this.IMG_CARTEIRA.TabIndex = 18;
            this.IMG_CARTEIRA.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(543, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "E/OU";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton3.Location = new System.Drawing.Point(379, 213);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 21);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "FUNDO DE CAIXA";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton2.Location = new System.Drawing.Point(304, 213);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 21);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "FIADO";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(223, 213);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VENDA";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BTN_DATE
            // 
            this.BTN_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_DATE.Location = new System.Drawing.Point(222, 253);
            this.BTN_DATE.Name = "BTN_DATE";
            this.BTN_DATE.Size = new System.Drawing.Size(363, 23);
            this.BTN_DATE.TabIndex = 13;
            this.BTN_DATE.ValueChanged += new System.EventHandler(this.BTN_DATE_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 185);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(219, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "SELECIONE O TIPO DE PESQUISA:";
            // 
            // BNT_SEARCH
            // 
            this.BNT_SEARCH.BackColor = System.Drawing.Color.White;
            this.BNT_SEARCH.BackgroundImage = global::Sagrado.Properties.Resources.search;
            this.BNT_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNT_SEARCH.Location = new System.Drawing.Point(535, 297);
            this.BNT_SEARCH.Name = "BNT_SEARCH";
            this.BNT_SEARCH.Size = new System.Drawing.Size(50, 50);
            this.BNT_SEARCH.TabIndex = 10;
            this.BNT_SEARCH.UseVisualStyleBackColor = false;
            this.BNT_SEARCH.Click += new System.EventHandler(this.BNT_SEARCH_Click);
            // 
            // ConsultSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.IMG_CARTEIRA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BTN_DATE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BNT_SEARCH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMENTAÇÃO DE CAIXA";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_CARTEIRA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker BTN_DATE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BNT_SEARCH;
    }
}