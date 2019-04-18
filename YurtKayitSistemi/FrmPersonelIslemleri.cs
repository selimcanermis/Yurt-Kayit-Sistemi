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
    public partial class FrmPersonelIslemleri : Form
    {
        public FrmPersonelIslemleri()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();
        private void FrmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet9.Personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personeller);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Personeller(PersonelAdSoyad, PersonelDepartman) values (@b1,@b2)", con.baglanti());
            cmd.Parameters.AddWithValue("@b1", txtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@b2", txtGorev.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Personel Kaydedilmiştir", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personeller);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtPersonelAd.Text = ad;
            txtGorev.Text = gorev;
            txtPersonelid.Text = id;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Personeller where Personelid=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtPersonelid.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Personel Silinmiştir", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personeller);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Personeller set PersonelAdSoyad=@k1, PersonelDepartman=@k2 where Personelid=@k3", con.baglanti());
            cmd.Parameters.AddWithValue("@k1", txtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@k2", txtGorev.Text);
            cmd.Parameters.AddWithValue("@k3", txtPersonelid.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Personel Güncellenmiştir", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personeller);
        }
    }
}
