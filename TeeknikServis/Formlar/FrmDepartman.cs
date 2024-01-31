using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                select new

                {
                    u.ID,
                    u.AD,
                  
                };
            gridControl1.DataSource = degerler.ToList();

            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
                labelControl14.Text = db.TBLPERSONEL.Count().ToString();
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" && richTextBox1.Text.Length >= 1)
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.AD = TxtAd.Text;
                t.ACIKLAMA = richTextBox1.Text;
               
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt  yapılmadı!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman başarıyla silindi !", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("departman başarıyla güncellendi!", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           

        }

        private void BtnListe_Click(object sender, EventArgs e)

        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD

                           };

            gridControl1.DataSource = degerler.ToList();



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base. FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
         //   richTextBox1.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();

        }
    }
}
