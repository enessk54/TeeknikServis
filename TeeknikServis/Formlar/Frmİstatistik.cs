using DevExpress.XtraEditors;
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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db=new DbTeknikServisEntities1();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl5.Text = db.TBLURUN.Count().ToString();
            labelControl1.Text =db.TBLKATEGORI.Count().ToString();
            labelControl3.Text = db.TBLURUN.Sum(x=> x.STOK).ToString();
            labelControl7.Text = "10";
            labelControl19.Text =(from x in db.TBLURUN                      
                                  orderby  x.STOK descending
                                  select x.AD).FirstOrDefault();
            labelControl18.Text =(from x in db.TBLURUN                                  
                                  orderby x.STOK ascending
                                  select x.AD).FirstOrDefault();
            labelControl13.Text=(from x in db.TBLURUN
                                 orderby x.SATISFIYAT descending
                                 select x.AD ).FirstOrDefault();

            labelControl12.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();

            labelControl36.Text = db.TBLURUN.Count(x=> x.KATEGORI==4).ToString();
            labelControl33.Text = db.TBLURUN.Count(x => x.KATEGORI ==1).ToString();
            labelControl32.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            labelControl29.Text=(from x in db.TBLURUN
                                 select x.MARKA).Distinct().Count().ToString();

        }
    }
}
