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
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmMarka_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).
                Select(z => new
                {
            Marka= z.Key,
            Toplam = z.Count()
        });
        
        gridControl1.DataSource=degerler.ToList();
            labelControl1.Text=db.TBLURUN.Count().ToString();
            labelControl5.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.MARKA).FirstOrDefault();

            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 2);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 3);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 1);
            chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Lenova", 5);


            chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya",3);
            chartControl2.Series["Kategoriler"].Points.AddPoint("lenovo", 1);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük E Aletleri", 2);

            chartControl2.Series["Kategoriler"].Points.AddPoint("TV", 2);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Telefon", 1);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Diğer", 2);


        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }
    }
}
