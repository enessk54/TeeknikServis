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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {

        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN = int.Parse (Txtİd.Text);
            t.MUSTERI = int.Parse (TxtMüsteri.Text);
            t.PERSONEL = short.Parse(Txtpersonel.Text);
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(Txtadet.Text);
            t.Fıyat = decimal.Parse(Txtsatıs.Text);
            t.URUNSERİNO = Txtserino.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Saatış Yapıldı");

        }
    }
}
