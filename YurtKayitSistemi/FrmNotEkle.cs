using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YurtKayitSistemi
{
    public partial class FrmNotEkle : Form
    {
        public FrmNotEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt Yeri Seçiniz";
            saveFileDialog1.Filter = "Metin Dosyası | *.txt";
            saveFileDialog1.InitialDirectory = "‪C:\\Users\\Selim Can\\Documents\\Notlar";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Kayıt Yapıldı", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmNotEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
