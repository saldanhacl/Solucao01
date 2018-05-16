namespace Sagrado
{
    partial class AdicionarProdutosComanda
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lista_Comanda = new System.Windows.Forms.ListBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar_comanda = new System.Windows.Forms.Button();
            this.btn_zerar_comanda = new System.Windows.Forms.Button();
            this.Lista_Produtos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lista_Comanda
            // 
            this.Lista_Comanda.FormattingEnabled = true;
            this.Lista_Comanda.Location = new System.Drawing.Point(293, 72);
            this.Lista_Comanda.Name = "Lista_Comanda";
            this.Lista_Comanda.Size = new System.Drawing.Size(259, 186);
            this.Lista_Comanda.TabIndex = 1;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(460, 278);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(136, 20);
            this.txt_total.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total: ";
            // 
            // btn_fechar_comanda
            // 
            this.btn_fechar_comanda.Location = new System.Drawing.Point(486, 315);
            this.btn_fechar_comanda.Name = "btn_fechar_comanda";
            this.btn_fechar_comanda.Size = new System.Drawing.Size(110, 23);
            this.btn_fechar_comanda.TabIndex = 6;
            this.btn_fechar_comanda.Text = "Fechar Comanda";
            this.btn_fechar_comanda.UseVisualStyleBackColor = true;
            this.btn_fechar_comanda.Click += new System.EventHandler(this.btn_fechar_comanda_Click);
            // 
            // btn_zerar_comanda
            // 
            this.btn_zerar_comanda.Location = new System.Drawing.Point(293, 275);
            this.btn_zerar_comanda.Name = "btn_zerar_comanda";
            this.btn_zerar_comanda.Size = new System.Drawing.Size(106, 23);
            this.btn_zerar_comanda.TabIndex = 7;
            this.btn_zerar_comanda.Text = "Zerar Comanda";
            this.btn_zerar_comanda.UseVisualStyleBackColor = true;
            this.btn_zerar_comanda.Click += new System.EventHandler(this.btn_zerar_comanda_Click);
            // 
            // Lista_Produtos
            // 
            this.Lista_Produtos.FormattingEnabled = true;
            this.Lista_Produtos.Location = new System.Drawing.Point(12, 72);
            this.Lista_Produtos.Name = "Lista_Produtos";
            this.Lista_Produtos.Size = new System.Drawing.Size(259, 407);
            this.Lista_Produtos.TabIndex = 8;
            this.Lista_Produtos.DoubleClick += new System.EventHandler(this.Lista_Produtos_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clique duas vezes para adicionar um produto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AdicionarProdutosComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lista_Produtos);
            this.Controls.Add(this.btn_zerar_comanda);
            this.Controls.Add(this.btn_fechar_comanda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.Lista_Comanda);
            this.Name = "AdicionarProdutosComanda";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Comanda;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fechar_comanda;
        private System.Windows.Forms.Button btn_zerar_comanda;
        private System.Windows.Forms.ListBox Lista_Produtos;
        private System.Windows.Forms.Label label2;
    }
}
