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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_DIVIDAS_CLIENTES = new System.Windows.Forms.Button();
            this.BTN_VENDA_HORAS = new System.Windows.Forms.Button();
            this.BTN_VENDA_USER = new System.Windows.Forms.Button();
            this.BTN_VENDA_PRODUTOS = new System.Windows.Forms.Button();
            this.BTN_VENDA_FIADO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "VENDA TIPO FIADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "VENDA POR USUÁRIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "PRODUTOS VENDIDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "VENDA POR HORÁRIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "DÍVIDAS DOS CLIENTES";
            // 
            // BTN_DIVIDAS_CLIENTES
            // 
            this.BTN_DIVIDAS_CLIENTES.BackgroundImage = global::Sagrado.Properties.Resources.BTN_DIV;
            this.BTN_DIVIDAS_CLIENTES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_DIVIDAS_CLIENTES.Location = new System.Drawing.Point(287, 292);
            this.BTN_DIVIDAS_CLIENTES.Name = "BTN_DIVIDAS_CLIENTES";
            this.BTN_DIVIDAS_CLIENTES.Size = new System.Drawing.Size(200, 100);
            this.BTN_DIVIDAS_CLIENTES.TabIndex = 66;
            this.BTN_DIVIDAS_CLIENTES.UseVisualStyleBackColor = true;
            this.BTN_DIVIDAS_CLIENTES.Click += new System.EventHandler(this.BTN_DIVIDAS_CLIENTES_Click);
            // 
            // BTN_VENDA_HORAS
            // 
            this.BTN_VENDA_HORAS.BackgroundImage = global::Sagrado.Properties.Resources.BTN_GRAPH_TIME;
            this.BTN_VENDA_HORAS.Location = new System.Drawing.Point(61, 292);
            this.BTN_VENDA_HORAS.Name = "BTN_VENDA_HORAS";
            this.BTN_VENDA_HORAS.Size = new System.Drawing.Size(200, 100);
            this.BTN_VENDA_HORAS.TabIndex = 4;
            this.BTN_VENDA_HORAS.UseVisualStyleBackColor = true;
            this.BTN_VENDA_HORAS.Click += new System.EventHandler(this.BTN_VENDA_HORAS_Click);
            // 
            // BTN_VENDA_USER
            // 
            this.BTN_VENDA_USER.BackgroundImage = global::Sagrado.Properties.Resources.BTN_GRAPH_USER;
            this.BTN_VENDA_USER.Location = new System.Drawing.Point(287, 125);
            this.BTN_VENDA_USER.Name = "BTN_VENDA_USER";
            this.BTN_VENDA_USER.Size = new System.Drawing.Size(200, 100);
            this.BTN_VENDA_USER.TabIndex = 3;
            this.BTN_VENDA_USER.UseVisualStyleBackColor = true;
            this.BTN_VENDA_USER.Click += new System.EventHandler(this.BTN_VENDA_USER_Click);
            // 
            // BTN_VENDA_PRODUTOS
            // 
            this.BTN_VENDA_PRODUTOS.BackgroundImage = global::Sagrado.Properties.Resources.BTN_GRAPH_PROD;
            this.BTN_VENDA_PRODUTOS.Location = new System.Drawing.Point(513, 125);
            this.BTN_VENDA_PRODUTOS.Name = "BTN_VENDA_PRODUTOS";
            this.BTN_VENDA_PRODUTOS.Size = new System.Drawing.Size(200, 100);
            this.BTN_VENDA_PRODUTOS.TabIndex = 2;
            this.BTN_VENDA_PRODUTOS.UseVisualStyleBackColor = true;
            this.BTN_VENDA_PRODUTOS.Click += new System.EventHandler(this.BTN_VENDA_PRODUTOS_Click);
            // 
            // BTN_VENDA_FIADO
            // 
            this.BTN_VENDA_FIADO.BackgroundImage = global::Sagrado.Properties.Resources.BTN_GRAPH_VENDA;
            this.BTN_VENDA_FIADO.Location = new System.Drawing.Point(61, 125);
            this.BTN_VENDA_FIADO.Name = "BTN_VENDA_FIADO";
            this.BTN_VENDA_FIADO.Size = new System.Drawing.Size(200, 100);
            this.BTN_VENDA_FIADO.TabIndex = 1;
            this.BTN_VENDA_FIADO.UseVisualStyleBackColor = true;
            this.BTN_VENDA_FIADO.Click += new System.EventHandler(this.BTN_VENDA_FIADO_Click);
            // 
            // RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_DIVIDAS_CLIENTES);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_VENDA_HORAS);
            this.Controls.Add(this.BTN_VENDA_USER);
            this.Controls.Add(this.BTN_VENDA_PRODUTOS);
            this.Controls.Add(this.BTN_VENDA_FIADO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE VENDAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_VENDA_FIADO;
        private System.Windows.Forms.Button BTN_VENDA_PRODUTOS;
        private System.Windows.Forms.Button BTN_VENDA_USER;
        private System.Windows.Forms.Button BTN_VENDA_HORAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_DIVIDAS_CLIENTES;
    }
}