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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btn_purchasing_Click(object sender, EventArgs e)
        {

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice objInvoice = new Invoice();
            objInvoice.Show();
        }
    }
}
