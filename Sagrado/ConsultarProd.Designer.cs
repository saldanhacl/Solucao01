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
            this.dg = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREÇO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.EXCLUIR = new System.Windows.Forms.Button();
            this.BTN_CONF = new System.Windows.Forms.Button();
            this.BTN_BUSCAR = new System.Windows.Forms.Button();
            this.IMG_CARTEIRA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).BeginInit();
            this.SuspendLayout();
            // 
            // LISTA_TIPOS
            // 
            this.LISTA_TIPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LISTA_TIPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LISTA_TIPOS.FormattingEnabled = true;
            this.LISTA_TIPOS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.BackgroundColor = System.Drawing.Color.White;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.TIPO,
            this.NOME,
            this.PREÇO});
            this.dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dg.Location = new System.Drawing.Point(29, 251);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(723, 197);
            this.dg.TabIndex = 31;
            this.dg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellEndEdit);
            // 
            // N
            // 
            this.N.FillWeight = 10F;
            this.N.HeaderText = "N°";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.FillWeight = 25F;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            // 
            // NOME
            // 
            this.NOME.FillWeight = 40F;
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // PREÇO
            // 
            this.PREÇO.FillWeight = 15F;
            this.PREÇO.HeaderText = "PREÇO";
            this.PREÇO.Name = "PREÇO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "SELECIONE O TIPO DO PRODUTO:";
            // 
            // EXCLUIR
            // 
            this.EXCLUIR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EX_PROD;
            this.EXCLUIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EXCLUIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXCLUIR.ForeColor = System.Drawing.Color.Transparent;
            this.EXCLUIR.Location = new System.Drawing.Point(644, 473);
            this.EXCLUIR.Name = "EXCLUIR";
            this.EXCLUIR.Size = new System.Drawing.Size(51, 51);
            this.EXCLUIR.TabIndex = 36;
            this.EXCLUIR.UseVisualStyleBackColor = true;
            this.EXCLUIR.Click += new System.EventHandler(this.EXCLUIR_Click);
            // 
            // BTN_CONF
            // 
            this.BTN_CONF.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EDIT;
            this.BTN_CONF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONF.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CONF.Location = new System.Drawing.Point(701, 473);
            this.BTN_CONF.Name = "BTN_CONF";
            this.BTN_CONF.Size = new System.Drawing.Size(51, 51);
            this.BTN_CONF.TabIndex = 33;
            this.BTN_CONF.UseVisualStyleBackColor = true;
            this.BTN_CONF.Click += new System.EventHandler(this.BTN_CONF_Click);
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
            // IMG_CARTEIRA
            // 
            this.IMG_CARTEIRA.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CONSULTAR_PRODUTO;
            this.IMG_CARTEIRA.Location = new System.Drawing.Point(289, 40);
            this.IMG_CARTEIRA.Name = "IMG_CARTEIRA";
            this.IMG_CARTEIRA.Size = new System.Drawing.Size(200, 100);
            this.IMG_CARTEIRA.TabIndex = 30;
            this.IMG_CARTEIRA.TabStop = false;
            // 
            // ConsultarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.EXCLUIR);
            this.Controls.Add(this.BTN_CONF);
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
        private System.Windows.Forms.Button BTN_CONF;
        private System.Windows.Forms.Button EXCLUIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREÇO;
    }
}