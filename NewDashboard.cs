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
    public partial class NewDashboard : Form
    {
        public NewDashboard()
        {
            InitializeComponent();
            lblHeaderTitle.Text = "Dashboard";
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "INVOICE";
            loadForm(new Invoice());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "ORDER";
            loadForm(new Order());
        }

        private void btnPurchasing_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "PURCHASING";
            loadForm(new purchasing());
        }

        private void btnEmployeeAttendance_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "EMPLOYEE ATTENDANCE";
            loadForm(new EmployeeAttendance());
        }

        public void loadForm(Object Form) {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            if (MessageBox.Show("Are you sure to exit ?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
