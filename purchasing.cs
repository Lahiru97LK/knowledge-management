using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KM
{
    public partial class purchasing : Form
    {
        public purchasing()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=UIS96;Initial Catalog=DMS;Integrated Security=True;MultipleActiveResultSets=true");
        SqlDataAdapter sda;
        DataTable dta;
        SqlCommand cmd;
        int ID = 0;
        struct FtpSetting
        {
            public string Supplier_Name { get; set; }
            public string Purchasing_Date { get; set; }
            public string Payment_Status { get; set; }
            public string Paid_Amount { get; set; }
            public string Total_Amount { get; set; }
            public string Balance_Payment { get; set; }
            public string Payment_Method { get; set; }
            public string Cheque_Number { get; set; }
            public string Other { get; set; }
            public string File_Name { get; set; }
            //public string Full_Name { get; set; }

        }
        //FtpSetting _inputParameter;


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox_filePath.Text = dlg.FileName;

        }

        private void comboBox_suppliername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClearControls()
        {
            comboBox_suppliername.SelectedIndex = -1;
            dateTimePicker1.Text = "";
            textBox_total.Text = "";
            textBox_payment.Text = "";
            textBox_Balance.Text = "";
            ID = 0;
            //textBox_Balance.Text = "";
            //(text_balance.Text).ToString()= "";  

        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Balance_TextChanged(object sender, EventArgs e)
        {
            //textBox_Balance.Text = (Double.Parse(textBox_total.Text) - Double.Parse(textBox_payment.Text)).ToString();
            try
            {
                double balance = 0.00;
                double total = 0.00;
                double payment = 0.00;

                total = double.Parse(textBox_total.Text.ToString().Trim());
                payment = double.Parse(textBox_payment.Text.ToString().Trim());

                balance = total - payment;

                textBox_Balance.Text = balance.ToString().Trim();
            }
            catch
            {
                ClearControls();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@purchaseID", textBox1.Text);
            cmd.Parameters.AddWithValue("@supplierName", comboBox_suppliername.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@total", textBox_total.Text);
            cmd.Parameters.AddWithValue("@payment", textBox_payment.Text);
            cmd.Parameters.AddWithValue("@balance", textBox_Balance.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
            ShowTable();
            ClearControls();
            //text_balance.Clear();
        }

        public static void main(string[] args)
        {
            Application.Run(new Form());
        }

        public void ShowTable()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Billing", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged_1(object sender, EventArgs e)
        {
            con.Open();
            sda = new SqlDataAdapter("select * from Billing where Supplier_Name like '" + textBox_search.Text + "%'", con);
            dta = new DataTable();
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            con.Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (comboBox_suppliername.Text != "" && dateTimePicker1.Text != "" && textBox_total.Text != "" && textBox_payment.Text != "" && textBox_Balance.Text != "")
            {
                cmd = new SqlCommand("update Billing set Supplier_Name=@name,Date=@date,Total=@total,Payment=@payment,Balance=@balance where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", comboBox_suppliername.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@total", textBox_total.Text);
                cmd.Parameters.AddWithValue("@payment", textBox_payment.Text);
                cmd.Parameters.AddWithValue("@balance", textBox_Balance.Text);
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

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox_suppliername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_total.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_payment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_Balance.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Billing where ID=@id", con);
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

        private void btn_upload_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("select valid document");
                }
                else
                {
                    //call the connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Document(Document)values('\\Document\\" + filename + "')", con);

                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Document\\" + filename);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("document uploaded");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {

            //initial location
            openFileDialog1.InitialDirectory = "C://Desktop";
            //opendialog box title name
            openFileDialog1.Title = "select files to be upload";
            //add file types to be uploaded
            openFileDialog1.Filter = "select only formats(*.pdf; *.doc; *.xlsx; *.html; *.txt)|*.pdf; *.docx; *.xlsx; *.html; *.txt";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        textBox_filePath.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("upload document");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ShowTable2()
        {
            
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Document", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
    }
}



        

