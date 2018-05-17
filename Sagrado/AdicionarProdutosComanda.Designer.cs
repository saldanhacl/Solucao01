﻿namespace Sagrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProdutosComanda));
            this.LISTA = new System.Windows.Forms.ListBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PRODUTOS = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_zerar_comanda = new System.Windows.Forms.Button();
            this.btn_fechar_comanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LISTA
            // 
            this.LISTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LISTA.FormattingEnabled = true;
            this.LISTA.ItemHeight = 16;
            this.LISTA.Location = new System.Drawing.Point(372, 168);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(253, 180);
            this.LISTA.TabIndex = 2;
            // 
            // txt_total
            // 
            this.txt_total.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(472, 375);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(153, 31);
            this.txt_total.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(367, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL:";
            // 
            // PRODUTOS
            // 
            this.PRODUTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PRODUTOS.FormattingEnabled = true;
            this.PRODUTOS.ItemHeight = 16;
            this.PRODUTOS.Location = new System.Drawing.Point(56, 49);
            this.PRODUTOS.Name = "PRODUTOS";
            this.PRODUTOS.Size = new System.Drawing.Size(253, 436);
            this.PRODUTOS.Sorted = true;
            this.PRODUTOS.TabIndex = 1;
            this.PRODUTOS.DoubleClick += new System.EventHandler(this.Lista_Produtos_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.label2.Location = new System.Drawing.Point(53, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DUPLO CLIQUE PARA ADICIONAR UM PRODUTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sagrado.Properties.Resources.BTN_COMANDA;
            this.pictureBox1.Location = new System.Drawing.Point(391, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_zerar_comanda
            // 
            this.btn_zerar_comanda.BackColor = System.Drawing.Color.Transparent;
            this.btn_zerar_comanda.BackgroundImage = global::Sagrado.Properties.Resources.BTN_MINUS;
            this.btn_zerar_comanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_zerar_comanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zerar_comanda.ForeColor = System.Drawing.Color.Transparent;
            this.btn_zerar_comanda.Location = new System.Drawing.Point(316, 236);
            this.btn_zerar_comanda.Name = "btn_zerar_comanda";
            this.btn_zerar_comanda.Size = new System.Drawing.Size(50, 50);
            this.btn_zerar_comanda.TabIndex = 7;
            this.btn_zerar_comanda.UseVisualStyleBackColor = false;
            this.btn_zerar_comanda.Click += new System.EventHandler(this.btn_zerar_comanda_Click);
            // 
            // btn_fechar_comanda
            // 
            this.btn_fechar_comanda.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar_comanda.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK2;
            this.btn_fechar_comanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fechar_comanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_comanda.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fechar_comanda.Location = new System.Drawing.Point(575, 435);
            this.btn_fechar_comanda.Name = "btn_fechar_comanda";
            this.btn_fechar_comanda.Size = new System.Drawing.Size(50, 50);
            this.btn_fechar_comanda.TabIndex = 6;
            this.btn_fechar_comanda.UseVisualStyleBackColor = false;
            this.btn_fechar_comanda.Click += new System.EventHandler(this.btn_fechar_comanda_Click);
            // 
            // AdicionarProdutosComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PRODUTOS);
            this.Controls.Add(this.btn_zerar_comanda);
            this.Controls.Add(this.btn_fechar_comanda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.LISTA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarProdutosComanda";
            this.Text = "COMANDA";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LISTA;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fechar_comanda;
        private System.Windows.Forms.Button btn_zerar_comanda;
        private System.Windows.Forms.ListBox PRODUTOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
