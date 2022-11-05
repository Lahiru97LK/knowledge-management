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
            //using(OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter ="All files|*.*"})
            //{
            //    if(ofd.ShowDialog()==DialogResult.OK)
            //    {
            //        FileInfo fi = new FileInfo(ofd.FileName);
            //        _inputParameter.Supplier_Name = comboBox_suppliername.Text;
            //        _inputParameter.Purchasing_Date = dateTimePicker1.Text;
            //        _inputParameter.Payment_Status = comboBox_PaymentStatus.Text;
            //        _inputParameter.Paid_Amount = textBox_PaidAmount.Text;
            //        _inputParameter.Total_Amount = textBox_TotalAmount.Text;
            //        _inputParameter.Balance_Payment = textBox_BalancePayment.Text;
            //        _inputParameter.Payment_Method = comboBox_PaymentMethod.Text;
            //        _inputParameter.Other = textBox_Other.Text;
            //        _inputParameter.Cheque_Number = textBox_ChequeNumber.Text;
            //        _inputParameter.File_Name = fi.Name;
            //        _inputParameter.Full_Name = fi.FullName;
            //    }
            //}
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox_filePath.Text = dlg.FileName;

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

