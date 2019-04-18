using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmAnaForm());
            Application.Run(new FrmAdminGiris());
            //Application.Run(new FrmYoneticiIslemleri());
            //Application.Run(new FrmPersonelIslemleri());
            //Application.Run(new FrmBolumler());
            //Application.Run(new FrmOgrKayit());
            //Application.Run(new FrmOdemeler());
            //Application.Run(new FrmOgrListe());
            //Application.Run(new FrmGiderler());
            //Application.Run(new FrmGiderListesi());
            //Application.Run(new FrmGelirİstatistik());
        }
    }
}
