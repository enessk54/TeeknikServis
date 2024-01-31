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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFARURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                              
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFARURADETAY t = new TBLFARURADETAY();

            t.URUN = txtürün.Text;
            t.ADET = short.Parse(txtadet.Text);
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.TUTAR = decimal.Parse(txttutar.Text);
            t.FATURAID = int.Parse(txtfaturaid.Text);
            db.TBLFARURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya ait kalem girişi başarı ile yapıldı");
        
            


        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFARURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID

                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
