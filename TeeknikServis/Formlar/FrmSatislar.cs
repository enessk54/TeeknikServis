using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeeknikServis.Formlar
{
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSatislar_Load(object sender, EventArgs e)
        {

            var degerler = from x in db.TBLURUNHAREKET
                           select new

                           {
                               x.HAREKETID,
                               x.TBLURUN.AD,
                               MUSTERI = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               Personel = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.Fıyat,
                               x.URUNSERİNO
                           };
            gridControl1.DataSource = degerler.ToList();

        }
    }
}
