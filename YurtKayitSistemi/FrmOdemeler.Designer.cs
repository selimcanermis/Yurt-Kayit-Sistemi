namespace YurtKayitSistemi
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdmid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdmAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdmSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdmOdenen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdmBorc = new System.Windows.Forms.TextBox();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet5 = new YurtKayitSistemi.YurtOtomasyonuDataSet5();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borclarTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet5TableAdapters.BorclarTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdmAy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOdmid
            // 
            this.txtOdmid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOdmid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdmid.Location = new System.Drawing.Point(126, 11);
            this.txtOdmid.Name = "txtOdmid";
            this.txtOdmid.Size = new System.Drawing.Size(133, 26);
            this.txtOdmid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOdmAd
            // 
            this.txtOdmAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOdmAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdmAd.Location = new System.Drawing.Point(126, 43);
            this.txtOdmAd.Name = "txtOdmAd";
            this.txtOdmAd.Size = new System.Drawing.Size(133, 26);
            this.txtOdmAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOdmSoyad
            // 
            this.txtOdmSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOdmSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdmSoyad.Location = new System.Drawing.Point(126, 75);
            this.txtOdmSoyad.Name = "txtOdmSoyad";
            this.txtOdmSoyad.Size = new System.Drawing.Size(133, 26);
            this.txtOdmSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(304, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödenen:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOdmOdenen
            // 
            this.txtOdmOdenen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOdmOdenen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdmOdenen.Location = new System.Drawing.Point(407, 11);
            this.txtOdmOdenen.Name = "txtOdmOdenen";
            this.txtOdmOdenen.Size = new System.Drawing.Size(133, 26);
            this.txtOdmOdenen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(304, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kalan Borç:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOdmBorc
            // 
            this.txtOdmBorc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOdmBorc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdmBorc.Location = new System.Drawing.Point(407, 74);
            this.txtOdmBorc.Name = "txtOdmBorc";
            this.txtOdmBorc.Size = new System.Drawing.Size(133, 26);
            this.txtOdmBorc.TabIndex = 6;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOdemeAl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.Location = new System.Drawing.Point(407, 106);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(133, 38);
            this.btnOdemeAl.TabIndex = 7;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.borclarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 294);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ogrid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ogrid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OgrAd";
            this.dataGridViewTextBoxColumn2.HeaderText = "OgrAd";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OgrSoyad";
            this.dataGridViewTextBoxColumn3.HeaderText = "OgrSoyad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OgrKalanBorc";
            this.dataGridViewTextBoxColumn4.HeaderText = "OgrKalanBorc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // borclarBindingSource1
            // 
            this.borclarBindingSource1.DataMember = "Borclar";
            this.borclarBindingSource1.DataSource = this.yurtOtomasyonuDataSet5;
            // 
            // yurtOtomasyonuDataSet5
            // 
            this.yurtOtomasyonuDataSet5.DataSetName = "YurtOtomasyonuDataSet5";
            this.yurtOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            // 
            // borclarTableAdapter1
            // 
            this.borclarTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(304, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ödenen Ay:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOdmAy
            // 
            this.txtOdmAy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOdmAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdmAy.Location = new System.Drawing.Point(407, 42);
            this.txtOdmAy.Name = "txtOdmAy";
            this.txtOdmAy.Size = new System.Drawing.Size(133, 26);
            this.txtOdmAy.TabIndex = 5;
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.txtOdmAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOdmBorc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOdmOdenen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOdmSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdmAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOdmid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdmid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdmAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdmSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdmOdenen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdmBorc;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet2 yurtOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private YurtOtomasyonuDataSet5 yurtOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource borclarBindingSource1;
        private YurtOtomasyonuDataSet5TableAdapters.BorclarTableAdapter borclarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOdmAy;
    }
}