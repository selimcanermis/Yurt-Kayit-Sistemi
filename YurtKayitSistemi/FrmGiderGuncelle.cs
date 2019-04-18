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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();

        public string elektrik, su, dogalgaz, net, gida, personel, diger, id;
        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtnet.Text = net;
            txtgida.Text = gida;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Giderler set Elektrik=@p2, Su=@p3, Dogalgaz=@p4, internet=@p5, Gida=@p6, Personel=@p7, Diger=@p8 where Giderid=@p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtid.Text);
                cmd.Parameters.AddWithValue("@p2", txtElektrik.Text);
                cmd.Parameters.AddWithValue("@p3", txtSu.Text);
                cmd.Parameters.AddWithValue("@p4", txtDogalgaz.Text);
                cmd.Parameters.AddWithValue("@p5", txtnet.Text);
                cmd.Parameters.AddWithValue("@p6", txtgida.Text);
                cmd.Parameters.AddWithValue("@p7", txtPersonel.Text);
                cmd.Parameters.AddWithValue("@p8", txtDiger.Text);
                cmd.ExecuteNonQuery();
                con.baglanti().Close();
                MessageBox.Show("Güncelleme Yapıldı", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
