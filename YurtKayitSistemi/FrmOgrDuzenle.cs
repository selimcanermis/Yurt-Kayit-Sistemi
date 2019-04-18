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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, TC, tel, dogum, bolum, mail, odano, veliad, velitel, adres;
        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci Silme
            SqlCommand cmdsil = new SqlCommand("delete from Ogrenciler where Ogrid=@d1", con.baglanti());
            cmdsil.Parameters.AddWithValue("@d1", txtOgrid.Text);
            cmdsil.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Kayıt Silinmiştir");

            //Oda Aktif Öğrenci Sayısı Azaltma
            SqlCommand cmdoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@o1", con.baglanti());
            cmdoda.Parameters.AddWithValue("@o1", cmbOdaNo.Text);
            cmdoda.ExecuteNonQuery();
            con.baglanti().Close();
        }
        SqlBaglantim con = new SqlBaglantim();

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Ogrenciler set OgrAd=@p2, OgrSoyad=@p3, OgrTc=@p4, OgrTelefon=@p5, OgrMail=@p6, OgrDogumTarihi=@p7, OgrBolum=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliTelefon=@p11, OgrVeliAdres=@p12 where Ogrid=@p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtOgrid.Text);
                cmd.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                cmd.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                cmd.Parameters.AddWithValue("@p4", mskOgrTC.Text);
                cmd.Parameters.AddWithValue("@p5", mskOgrTel.Text);
                cmd.Parameters.AddWithValue("@p6", txtOgrMail.Text);
                cmd.Parameters.AddWithValue("@p7", mskOgrDogum.Text);
                cmd.Parameters.AddWithValue("@p8", cmbOgrBolum.Text);
                cmd.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                cmd.Parameters.AddWithValue("@p10", txtVeliAd.Text);
                cmd.Parameters.AddWithValue("@p11", mskVeliTel.Text);
                cmd.Parameters.AddWithValue("@p12", rchVeliAdres.Text);
                cmd.ExecuteNonQuery();
                con.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Güncelleme", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrid.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskOgrTC.Text = TC;
            mskOgrTel.Text = tel;
            mskOgrDogum.Text = dogum;
            cmbOgrBolum.Text = bolum;
            txtOgrMail.Text = mail;
            cmbOdaNo.Text = odano;
            txtVeliAd.Text = veliad;
            mskVeliTel.Text = velitel;
            rchVeliAdres.Text = adres;

            //Bölümleri Comboboxa ekleme
            SqlCommand cmd3 = new SqlCommand("Select BolumAd From Bolumler", con.baglanti());
            SqlDataReader oku = cmd3.ExecuteReader();
            while (oku.Read())
            {
                cmbOgrBolum.Items.Add(oku[0].ToString());
            }
            con.baglanti().Close();

            //Boş odaları Comboboxa ekleme
            SqlCommand cmd4 = new SqlCommand("Select OdaNo From Odalar Where OdaKapasite != OdaAktif", con.baglanti());
            SqlDataReader oku2 = cmd4.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            con.baglanti().Close();
        }
    }
}
