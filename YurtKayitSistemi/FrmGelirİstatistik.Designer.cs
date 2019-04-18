namespace YurtKayitSistemi
{
    partial class FrmGelirİstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirİstatistik));
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSecilenAy = new System.Windows.Forms.Label();
            this.lblAyKzn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAy
            // 
            this.cmbAy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbAy.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(196, 10);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(155, 26);
            this.cmbAy.TabIndex = 1;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ay Seçin:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, 109);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(498, 303);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // lblSecilenAy
            // 
            this.lblSecilenAy.AutoSize = true;
            this.lblSecilenAy.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenAy.Location = new System.Drawing.Point(80, 56);
            this.lblSecilenAy.Name = "lblSecilenAy";
            this.lblSecilenAy.Size = new System.Drawing.Size(86, 18);
            this.lblSecilenAy.TabIndex = 3;
            this.lblSecilenAy.Text = "Seçilen Ay";
            // 
            // lblAyKzn
            // 
            this.lblAyKzn.AutoSize = true;
            this.lblAyKzn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyKzn.Location = new System.Drawing.Point(193, 56);
            this.lblAyKzn.Name = "lblAyKzn";
            this.lblAyKzn.Size = new System.Drawing.Size(18, 18);
            this.lblAyKzn.TabIndex = 4;
            this.lblAyKzn.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // FrmGelirİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAyKzn);
            this.Controls.Add(this.lblSecilenAy);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirİstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir İstatistikleri";
            this.Load += new System.EventHandler(this.FrmGelirİstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblSecilenAy;
        private System.Windows.Forms.Label lblAyKzn;
        private System.Windows.Forms.Label label2;
    }
}