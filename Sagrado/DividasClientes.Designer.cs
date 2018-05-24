namespace Sagrado
{
    partial class DividasClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DividasClientes));
            this.gridDividaClientes = new System.Windows.Forms.DataGridView();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXT_TOTAL_CAIXA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_TOTAL_DIVIDA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IMG_CARTEIRA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDividaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDividaClientes
            // 
            this.gridDividaClientes.AllowUserToAddRows = false;
            this.gridDividaClientes.AllowUserToDeleteRows = false;
            this.gridDividaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDividaClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDividaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDividaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDividaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLIENTE,
            this.VALOR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDividaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDividaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.gridDividaClientes.Location = new System.Drawing.Point(31, 154);
            this.gridDividaClientes.MultiSelect = false;
            this.gridDividaClientes.Name = "gridDividaClientes";
            this.gridDividaClientes.ReadOnly = true;
            this.gridDividaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridDividaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDividaClientes.Size = new System.Drawing.Size(723, 247);
            this.gridDividaClientes.TabIndex = 6;
            // 
            // CLIENTE
            // 
            this.CLIENTE.FillWeight = 80F;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.FillWeight = 20F;
            this.VALOR.HeaderText = "VALOR (R$)";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // TXT_TOTAL_CAIXA
            // 
            this.TXT_TOTAL_CAIXA.BackColor = System.Drawing.Color.White;
            this.TXT_TOTAL_CAIXA.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_TOTAL_CAIXA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TXT_TOTAL_CAIXA.ForeColor = System.Drawing.Color.Green;
            this.TXT_TOTAL_CAIXA.Location = new System.Drawing.Point(232, 420);
            this.TXT_TOTAL_CAIXA.Name = "TXT_TOTAL_CAIXA";
            this.TXT_TOTAL_CAIXA.ReadOnly = true;
            this.TXT_TOTAL_CAIXA.Size = new System.Drawing.Size(135, 35);
            this.TXT_TOTAL_CAIXA.TabIndex = 20;
            this.TXT_TOTAL_CAIXA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_TOTAL_CAIXA.TextChanged += new System.EventHandler(this.TXT_TOTAL_CAIXA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "TOTAL EM CAIXA (R$):";
            // 
            // TXT_TOTAL_DIVIDA
            // 
            this.TXT_TOTAL_DIVIDA.BackColor = System.Drawing.Color.White;
            this.TXT_TOTAL_DIVIDA.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXT_TOTAL_DIVIDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TXT_TOTAL_DIVIDA.ForeColor = System.Drawing.Color.Red;
            this.TXT_TOTAL_DIVIDA.Location = new System.Drawing.Point(619, 420);
            this.TXT_TOTAL_DIVIDA.Name = "TXT_TOTAL_DIVIDA";
            this.TXT_TOTAL_DIVIDA.ReadOnly = true;
            this.TXT_TOTAL_DIVIDA.Size = new System.Drawing.Size(135, 35);
            this.TXT_TOTAL_DIVIDA.TabIndex = 22;
            this.TXT_TOTAL_DIVIDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_TOTAL_DIVIDA.TextChanged += new System.EventHandler(this.TXT_TOTAL_DIVIDA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(392, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "TOTAL A RECEBER (R$):";
            // 
            // IMG_CARTEIRA
            // 
            this.IMG_CARTEIRA.BackColor = System.Drawing.Color.White;
            this.IMG_CARTEIRA.BackgroundImage = global::Sagrado.Properties.Resources.BTN_DIV;
            this.IMG_CARTEIRA.Location = new System.Drawing.Point(291, 35);
            this.IMG_CARTEIRA.Name = "IMG_CARTEIRA";
            this.IMG_CARTEIRA.Size = new System.Drawing.Size(200, 100);
            this.IMG_CARTEIRA.TabIndex = 31;
            this.IMG_CARTEIRA.TabStop = false;
            // 
            // DividasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.IMG_CARTEIRA);
            this.Controls.Add(this.TXT_TOTAL_DIVIDA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_TOTAL_CAIXA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridDividaClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DividasClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIVIDAS CLIENTES";
            this.Load += new System.EventHandler(this.DividasClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDividaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDividaClientes;
        private System.Windows.Forms.TextBox TXT_TOTAL_CAIXA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_TOTAL_DIVIDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.PictureBox IMG_CARTEIRA;
    }
}