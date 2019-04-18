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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Giderler(Elektrik,Su,Dogalgaz,internet,Gida,Personel,Diger) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtElektrik.Text);
                cmd.Parameters.AddWithValue("@p2", txtSu.Text);
                cmd.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                cmd.Parameters.AddWithValue("@p4", txtnet.Text);
                cmd.Parameters.AddWithValue("@p5", txtgida.Text);
                cmd.Parameters.AddWithValue("@p6", txtPersonel.Text);
                cmd.Parameters.AddWithValue("@p7", txtDiger.Text);
                cmd.ExecuteNonQuery();
                con.baglanti().Close();
                MessageBox.Show("Kayıtlar Eklendi.", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Başarısız", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {

        }
    }
}
