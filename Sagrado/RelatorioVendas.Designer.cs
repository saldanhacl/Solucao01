namespace Sagrado
{
    partial class RelatorioVendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_VENDA_FIADO = new System.Windows.Forms.Button();
            this.BTN_VENDA_PRODUTOS = new System.Windows.Forms.Button();
            this.BTN_VENDA_USER = new System.Windows.Forms.Button();
            this.BTN_VENDA_HORAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RELATÓRIO DE VENDAS";
            // 
            // BTN_VENDA_FIADO
            // 
            this.BTN_VENDA_FIADO.Location = new System.Drawing.Point(46, 116);
            this.BTN_VENDA_FIADO.Name = "BTN_VENDA_FIADO";
            this.BTN_VENDA_FIADO.Size = new System.Drawing.Size(204, 23);
            this.BTN_VENDA_FIADO.TabIndex = 1;
            this.BTN_VENDA_FIADO.Text = "Gerar gráfico da vendas fiadas";
            this.BTN_VENDA_FIADO.UseVisualStyleBackColor = true;
            // 
            // BTN_VENDA_PRODUTOS
            // 
            this.BTN_VENDA_PRODUTOS.Location = new System.Drawing.Point(46, 180);
            this.BTN_VENDA_PRODUTOS.Name = "BTN_VENDA_PRODUTOS";
            this.BTN_VENDA_PRODUTOS.Size = new System.Drawing.Size(204, 23);
            this.BTN_VENDA_PRODUTOS.TabIndex = 2;
            this.BTN_VENDA_PRODUTOS.Text = "Gerar gráfico de  produtos vendidos";
            this.BTN_VENDA_PRODUTOS.UseVisualStyleBackColor = true;
            // 
            // BTN_VENDA_USER
            // 
            this.BTN_VENDA_USER.Location = new System.Drawing.Point(347, 116);
            this.BTN_VENDA_USER.Name = "BTN_VENDA_USER";
            this.BTN_VENDA_USER.Size = new System.Drawing.Size(222, 23);
            this.BTN_VENDA_USER.TabIndex = 3;
            this.BTN_VENDA_USER.Text = "Gerar gráfico número vendas usuário";
            this.BTN_VENDA_USER.UseVisualStyleBackColor = true;
            // 
            // BTN_VENDA_HORAS
            // 
            this.BTN_VENDA_HORAS.Location = new System.Drawing.Point(347, 180);
            this.BTN_VENDA_HORAS.Name = "BTN_VENDA_HORAS";
            this.BTN_VENDA_HORAS.Size = new System.Drawing.Size(222, 23);
            this.BTN_VENDA_HORAS.TabIndex = 4;
            this.BTN_VENDA_HORAS.Text = "Gerar gráfico de vendas por horário";
            this.BTN_VENDA_HORAS.UseVisualStyleBackColor = true;
            // 
            // RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_VENDA_HORAS);
            this.Controls.Add(this.BTN_VENDA_USER);
            this.Controls.Add(this.BTN_VENDA_PRODUTOS);
            this.Controls.Add(this.BTN_VENDA_FIADO);
            this.Controls.Add(this.label1);
            this.Name = "RelatorioVendas";
            this.Text = "RelatorioVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_VENDA_FIADO;
        private System.Windows.Forms.Button BTN_VENDA_PRODUTOS;
        private System.Windows.Forms.Button BTN_VENDA_USER;
        private System.Windows.Forms.Button BTN_VENDA_HORAS;
    }
}