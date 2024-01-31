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
    public partial class FrmFormKalemleri : Form
    {
        public FrmFormKalemleri()
        {
            InitializeComponent();
        }

        private void FrmFormKalemleri_Load(object sender, EventArgs e)
        {

        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(txtfaturid.Text);
            var degerler = (from u in db.TBLFARURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           }).Where(x=> x.FATURAID ==id);
            gridControl1.DataSource = degerler.ToList();

        }
    }
}
