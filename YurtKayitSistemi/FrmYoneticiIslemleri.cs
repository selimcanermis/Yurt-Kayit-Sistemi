using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmYoneticiIslemleri : Form
    {
        public FrmYoneticiIslemleri()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();
        private void FrmYoneticiIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet8.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Admin(YoneticiAd, YoneticiSifre) values (@b1,@b2)", con.baglanti());
            cmd.Parameters.AddWithValue("@b1", txtKullaniciAd.Text);
            cmd.Parameters.AddWithValue("@b2", txtSifre.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Yönetici Kaydedilmiştir", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtKullaniciAd.Text = ad;
            txtSifre.Text = sifre;
            txtYoneticiid.Text = id;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Admin where Yoneticiid=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtYoneticiid.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Yönetici Silinmiştir", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Admin set YoneticiAd=@k1, YoneticiSifre=@k2 where Yoneticiid=@k3", con.baglanti());
            cmd.Parameters.AddWithValue("@k1", txtKullaniciAd.Text);
            cmd.Parameters.AddWithValue("@k2", txtSifre.Text);
            cmd.Parameters.AddWithValue("@k3", txtYoneticiid.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Yönetici Güncellenmiştir", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
        }
    }
}
