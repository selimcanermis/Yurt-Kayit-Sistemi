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
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim con = new SqlBaglantim();
        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //Tekrarsız Ay Listeleme
            SqlCommand cmd2 = new SqlCommand("Select distinct (OdemeAy) from Kasa", con.baglanti());
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0].ToString());
            }
            con.baglanti().Close();
            //Veritabanından Gelir İstatistik Çekme
            SqlCommand cmdgelir = new SqlCommand("select OdemeAy, sum(OdemeMiktar) from Kasa group by OdemeAy", con.baglanti());
            SqlDataReader okugelir = cmdgelir.ExecuteReader();
            while (okugelir.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(okugelir[0], okugelir[1]);
            }
            con.baglanti().Close();
        }
        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select sum(OdemeMiktar) from Kasa where OdemeAy=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                lblAyKzn.Text = oku[0].ToString();
            }
            con.baglanti().Close();
            lblSecilenAy.Text = cmbAy.Text;
        }
    }
}
