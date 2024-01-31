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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM ==false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM ==true).ToList();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t= new TBLNOTLARIM();

            t.BASLIK = Txtbaslık.Text;
            t.ICERIK = txticerik.Text;
            t.DURUM = false;
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not başarıyla kaydedildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if(checkEdit1.Checked == true)
            {
                    int id  = int.Parse(txtid.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show ("Not durumu değiştirildi!","bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning); 


            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
