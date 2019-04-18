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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Admin where YoneticiAd=@p1 and YoneticiSifre=@p2", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre girdiniz", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAd.Clear();
                txtSifre.Clear();
                txtKullaniciAd.Focus();
            }
            con.baglanti().Close();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
