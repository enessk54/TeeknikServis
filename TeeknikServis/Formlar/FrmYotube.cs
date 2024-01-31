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
    public partial class FrmYotube : Form
    {
        public FrmYotube()
        {
            InitializeComponent();
        }

        private void FrmYotube_Load(object sender, EventArgs e)
        {
           webBrowser1.Navigate("https://www.youtube.com");
        }
    }
}
