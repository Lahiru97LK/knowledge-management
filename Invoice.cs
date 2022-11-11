using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KM
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            generateInvoiceNumber();
        }

        SqlConnection con = new SqlConnection("Data Source=UIS96;Initial Catalog=DMS;Integrated Security=True;MultipleActiveResultSets=true");

        private void generateInvoiceNumber()
        {
            try
            {
                int PK_ID = 1;
                con.Open();
                SqlCommand cmdSelInvoiceNumber = new SqlCommand("EXEC selEMPbyEMP_ID '" + @PK_ID + "'", con);
                cmdSelInvoiceNumber.ExecuteNonQuery();
                SqlDataAdapter sd = new SqlDataAdapter(cmdSelInvoiceNumber);
                //MessageBox.Show("Search successfully!");

                SqlDataReader reader = cmdSelInvoiceNumber.ExecuteReader();
                con.Close();
                DataTable dt = new DataTable();
                sd.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a id to search!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
