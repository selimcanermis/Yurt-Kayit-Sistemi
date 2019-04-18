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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();
        private void label1_Click(object sender, EventArgs e){}
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet5.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtOtomasyonuDataSet5.Borclar);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtOdmAd.Text = ad;
            txtOdmSoyad.Text = soyad;
            txtOdmBorc.Text = kalan;
            txtOdmid.Text = id;
        }
        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(txtOdmOdenen.Text);
            kalan = Convert.ToInt16(txtOdmBorc.Text);
            yeniborc = kalan - odenen;
            txtOdmBorc.Text = yeniborc.ToString();

            //Kalan borcu veritabanında güncelleme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", con.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOdmid.Text);
            komut.Parameters.AddWithValue("@p1", txtOdmBorc.Text);
            komut.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Borç ödendi.", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.borclarTableAdapter1.Fill(this.yurtOtomasyonuDataSet5.Borclar);

            //Kasa Tablosuna Ekleme Yapma
            SqlCommand cmd2 = new SqlCommand("insert into Kasa(OdemeAy,OdemeMiktar) values (@m1,@m2)", con.baglanti());
            cmd2.Parameters.AddWithValue("@m1", txtOdmAy.Text);
            cmd2.Parameters.AddWithValue("@m2", txtOdmOdenen.Text);
            cmd2.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
} 
