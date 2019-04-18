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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bölümleri Comboboxa ekleme
            SqlCommand cmd = new SqlCommand("Select BolumAd From Bolumler", con.baglanti());
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbOgrBolum.Items.Add(oku[0].ToString());
            }
            con.baglanti().Close();

            //Boş odaları Comboboxa ekleme
            SqlCommand cmd2 = new SqlCommand("Select OdaNo From Odalar Where OdaKapasite != OdaAktif", con.baglanti());
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            con.baglanti().Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerini Kaydetme
            try
            {
                SqlCommand cmdKaydet = new SqlCommand("insert into ogrenciler(OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogumTarihi,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", con.baglanti());
                cmdKaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                cmdKaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                cmdKaydet.Parameters.AddWithValue("@p3", mskOgrTC.Text);
                cmdKaydet.Parameters.AddWithValue("@p4", mskOgrTel.Text);
                cmdKaydet.Parameters.AddWithValue("@p5", mskOgrDogum.Text);
                cmdKaydet.Parameters.AddWithValue("@p6", cmbOgrBolum.Text);
                cmdKaydet.Parameters.AddWithValue("@p7", txtOgrMail.Text);
                cmdKaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                cmdKaydet.Parameters.AddWithValue("@p9", txtVeliAd.Text);
                cmdKaydet.Parameters.AddWithValue("@p10", mskVeliTel.Text);
                cmdKaydet.Parameters.AddWithValue("@p11", rchVeliAdres.Text);
                cmdKaydet.ExecuteNonQuery();
                con.baglanti().Close();
                
                //Öğrenci id'yi labele çekme
                SqlCommand cmd3 = new SqlCommand("select Ogrid from Ogrenciler", con.baglanti());
                SqlDataReader oku = cmd3.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                con.baglanti().Close();

                //Öğrenci Borç Alanı Oluşturma
                SqlCommand cmdKaydet2 = new SqlCommand("insert into Borclar(Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", con.baglanti());
                cmdKaydet2.Parameters.AddWithValue("@b1", label12.Text);
                cmdKaydet2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                cmdKaydet2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                cmdKaydet2.ExecuteNonQuery();
                con.baglanti().Close();
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi.", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!! Lütfen Yeniden Deneyiniz.", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Öğrenci Oda Kontenjanı Artırma
            SqlCommand cmdoda = new SqlCommand("Update Odalar set OdaAktif= OdaAktif+1 where OdaNo=@s1 ", con.baglanti());
            cmdoda.Parameters.AddWithValue("@s1", cmbOdaNo.Text);
            cmdoda.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}

