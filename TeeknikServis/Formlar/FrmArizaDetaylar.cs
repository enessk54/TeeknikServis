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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = Txtserino.Text;
           t.TARIH = DateTime.Parse(Txttarih.Text);
            
            db.TBLURUNTAKIP.Add(t);
            db.SaveChanges();
            MessageBox.Show("ürün arıza detayları güncellendi");


            

        }
    }
}
