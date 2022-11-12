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
            catch {
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
            //con.Open();
            //SqlCommand cmd = new SqlCommand("update Billing set Supplier_Name='" + textBox3.Text + "' where roll_no='" + textBox1.Text + "'", con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data Updated Successfully.");
            //con.Close();
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
    }
    }



        //private void comboBox_PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioButton_other_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void btn_save_Click(object sender, EventArgs e)
        //{
        //    SaveFile(textBox_filePath.Text);
        //    MessageBox.Show("Saved");
        //}
        //private void SaveFile(string filePath)
       // {
          //  using (Stream stream = File.OpenRead(filePath))
                //{
                //    byte[] buffer = new byte[stream.Length];
                //    stream.Read(buffer, 0, buffer.Length);
                //    string extn = new FileInfo(filePath).Extension;
                //FileInfo fi = new FileInfo(filePath);
                //string name = fi.name;
                //string query = "insert into Purchasing(Supplier_Name,DOP,Amount,Paid_Amount,Balance_Amonut,Payment_Method,Cheque_number,Other,Payment_Status,File)values(@SupplierName,@DOP,@Amount,@PaidAmount,@BalanceAmonut,@PaymentMethod,@Chequenumber,@Other,@paymentStatus,@file)";

                //string query = "insert into Purchasing(Supplier_Name)values(@SupplierName)";


               // using (SqlConnection cn = GetConnection())
                //{
                    //SqlCommand cmd = new SqlCommand(query, cn);

                    //cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = comboBox_suppliername.Text.Trim();
                    //cmd.Parameters.Add("@DOP", SqlDbType.Date).Value = dateTimePicker1.Text.Trim();
                    //cmd.Parameters.Add("@Amount", SqlDbType.Float).Value = textBox_TotalAmount.Text.Trim();
                    //cmd.Parameters.Add("@PaidAmount", SqlDbType.Float).Value = textBox_PaidAmount.Text.Trim();
                    //cmd.Parameters.Add("@BalanceAmonut", SqlDbType.Float).Value = textBox_BalancePayment.Text.Trim();
                    //cmd.Parameters.Add("@PaymentMethod", SqlDbType.VarChar).Value = comboBox_PaymentMethod.Text.Trim();
                    //cmd.Parameters.Add("@Chequenumber", SqlDbType.Int).Value = textBox_ChequeNumber.Text.Trim();
                    //cmd.Parameters.Add("@Other", SqlDbType.VarChar).Value = textBox_Other.Text.Trim();
                    //cmd.Parameters.Add("@extn", SqlDbType.VarChar).Value = textBox_filePath.Text.Trim();
                    //cmd.Parameters.Add("@paymentStatus", SqlDbType.VarChar).Value = comboBox_PaymentStatus.Text.Trim();
                    //cmd.Parameters.Add("@details", SqlDbType.VarBinary).Value = buffer;

                    //cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = "Lahiru";
                    //cmd.Parameters.Add("@DOP", SqlDbType.Date).Value = "2022-10-30";
                    //cmd.Parameters.Add("@Amount", SqlDbType.Float).Value = 2000.00;
                    //cmd.Parameters.Add("@PaidAmount", SqlDbType.Float).Value = 1000.00;
                    //cmd.Parameters.Add("@BalanceAmonut", SqlDbType.Float).Value = 1000.00;
                    //cmd.Parameters.Add("@PaymentMethod", SqlDbType.VarChar).Value = "cash";
                    //cmd.Parameters.Add("@Chequenumber", SqlDbType.Int).Value = 12345;
                    //cmd.Parameters.Add("@Other", SqlDbType.VarChar).Value = "sggdgj";
                    //cmd.Parameters.Add("@extn", SqlDbType.VarChar).Value = "dguyfgduyff";
                    //cmd.Parameters.Add("@paymentStatus", SqlDbType.VarChar).Value = "paid";
                    //cmd.Parameters.Add("@details", SqlDbType.VarBinary).Value = "jkbjkkknhj";
                    //cn.Open();
                    //cmd.ExecuteNonQuery();
                //}
            //}
 //   }



//        //private SqlConnection GetConnection()
//        {
//            return new SqlConnection(@"Data Source=UIS96;Database=DMS;Integrated Security=true;");
//}
//    }
//}

