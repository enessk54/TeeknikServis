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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();

            t.AD = txtAd.Text;
            t.SOYAD = txtsoyad.Text;
            t.IL = txtil.Text;
            t.ILCE = txtilce.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Sisteme Başarılı Bir Şekilde Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
