namespace Sagrado
{
    partial class ConsultarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProd));
            this.LISTA_TIPOS = new System.Windows.Forms.ComboBox();
            this.BTN_BUSCAR = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREÇO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMG_CARTEIRA = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_CANC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).BeginInit();
            this.SuspendLayout();
            // 
            // LISTA_TIPOS
            // 
            this.LISTA_TIPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LISTA_TIPOS.FormattingEnabled = true;
            this.LISTA_TIPOS.Items.AddRange(new object[] {
            "ENTRADA",
            "FIADO",
            "RETIRADA",
            "VENDA"});
            this.LISTA_TIPOS.Location = new System.Drawing.Point(256, 192);
            this.LISTA_TIPOS.Name = "LISTA_TIPOS";
            this.LISTA_TIPOS.Size = new System.Drawing.Size(224, 25);
            this.LISTA_TIPOS.Sorted = true;
            this.LISTA_TIPOS.TabIndex = 1;
            // 
            // BTN_BUSCAR
            // 
            this.BTN_BUSCAR.BackColor = System.Drawing.Color.White;
            this.BTN_BUSCAR.BackgroundImage = global::Sagrado.Properties.Resources.search;
            this.BTN_BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BUSCAR.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_BUSCAR.Location = new System.Drawing.Point(497, 187);
            this.BTN_BUSCAR.Name = "BTN_BUSCAR";
            this.BTN_BUSCAR.Size = new System.Drawing.Size(30, 30);
            this.BTN_BUSCAR.TabIndex = 2;
            this.BTN_BUSCAR.UseVisualStyleBackColor = false;
            this.BTN_BUSCAR.Click += new System.EventHandler(this.BTN_BUSCAR_Click);
            // 
            // dg
            // 
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.BackgroundColor = System.Drawing.Color.White;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.NOME,
            this.QUANTIDADE,
            this.PREÇO});
            this.dg.Location = new System.Drawing.Point(29, 253);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg.Size = new System.Drawing.Size(723, 197);
            this.dg.TabIndex = 31;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // PREÇO
            // 
            this.PREÇO.HeaderText = "PREÇO";
            this.PREÇO.Name = "PREÇO";
            // 
            // IMG_CARTEIRA
            // 
            this.IMG_CARTEIRA.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CONSULTAR_PRODUTO;
            this.IMG_CARTEIRA.Location = new System.Drawing.Point(289, 40);
            this.IMG_CARTEIRA.Name = "IMG_CARTEIRA";
            this.IMG_CARTEIRA.Size = new System.Drawing.Size(200, 100);
            this.IMG_CARTEIRA.TabIndex = 30;
            this.IMG_CARTEIRA.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "SELECIONE O TIPO DE PRODUTO:";
            // 
            // BTN_CANC
            // 
            this.BTN_CANC.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CANC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANC.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CANC.Location = new System.Drawing.Point(701, 468);
            this.BTN_CANC.Name = "BTN_CANC";
            this.BTN_CANC.Size = new System.Drawing.Size(51, 51);
            this.BTN_CANC.TabIndex = 3;
            this.BTN_CANC.UseVisualStyleBackColor = true;
            this.BTN_CANC.Click += new System.EventHandler(this.BTN_CANC_Click);
            // 
            // ConsultarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BTN_CANC);
            this.Controls.Add(this.LISTA_TIPOS);
            this.Controls.Add(this.BTN_BUSCAR);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.IMG_CARTEIRA);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ConsultarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR PRODUTO";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LISTA_TIPOS;
        private System.Windows.Forms.Button BTN_BUSCAR;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.PictureBox IMG_CARTEIRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREÇO;
        private System.Windows.Forms.Button BTN_CANC;
    }
}