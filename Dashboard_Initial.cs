using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KM
{
    public partial class Dashboard_Initial : Form
    {
        public Dashboard_Initial()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/JupiterPackingSuppliers");
        }

        private void btnWebsite_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jupiter-packing.business.site/");
        }

        private void btnWhatsApp_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/qr/XZT4IJ3ZZ4GLO1");
        }
    }
}
