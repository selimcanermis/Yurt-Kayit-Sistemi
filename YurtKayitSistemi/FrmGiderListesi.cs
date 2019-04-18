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
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }
        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet7.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Giderler);
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmGiderGuncelle frgider = new FrmGiderGuncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frgider.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frgider.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frgider.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frgider.dogalgaz = dataGridView1.Rows[0].Cells[3].Value.ToString();
            frgider.net = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frgider.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frgider.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frgider.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frgider.Show();
        }
    }
}
