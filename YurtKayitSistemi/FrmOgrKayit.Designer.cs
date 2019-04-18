namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVeliAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskOgrTC = new System.Windows.Forms.MaskedTextBox();
            this.mskOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.mskOgrDogum = new System.Windows.Forms.MaskedTextBox();
            this.cmbOgrBolum = new System.Windows.Forms.ComboBox();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.rchVeliAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(158, 38);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(194, 26);
            this.txtOgrAd.TabIndex = 1;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(158, 70);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(194, 26);
            this.txtOgrSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // txtOgrMail
            // 
            this.txtOgrMail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrMail.Location = new System.Drawing.Point(158, 230);
            this.txtOgrMail.Name = "txtOgrMail";
            this.txtOgrMail.Size = new System.Drawing.Size(194, 26);
            this.txtOgrMail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(99, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "T.C.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // txtVeliAd
            // 
            this.txtVeliAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVeliAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAd.Location = new System.Drawing.Point(158, 294);
            this.txtVeliAd.Name = "txtVeliAd";
            this.txtVeliAd.Size = new System.Drawing.Size(194, 26);
            this.txtVeliAd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Öğrenci Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doğum Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(26, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(41, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Veli Telefon:";
            // 
            // mskOgrTC
            // 
            this.mskOgrTC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskOgrTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOgrTC.Location = new System.Drawing.Point(158, 102);
            this.mskOgrTC.Mask = "00000000000";
            this.mskOgrTC.Name = "mskOgrTC";
            this.mskOgrTC.Size = new System.Drawing.Size(194, 26);
            this.mskOgrTC.TabIndex = 3;
            this.mskOgrTC.ValidatingType = typeof(int);
            // 
            // mskOgrTel
            // 
            this.mskOgrTel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskOgrTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOgrTel.Location = new System.Drawing.Point(158, 134);
            this.mskOgrTel.Mask = "(999) 000-0000";
            this.mskOgrTel.Name = "mskOgrTel";
            this.mskOgrTel.Size = new System.Drawing.Size(194, 26);
            this.mskOgrTel.TabIndex = 4;
            // 
            // mskOgrDogum
            // 
            this.mskOgrDogum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskOgrDogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOgrDogum.Location = new System.Drawing.Point(158, 166);
            this.mskOgrDogum.Mask = "00/00/0000";
            this.mskOgrDogum.Name = "mskOgrDogum";
            this.mskOgrDogum.Size = new System.Drawing.Size(194, 26);
            this.mskOgrDogum.TabIndex = 5;
            this.mskOgrDogum.ValidatingType = typeof(System.DateTime);
            // 
            // cmbOgrBolum
            // 
            this.cmbOgrBolum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbOgrBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrBolum.FormattingEnabled = true;
            this.cmbOgrBolum.Location = new System.Drawing.Point(158, 198);
            this.cmbOgrBolum.Name = "cmbOgrBolum";
            this.cmbOgrBolum.Size = new System.Drawing.Size(194, 26);
            this.cmbOgrBolum.TabIndex = 6;
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(158, 262);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(194, 26);
            this.cmbOdaNo.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(87, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Adres:";
            // 
            // mskVeliTel
            // 
            this.mskVeliTel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskVeliTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskVeliTel.Location = new System.Drawing.Point(158, 326);
            this.mskVeliTel.Mask = "(999) 000-0000";
            this.mskVeliTel.Name = "mskVeliTel";
            this.mskVeliTel.Size = new System.Drawing.Size(194, 26);
            this.mskVeliTel.TabIndex = 10;
            // 
            // rchVeliAdres
            // 
            this.rchVeliAdres.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rchVeliAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchVeliAdres.Location = new System.Drawing.Point(158, 358);
            this.rchVeliAdres.Name = "rchVeliAdres";
            this.rchVeliAdres.Size = new System.Drawing.Size(194, 96);
            this.rchVeliAdres.TabIndex = 11;
            this.rchVeliAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(195, 460);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 33);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchVeliAdres);
            this.Controls.Add(this.mskVeliTel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.cmbOgrBolum);
            this.Controls.Add(this.mskOgrDogum);
            this.Controls.Add(this.mskOgrTel);
            this.Controls.Add(this.mskOgrTC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVeliAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOgrMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVeliAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskOgrTC;
        private System.Windows.Forms.MaskedTextBox mskOgrTel;
        private System.Windows.Forms.MaskedTextBox mskOgrDogum;
        private System.Windows.Forms.ComboBox cmbOgrBolum;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskVeliTel;
        private System.Windows.Forms.RichTextBox rchVeliAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label12;
    }
}

