namespace Sagrado
{
    partial class GraficoVendasPorUsuario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_CANC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 49);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(783, 403);
            this.chart1.TabIndex = 0;
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDAS POR USUÁRIO";
            // 
            // BTN_CANC
            // 
            this.BTN_CANC.BackgroundImage = global::Sagrado.Properties.Resources.BTN_CANCEL;
            this.BTN_CANC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CANC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANC.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CANC.Location = new System.Drawing.Point(781, 319);
            this.BTN_CANC.Name = "BTN_CANC";
            this.BTN_CANC.Size = new System.Drawing.Size(51, 51);
            this.BTN_CANC.TabIndex = 3;
            this.BTN_CANC.UseVisualStyleBackColor = true;
            this.BTN_CANC.Click += new System.EventHandler(this.BTN_CANC_Click);
            // 
            // GraficoVendasPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 455);
            this.Controls.Add(this.BTN_CANC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "GraficoVendasPorUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Por Usuario";
            this.Load += new System.EventHandler(this.GraficoVenda_Por_Hora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CANC;
    }
}