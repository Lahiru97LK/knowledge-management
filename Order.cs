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
        int ID = 0;
        SqlCommand cmd;


        private void cb_customer_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_order", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@purchaseID", cb_customer_name.Text);
            cmd.Parameters.AddWithValue("@customename", cb_customer_name.Text);
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
            cb_customer_name.Text = "";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cb_customer_name.Text != "" && dateTimePicker1.Text != ""  && item_comboBox1.Text != "" && numericUpDown1.Text != "")
            {
                cmd = new SqlCommand("update Ordering set Customer_Name=@customename,Date=@date,Item=@item,Quantity=@quantity where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@customename", cb_customer_name.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@item", item_comboBox1.Text);
                cmd.Parameters.AddWithValue("@quantity", numericUpDown1.Text);
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                ShowTable();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Ordering where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                ShowTable();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dgvOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
            cb_customer_name.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
            item_comboBox1.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            numericUpDown1.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
           
        }
    }
}
