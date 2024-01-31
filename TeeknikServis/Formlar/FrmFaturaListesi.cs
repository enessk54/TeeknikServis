﻿using System;
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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
       private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               u.TBLPERSONEL.AD

                           };

            gridControl1.DataSource = degerler.ToList();


            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI

                                                 select new
                                                 {
                                                     x.ID,
                                                   AD =   x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL

                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD

                                                 }).ToList();



        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();

            t.SERI = txtseri.Text;
            t.SIRANO = txtsırano.Text;
            t.TARIH = Convert.ToDateTime(txttarih.Text);
            t.SAAT = txtsaat.Text;
            t.VERGIDAIRE = txtvergi.Text;
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse (lookUpEdit2.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir,kalem girişi yapabilirsiniz");
      

        }
    }
}
