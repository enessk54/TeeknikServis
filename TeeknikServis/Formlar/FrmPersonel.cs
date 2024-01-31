using DevExpress.Entity.Model.DescendantBuilding;
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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON

                           };
            
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new

                                                {
                                                    x.ID,
                                                    x.AD

                                                }).ToList();



            string ad1, soyad1,ad2,soyad2,ad3,soyad3,ad4,soyad4;
            //1.personel
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl6.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl8.Text = db.TBLPERSONEL.First(x =>x.ID ==1).MAIL;
            labelControl5.Text = ad1 + "" + soyad1;
            
            // 2.personel
              
            ad2 = db.TBLPERSONEL.First(x => x.ID ==2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl10.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.ID ==2).MAIL;
            labelControl11.Text = ad2 + "" + soyad2;

            // 3.personel

            ad3 = db.TBLPERSONEL.First(x => x.ID ==3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID==3).SOYAD;
            labelControl17.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            labelControl18.Text = ad3 + "" + soyad3;


            // 4 .personel

            ad4 = db.TBLPERSONEL.First(x => x.ID == 14).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 14).SOYAD;
            labelControl23.Text = db.TBLPERSONEL.First(x => x.ID == 14).TBLDEPARTMAN.AD;
            labelControl22.Text = db.TBLPERSONEL.First(x => x.ID == 14).MAIL;
            labelControl24.Text = ad4 + "" + soyad4;

            


        }
    }
}
