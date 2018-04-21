namespace Sagrado
{
    partial class ExcluirCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirCliente));
            this.BTN_CONFIRMAR_CLIENTE = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_CPF_CLIENTE = new System.Windows.Forms.TextBox();
            this.BTN_EXCLUIR_CLIENTE = new System.Windows.Forms.Button();
            this.BTN_CANCELAR_CLIENTE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR_CLIENTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR_CLIENTE)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CONFIRMAR_CLIENTE
            // 
            this.BTN_CONFIRMAR_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK;
            this.BTN_CONFIRMAR_CLIENTE.Location = new System.Drawing.Point(464, 358);
            this.BTN_CONFIRMAR_CLIENTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_CONFIRMAR_CLIENTE.Name = "BTN_CONFIRMAR_CLIENTE";
            this.BTN_CONFIRMAR_CLIENTE.Size = new System.Drawing.Size(51, 50);
            this.BTN_CONFIRMAR_CLIENTE.TabIndex = 55;
            this.BTN_CONFIRMAR_CLIENTE.TabStop = false;
            this.BTN_CONFIRMAR_CLIENTE.Click += new System.EventHandler(this.BTN_CONFIRMAR_CLIENTE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.Location = new System.Drawing.Point(269, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "CPF:";
            // 
            // TXT_CPF_CLIENTE
            // 
            this.TXT_CPF_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.TXT_CPF_CLIENTE.Location = new System.Drawing.Point(320, 295);
            this.TXT_CPF_CLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CPF_CLIENTE.MaxLength = 11;
            this.TXT_CPF_CLIENTE.Name = "TXT_CPF_CLIENTE";
            this.TXT_CPF_CLIENTE.Size = new System.Drawing.Size(195, 24);
            this.TXT_CPF_CLIENTE.TabIndex = 53;
            this.TXT_CPF_CLIENTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_CPF_CLIENTE_KeyPress);
            // 
            // BTN_EXCLUIR_CLIENTE
            // 
            this.BTN_EXCLUIR_CLIENTE.Image = global::Sagrado.Properties.Resources.BTN_EXCLUIR;
            this.BTN_EXCLUIR_CLIENTE.Location = new System.Drawing.Point(320, 141);
            this.BTN_EXCLUIR_CLIENTE.Name = "BTN_EXCLUIR_CLIENTE";
            this.BTN_EXCLUIR_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_EXCLUIR_CLIENTE.TabIndex = 65;
            this.BTN_EXCLUIR_CLIENTE.UseVisualStyleBackColor = true;
            // 
            // BTN_CANCELAR_CLIENTE
            // 
            this.BTN_CANCELAR_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANCELAR_CLIENTE.Location = new System.Drawing.Point(397, 358);
            this.BTN_CANCELAR_CLIENTE.Name = "BTN_CANCELAR_CLIENTE";
            this.BTN_CANCELAR_CLIENTE.Size = new System.Drawing.Size(50, 50);
            this.BTN_CANCELAR_CLIENTE.TabIndex = 123;
            this.BTN_CANCELAR_CLIENTE.TabStop = false;
            this.BTN_CANCELAR_CLIENTE.Click += new System.EventHandler(this.BTN_CANCELAR_CLIENTE_Click);
            // 
            // ExcluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BTN_CANCELAR_CLIENTE);
            this.Controls.Add(this.BTN_EXCLUIR_CLIENTE);
            this.Controls.Add(this.BTN_CONFIRMAR_CLIENTE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_CPF_CLIENTE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcluirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXCLUIR CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CONFIRMAR_CLIENTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CANCELAR_CLIENTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BTN_CONFIRMAR_CLIENTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_CPF_CLIENTE;
        private System.Windows.Forms.Button BTN_EXCLUIR_CLIENTE;
        private System.Windows.Forms.PictureBox BTN_CANCELAR_CLIENTE;
    }
}