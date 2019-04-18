using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit fr = new FrmOgrKayit();
            fr.Show();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet1.Ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Ogrenciler);
            timer1.Start();

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void notDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void öğrenciListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            fr.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            fr.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler fr = new FrmGiderler();
            fr.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi fr = new FrmGiderListesi();
            fr.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirİstatistik fr = new FrmGelirİstatistik();
            fr.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiIslemleri fr = new FrmYoneticiIslemleri();
            fr.Show();
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelIslemleri fr = new FrmPersonelIslemleri();
            fr.Show();
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotEkle fr = new FrmNotEkle();
            fr.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Yurt Otomasyon Sistemi Selim Can Ermiş Tarafından Hazırlanmıştır. @2018", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
