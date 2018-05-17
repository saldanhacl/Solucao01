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
            this.RB_TIPO = new System.Windows.Forms.RadioButton();
            this.RB_FUNC = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(723, 259);
            this.dg.TabIndex = 5;
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
            this.BTN_BUSCAR.Location = new System.Drawing.Point(498, 210);
            this.BTN_BUSCAR.Name = "BTN_BUSCAR";
            this.BTN_BUSCAR.Size = new System.Drawing.Size(30, 30);
            this.BTN_BUSCAR.TabIndex = 4;
            this.BTN_BUSCAR.UseVisualStyleBackColor = false;
            this.BTN_BUSCAR.Click += new System.EventHandler(this.BTN_BUSCAR_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 215);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // RB_TIPO
            // 
            this.RB_TIPO.AutoSize = true;
            this.RB_TIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.RB_TIPO.Location = new System.Drawing.Point(140, 12);
            this.RB_TIPO.Name = "RB_TIPO";
            this.RB_TIPO.Size = new System.Drawing.Size(157, 21);
            this.RB_TIPO.TabIndex = 2;
            this.RB_TIPO.TabStop = true;
            this.RB_TIPO.Text = "TIPO DE REGISTRO";
            this.RB_TIPO.UseVisualStyleBackColor = true;
            this.RB_TIPO.CheckedChanged += new System.EventHandler(this.RB_TIPO_CheckedChanged);
            // 
            // RB_FUNC
            // 
            this.RB_FUNC.AutoSize = true;
            this.RB_FUNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.RB_FUNC.Location = new System.Drawing.Point(12, 12);
            this.RB_FUNC.Name = "RB_FUNC";
            this.RB_FUNC.Size = new System.Drawing.Size(120, 21);
            this.RB_FUNC.TabIndex = 1;
            this.RB_FUNC.TabStop = true;
            this.RB_FUNC.Text = "FUNCIONÁRIO";
            this.RB_FUNC.UseVisualStyleBackColor = true;
            this.RB_FUNC.CheckedChanged += new System.EventHandler(this.RB_FUNC_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RB_FUNC);
            this.panel1.Controls.Add(this.RB_TIPO);
            this.panel1.Location = new System.Drawing.Point(233, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 45);
            this.panel1.TabIndex = 32;
            // 
            // MovimentacaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTN_BUSCAR);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.IMG_CARTEIRA);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovimentacaoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMENTAÇÃO DE CAIXA";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_CARTEIRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton RB_TIPO;
        private System.Windows.Forms.RadioButton RB_FUNC;
        private System.Windows.Forms.Panel panel1;
    }
}