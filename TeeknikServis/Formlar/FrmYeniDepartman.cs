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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void simpleButton1_Click(object sender, EventArgs e)
            

        {
            TBLDEPARTMAN t= new TBLDEPARTMAN();
            if(Txtad.Text.Length <= 50 && Txtad.Text!="")
            {
                t.AD = Txtad.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi!","bilgi",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("kayıt yapılamadı!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    

        }

        private void FrmYeniDepartman_Load(object sender, EventArgs e)
        {

        }
    }
}
