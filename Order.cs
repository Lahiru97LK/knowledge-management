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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=UIS96;Initial Catalog=DMS;Integrated Security=True;MultipleActiveResultSets=true");
        SqlDataAdapter sda;
        DataTable dta;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_order", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@purchaseID", textBox1.Text);
            cmd.Parameters.AddWithValue("@customename", textBox1.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@item", item_comboBox1.Text);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown1.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
            ShowTable();
            ClearControls();
        }

        private void item_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ShowTable()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Ordering", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvOrder.DataSource = dt;
                    }
                }

            }
        }
        public void ClearControls()
        {
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            item_comboBox1.Text = "";
            numericUpDown1.Text = "";
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            sda = new SqlDataAdapter("select * from Ordering where Customer_Name like '" + textBox_search.Text + "%'", con);
            dta = new DataTable();
            sda.Fill(dta);
            dgvOrder.DataSource = dta;
            con.Close();

        }
    }
}
