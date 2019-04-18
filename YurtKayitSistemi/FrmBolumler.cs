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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }
        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Bolumler(bolumAd) values (@p1)", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                cmd.ExecuteNonQuery();
                con.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Eklendi", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("Delete from Bolumler Where Bolumid=@p1", con.baglanti());
                cmd2.Parameters.AddWithValue("@p1", txtBolumID.Text);
                cmd2.ExecuteNonQuery();
                con.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu, İşlem Başarısız", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumID.Text = id;
            txtBolumAd.Text = bolumad;
        }
        private void pcbBolumDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd3 = new SqlCommand("Update Bolumler Set Bolumad=@p1 where Bolumid=@p2", con.baglanti());
                cmd3.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                cmd3.Parameters.AddWithValue("@p2", txtBolumID.Text);
                cmd3.ExecuteNonQuery();
                con.baglanti().Close();
                MessageBox.Show("Güncelleme Başarıyla Gerçekleşti", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Başarısız, Lütfen Tekrar Deneyiniz", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
