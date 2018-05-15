namespace Sagrado
{
    partial class AlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCliente));
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_NOME_CLIENTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_EDIT_CLIENTE = new System.Windows.Forms.Button();
            this.BTN_CANC = new System.Windows.Forms.Button();
            this.BTN_CONF = new System.Windows.Forms.Button();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.TXT_CPF_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.TXT_TEL_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.TXT_CEL_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label8.Location = new System.Drawing.Point(461, 328);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 117;
            this.label8.Text = "CEL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label12.Location = new System.Drawing.Point(157, 328);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 116;
            this.label12.Text = "TEL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label11.Location = new System.Drawing.Point(48, 283);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 18);
            this.label11.TabIndex = 111;
            this.label11.Text = "NOME COMPLETO:";
            // 
            // TXT_NOME_CLIENTE
            // 
            this.TXT_NOME_CLIENTE.BackColor = System.Drawing.Color.White;
            this.TXT_NOME_CLIENTE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_NOME_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TXT_NOME_CLIENTE.Location = new System.Drawing.Point(209, 276);
            this.TXT_NOME_CLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NOME_CLIENTE.MaxLength = 45;
            this.TXT_NOME_CLIENTE.Name = "TXT_NOME_CLIENTE";
            this.TXT_NOME_CLIENTE.Size = new System.Drawing.Size(527, 23);
            this.TXT_NOME_CLIENTE.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.Location = new System.Drawing.Point(246, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 109;
            this.label5.Text = "CPF:";
            // 
            // BTN_EDIT_CLIENTE
            // 
            this.BTN_EDIT_CLIENTE.BackgroundImage = global::Sagrado.Properties.Resources.BTN_EDIT_CLIENTE;
            this.BTN_EDIT_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_EDIT_CLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT_CLIENTE.Location = new System.Drawing.Point(300, 97);
            this.BTN_EDIT_CLIENTE.Name = "BTN_EDIT_CLIENTE";
            this.BTN_EDIT_CLIENTE.Size = new System.Drawing.Size(200, 100);
            this.BTN_EDIT_CLIENTE.TabIndex = 124;
            this.BTN_EDIT_CLIENTE.UseVisualStyleBackColor = true;
            // 
            // BTN_CANC
            // 
            this.BTN_CANC.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CANC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANC.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CANC.Location = new System.Drawing.Point(612, 405);
            this.BTN_CANC.Name = "BTN_CANC";
            this.BTN_CANC.Size = new System.Drawing.Size(51, 51);
            this.BTN_CANC.TabIndex = 6;
            this.BTN_CANC.UseVisualStyleBackColor = true;
            this.BTN_CANC.Click += new System.EventHandler(this.BTN_CANC_Click);
            // 
            // BTN_CONF
            // 
            this.BTN_CONF.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CHECK;
            this.BTN_CONF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONF.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CONF.Location = new System.Drawing.Point(685, 405);
            this.BTN_CONF.Name = "BTN_CONF";
            this.BTN_CONF.Size = new System.Drawing.Size(51, 51);
            this.BTN_CONF.TabIndex = 7;
            this.BTN_CONF.UseVisualStyleBackColor = true;
            this.BTN_CONF.Click += new System.EventHandler(this.BTN_CONF_Click);
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackgroundImage = global::Sagrado.Properties.Resources.search;
            this.BTN_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_SEARCH.Location = new System.Drawing.Point(472, 228);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(30, 30);
            this.BTN_SEARCH.TabIndex = 2;
            this.BTN_SEARCH.UseVisualStyleBackColor = true;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // TXT_CPF_CLIENTE
            // 
            this.TXT_CPF_CLIENTE.Location = new System.Drawing.Point(300, 234);
            this.TXT_CPF_CLIENTE.Mask = "000.000.000-00";
            this.TXT_CPF_CLIENTE.Name = "TXT_CPF_CLIENTE";
            this.TXT_CPF_CLIENTE.Size = new System.Drawing.Size(139, 20);
            this.TXT_CPF_CLIENTE.TabIndex = 125;
            // 
            // TXT_TEL_CLIENTE
            // 
            this.TXT_TEL_CLIENTE.Location = new System.Drawing.Point(209, 325);
            this.TXT_TEL_CLIENTE.Mask = "(31) 0000-0000";
            this.TXT_TEL_CLIENTE.Name = "TXT_TEL_CLIENTE";
            this.TXT_TEL_CLIENTE.Size = new System.Drawing.Size(177, 20);
            this.TXT_TEL_CLIENTE.TabIndex = 126;
            // 
            // TXT_CEL_CLIENTE
            // 
            this.TXT_CEL_CLIENTE.Location = new System.Drawing.Point(509, 328);
            this.TXT_CEL_CLIENTE.Mask = "(31) 00000-0000";
            this.TXT_CEL_CLIENTE.Name = "TXT_CEL_CLIENTE";
            this.TXT_CEL_CLIENTE.Size = new System.Drawing.Size(173, 20);
            this.TXT_CEL_CLIENTE.TabIndex = 127;
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TXT_CEL_CLIENTE);
            this.Controls.Add(this.TXT_TEL_CLIENTE);
            this.Controls.Add(this.TXT_CPF_CLIENTE);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.BTN_CANC);
            this.Controls.Add(this.BTN_CONF);
            this.Controls.Add(this.BTN_EDIT_CLIENTE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_NOME_CLIENTE);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTERAR CLIENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_NOME_CLIENTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_EDIT_CLIENTE;
        private System.Windows.Forms.Button BTN_CANC;
        private System.Windows.Forms.Button BTN_CONF;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.MaskedTextBox TXT_CPF_CLIENTE;
        private System.Windows.Forms.MaskedTextBox TXT_TEL_CLIENTE;
        private System.Windows.Forms.MaskedTextBox TXT_CEL_CLIENTE;
    }
}