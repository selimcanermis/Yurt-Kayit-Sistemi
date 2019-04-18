namespace YurtKayitSistemi
{
    partial class FrmBolumler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.pcbBolumSil = new System.Windows.Forms.PictureBox();
            this.pcbBolumDüzenle = new System.Windows.Forms.PictureBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblBolumAd = new System.Windows.Forms.Label();
            this.txtBolumID = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet = new YurtKayitSistemi.YurtOtomasyonuDataSet();
            this.bolumlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumDüzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBolumEkle
            // 
            this.pcbBolumEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumEkle.Image")));
            this.pcbBolumEkle.Location = new System.Drawing.Point(25, 90);
            this.pcbBolumEkle.Name = "pcbBolumEkle";
            this.pcbBolumEkle.Size = new System.Drawing.Size(125, 125);
            this.pcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolumEkle.TabIndex = 0;
            this.pcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumEkle, "Bölüm Ekle");
            this.pcbBolumEkle.Click += new System.EventHandler(this.pcbBolumEkle_Click);
            // 
            // pcbBolumSil
            // 
            this.pcbBolumSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumSil.Image")));
            this.pcbBolumSil.Location = new System.Drawing.Point(170, 90);
            this.pcbBolumSil.Name = "pcbBolumSil";
            this.pcbBolumSil.Size = new System.Drawing.Size(125, 125);
            this.pcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolumSil.TabIndex = 1;
            this.pcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumSil, "Bölüm Sil");
            this.pcbBolumSil.Click += new System.EventHandler(this.pcbBolumSil_Click);
            // 
            // pcbBolumDüzenle
            // 
            this.pcbBolumDüzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBolumDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumDüzenle.Image")));
            this.pcbBolumDüzenle.Location = new System.Drawing.Point(315, 90);
            this.pcbBolumDüzenle.Name = "pcbBolumDüzenle";
            this.pcbBolumDüzenle.Size = new System.Drawing.Size(125, 125);
            this.pcbBolumDüzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolumDüzenle.TabIndex = 2;
            this.pcbBolumDüzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumDüzenle, "Bölüm Güncelle");
            this.pcbBolumDüzenle.Click += new System.EventHandler(this.pcbBolumDüzenle_Click);
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolum.Location = new System.Drawing.Point(27, 18);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(92, 18);
            this.lblBolum.TabIndex = 3;
            this.lblBolum.Text = "Bölüm ID:";
            // 
            // lblBolumAd
            // 
            this.lblBolumAd.AutoSize = true;
            this.lblBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumAd.Location = new System.Drawing.Point(24, 50);
            this.lblBolumAd.Name = "lblBolumAd";
            this.lblBolumAd.Size = new System.Drawing.Size(95, 18);
            this.lblBolumAd.TabIndex = 4;
            this.lblBolumAd.Text = "Bölüm Ad:";
            // 
            // txtBolumID
            // 
            this.txtBolumID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBolumID.Enabled = false;
            this.txtBolumID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumID.Location = new System.Drawing.Point(125, 15);
            this.txtBolumID.Name = "txtBolumID";
            this.txtBolumID.Size = new System.Drawing.Size(315, 26);
            this.txtBolumID.TabIndex = 1;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBolumAd.Location = new System.Drawing.Point(125, 47);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(315, 26);
            this.txtBolumAd.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 236);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.txtBolumID);
            this.Controls.Add(this.lblBolumAd);
            this.Controls.Add(this.lblBolum);
            this.Controls.Add(this.pcbBolumDüzenle);
            this.Controls.Add(this.pcbBolumSil);
            this.Controls.Add(this.pcbBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumDüzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBolumEkle;
        private System.Windows.Forms.PictureBox pcbBolumSil;
        private System.Windows.Forms.PictureBox pcbBolumDüzenle;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblBolumAd;
        private System.Windows.Forms.TextBox txtBolumID;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}