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
            this.label2 = new System.Windows.Forms.Label();
            this.IMG_CARTEIRA = new System.Windows.Forms.PictureBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONÁRIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_BUSCAR = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BTN_BUSCA_CPF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "SELECIONE O TIPO DE PESQUISA";
            // 
            // IMG_CARTEIRA
            // 
            this.IMG_CARTEIRA.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SALDO;
            this.IMG_CARTEIRA.Location = new System.Drawing.Point(289, 25);
            this.IMG_CARTEIRA.Name = "IMG_CARTEIRA";
            this.IMG_CARTEIRA.Size = new System.Drawing.Size(200, 100);
            this.IMG_CARTEIRA.TabIndex = 18;
            this.IMG_CARTEIRA.TabStop = false;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.BackgroundColor = System.Drawing.Color.White;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.VALOR,
            this.FUNCIONÁRIO});
            this.dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dg.Location = new System.Drawing.Point(29, 253);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg.Size = new System.Drawing.Size(723, 259);
            this.dg.TabIndex = 3;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // FUNCIONÁRIO
            // 
            this.FUNCIONÁRIO.HeaderText = "FUNCIONÁRIO";
            this.FUNCIONÁRIO.Name = "FUNCIONÁRIO";
            this.FUNCIONÁRIO.ReadOnly = true;
            // 
            // BTN_BUSCAR
            // 
            this.BTN_BUSCAR.BackColor = System.Drawing.Color.White;
            this.BTN_BUSCAR.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SEARCH2;
            this.BTN_BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BUSCAR.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_BUSCAR.Location = new System.Drawing.Point(543, 168);
            this.BTN_BUSCAR.Name = "BTN_BUSCAR";
            this.BTN_BUSCAR.Size = new System.Drawing.Size(30, 30);
            this.BTN_BUSCAR.TabIndex = 2;
            this.BTN_BUSCAR.UseVisualStyleBackColor = false;
            this.BTN_BUSCAR.Click += new System.EventHandler(this.BTN_BUSCAR_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "VENDA",
            "FIADO",
            "ENTRADA",
            "RETIRADA"});
            this.comboBox1.Location = new System.Drawing.Point(303, 173);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 17;
            this.comboBox2.Location = new System.Drawing.Point(303, 204);
            this.comboBox2.MaxDropDownItems = 4;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 25);
            this.comboBox2.TabIndex = 25;
            // 
            // BTN_BUSCA_CPF
            // 
            this.BTN_BUSCA_CPF.BackColor = System.Drawing.Color.White;
            this.BTN_BUSCA_CPF.BackgroundImage = global::Sagrado.Properties.Resources.BTN_SEARCH2;
            this.BTN_BUSCA_CPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_BUSCA_CPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BUSCA_CPF.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_BUSCA_CPF.Location = new System.Drawing.Point(543, 201);
            this.BTN_BUSCA_CPF.Name = "BTN_BUSCA_CPF";
            this.BTN_BUSCA_CPF.Size = new System.Drawing.Size(30, 30);
            this.BTN_BUSCA_CPF.TabIndex = 26;
            this.BTN_BUSCA_CPF.UseVisualStyleBackColor = false;
            this.BTN_BUSCA_CPF.Click += new System.EventHandler(this.BTN_BUSCA_CPF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "FUNCIONÁRIO: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "REGISTRO:";
            // 
            // MovimentacaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_BUSCA_CPF);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTN_BUSCAR);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.IMG_CARTEIRA);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovimentacaoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMENTAÇÃO DE CAIXA";
            this.Load += new System.EventHandler(this.MovimentacaoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_CARTEIRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button BTN_BUSCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONÁRIO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BTN_BUSCA_CPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}