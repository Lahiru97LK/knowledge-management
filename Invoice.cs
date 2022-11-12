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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.draw;

namespace KM
{
    public partial class Invoice : Form
    {
        int INVOICE_NO = 0;
        
        public Invoice()
        {
            InitializeComponent();
            generateInvoiceNumber();
            loadingForm();
            loadGridToData();
            lblInvoiceNumber.Text = "";
        }

        private void loadingForm()
        {
            btn_printinvoice.Enabled = false;
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

        Bitmap bmp;
        private void btn_printinvoice_Click(object sender, EventArgs e)
        {
            MprintPreviewDialog.Document = MprintDocument;
            MprintPreviewDialog.ShowDialog();
        }

        private void LoadGrid()
        {
            con.Open();
            SqlCommand cmdSEL_LAST_INSERTED_DATA = new SqlCommand("EXEC INVOICE_SEL_LAST_INSERTED_DATA ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmdSEL_LAST_INSERTED_DATA);
            con.Close();

            DataTable dt = new DataTable();
            sd.Fill(dt);

            int quantity = 1;
            //double @nitPrice = 0;
            //double total = 0;

            int count = dt.Rows.Count;
            int count2 = dt.Columns.Count;

            string customerName = (String)dt.Rows[0][1];
            string phone = (String)dt.Rows[0][2];
            string address = (String)dt.Rows[0][3];
            string mail = (String)dt.Rows[0][4];
            string item = (String)dt.Rows[0][5];
            string distric = (String)dt.Rows[0][6];
            quantity = (int)dt.Rows[0][7];
            string unitPrice = dt.Rows[0][8].ToString().Trim();
            string total = dt.Rows[0][9].ToString().Trim();

            Document doc = new Document();
            String datetimeNow = DateTime.Now.ToString();
            string filename = datetimeNow;

            filename = datetimeNow.Replace("/", "_");
            filename = filename.Replace(" ", "_");
            filename = filename.Replace(":", "_");

            PdfWriter.GetInstance(doc, new FileStream("F:/KM/PDF/INVOICE/INVOICE_" + filename+".pdf", FileMode.Create));

            doc.Open();

            Paragraph p1 = new Paragraph("INVOICE REPORT");
            p1.Alignment = Element.ALIGN_CENTER;

            DottedLineSeparator dottedline = new DottedLineSeparator();
            Paragraph p4 = new Paragraph("");
            p4.Add(dottedline);
            Paragraph p2 = new Paragraph("\n\nCUSTOMER NAME : " + customerName+"\nPHONE : "+phone + "\nADDRESS : " + address+ "\nEMAIL : " +mail+"\nITEM : "+item+ "\nDISTRICT : "+distric+ "\nQUANTITY : "+quantity+ "\nUNIT PRICE : "+unitPrice+ "\nTOTAL : "+total);
            Paragraph p3 = new Paragraph("  \n\nJupiter Packing Suppliers\nAlubogahawatta"
                                            +"\nParagasthota"
                                            +"\nHorana"
                                            +"\nTel - 0777715233"
                                            +"\nEmail - jupiterpacking7@gmail.com\n");
            p3.Alignment = Element.ALIGN_RIGHT;
            doc.Add(p1);
            doc.Add(p4);

            doc.Add(p3);
            doc.Add(p2);

            doc.Close();
            MessageBox.Show("Successfully");
        }

        private void printInsertedDATA()
        {
            int @quantity = 1;
            double @unitPrice = 0;
            double @total = 0;

            string @customerName = comboBox_customername.Text.ToString();
            string @phone = textBox_phonenumber.Text;
            string @address = textBox_email.Text;
            string @mail = textBox_email.Text;
            string @item = comboBox_item.Text.ToString();
            string @distric = comboBox_district.Text.ToString();
            @quantity = Convert.ToInt32(nud_Quantity.Value);
            if (textBox_unitprice.Text.Length > 0)
            {
                @unitPrice = double.Parse(textBox_unitprice.Text);
            }
            else {
                @unitPrice = 00.00;
            }
            @total = quantity * unitPrice;

            con.Open();
            SqlCommand cmdINSERT = new SqlCommand("EXEC INVOICE_INSERT '"+ @customerName + "', '"+ @phone + "', '"+ @address + "', '"+ @mail + "', '"+ @item + "', '"+ @distric  + "', '" + @quantity  + "', '"+ @unitPrice + "', '"+ @total + "'", con);
            cmdINSERT.ExecuteNonQuery();
            con.Close();
        }

        private void textBox_phonenumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_phonenumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_phonenumber.Text = textBox_phonenumber.Text.Remove(textBox_phonenumber.Text.Length - 1);
            }

            textBox_phonenumber.MaxLength = 10;
        }

        private void textBox_phonenumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox_phonenumber.Text.Length != 10)
            {
                //MessageBox.Show("Enter valid phone number");
                btn_saveinvocie.Enabled = false;
            }else
            {
                btn_saveinvocie.Enabled = true;
            }
        }

        private void textBox_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox_phonenumber_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_unitprice_TextChanged(object sender, EventArgs e)
        {
        }

        private void calcTotal()
        {

            try
            {

                int quantity = Convert.ToInt32(nud_Quantity.Value.ToString());

                float unitPrice = float.Parse(textBox_unitprice.Text);

                float total;

                if (unitPrice / 1 != unitPrice)
                {
                    MessageBox.Show("Invalid unit price");
                    btn_printinvoice.Enabled = false;
                }
                else
                {
                    btn_printinvoice.Enabled = true;
                }

                total = quantity * unitPrice;

                textBox_total.Text = total.ToString();
            }
            catch {
                MessageBox.Show("Invalid  unit price");
                textBox_unitprice.Text = string.Empty;
            }
        }

        private void textBox_unitprice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nud_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_unitprice_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void btn_saveinvocie_Click(object sender, EventArgs e)
        {
            printInsertedDATA();
            LoadGrid();
            //clearDATA();
        }

        private void clearDATA()
        {
            comboBox_customername.Text = string.Empty;
            textBox_phonenumber.Text = "";
            textBox_address.Text = "";
            textBox_email.Text = "";
            comboBox_item.ResetText();
            comboBox_district.ResetText();
            textBox_unitprice.Text = "";
            nudQuantity.Value = 1;

            textBox_total.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            invoiceSearch();
        }

        private void invoiceSearch()
        {
            try
            {
                int @INVOICE_ID = Convert.ToInt32(tbInvoiceNumber.Text);

                con.Open();
                //SqlCommand cmdSearchInvoice = new SqlCommand("EXEC selInvoiceByID '" + @INVOICE_ID + "'", con);
                SqlCommand cmdSearchInvoice = new SqlCommand("SELECT * FROM INVOICE WHERE INVOICE_NO = '"+INVOICE_ID+"'",con);
                cmdSearchInvoice.ExecuteNonQuery();
                SqlDataAdapter sd = new SqlDataAdapter(cmdSearchInvoice);
                con.Close();

                DataTable dt = new DataTable();
                sd.Fill(dt);
                //dgv_Invoice.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dgv_Invoice.DataSource = dt;
                }
                else
                {
                    dgv_Invoice.DataSource = null;
                }
            }
            catch (Exception)
            {
                loadGridToData();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgv_Invoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_Invoice.CurrentRow.Selected = true;

                cbCustomerName.Text = dgv_Invoice.Rows[e.RowIndex].Cells["CUSTOMER_NAME"].FormattedValue.ToString().Trim();
                tbPhone.Text = dgv_Invoice.Rows[e.RowIndex].Cells["PHONE"].FormattedValue.ToString().Trim();
                tbAddress.Text = dgv_Invoice.Rows[e.RowIndex].Cells["ADDRESS"].FormattedValue.ToString().Trim();
                tbEmail.Text = dgv_Invoice.Rows[e.RowIndex].Cells["EMAIL"].FormattedValue.ToString().Trim();

                cbItem.Text = dgv_Invoice.Rows[e.RowIndex].Cells["ITEM"].FormattedValue.ToString().Trim();
                cbDistrict.Text = dgv_Invoice.Rows[e.RowIndex].Cells["DISTRIC"].FormattedValue.ToString().Trim();
                //nudQuantity.Value = dgv_Invoice.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                tbUnitPrice.Text = dgv_Invoice.Rows[e.RowIndex].Cells["UNIT_PRICE"].FormattedValue.ToString().Trim();
                tbTotal.Text = dgv_Invoice.Rows[e.RowIndex].Cells["TOTAL"].FormattedValue.ToString().Trim();
                INVOICE_NO = Convert.ToInt32(dgv_Invoice.Rows[e.RowIndex].Cells["INVOICE_NO"].FormattedValue.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadGridToData();
        }

        private void loadGridToData()
        {
            con.Open();
            SqlCommand cmdSelAllInvoiceDATA = new SqlCommand("SELECT * FROM INVOICE", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdSelAllInvoiceDATA);
            con.Close();

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Invoice.DataSource = dt;
        }

        private void tbInvoiceNumber_KeyUp(object sender, KeyEventArgs e)
        {
            invoiceSearch();
        }

        private void tbInvoiceNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbInvoiceNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbInvoiceNumber.Text = tbInvoiceNumber.Text.Remove(tbInvoiceNumber.Text.Length - 1);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                deleteInvoice();
                loadGridToData();
                clearINVOICEManageDATA();
            }
            catch (Exception) {
                MessageBox.Show("Try again...");
            }
        }

        private void deleteInvoice()
        {
            con.Open();
            SqlCommand cmdDEL_Invoice = new SqlCommand("EXEC del_Invoice_by_id '"+INVOICE_NO+"'", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmdDEL_Invoice);
            cmdDEL_Invoice.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("1 record successfully deleted!");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0);
            int @quantity = 1;
            double @unitPrice = 0;
            double @total = 0;

            string @customerName = comboBox_customername.Text.ToString();
            string @phone = textBox_phonenumber.Text;
            string @address = textBox_email.Text;
            string @mail = textBox_email.Text;
            string @item = comboBox_item.Text.ToString();
            string @distric = comboBox_district.Text.ToString();
            @quantity = Convert.ToInt32(nud_Quantity.Value);
            if (textBox_unitprice.Text.Length > 0)
            {
                @unitPrice = double.Parse(textBox_unitprice.Text);
            }
            else
            {
                @unitPrice = 00.00;
            }
            @total = quantity * unitPrice;

            e.Graphics.DrawString("INVOICE REPORT", new System.Drawing.Font("Arial", 18, FontStyle.Regular),Brushes.Black, new Point(300,50));
            e.Graphics.DrawString("DATE : "+DateTime.Now.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 80));
            e.Graphics.DrawString(".......................................................................................................", new System.Drawing.Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(50, 85));


            e.Graphics.DrawString("\n\nJupiter Packing Suppliers\nAlubogahawatta"
                                + "\nParagasthota"
                                + "\nHorana"
                                + "\nTel - 0777715233"
                                + "\nEmail - jupiterpacking7@gmail.com\n"
                                    , new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 100));


            e.Graphics.DrawString("\n\n\n\nCUSTOMER NAME : " +@customerName
                                           +"\nPHONE : " +@phone
                                           + "\nADDRESS : " + @address
                                           + "\nEMAIL : " + @mail
                                           + "\nDISTRICT : " + @distric
                                           + "\nQUANTITY : " + @quantity
                                           + "\nUNIT PRICE : " + @unitPrice
                                           + "\nTOTAL : " + @total
                                                , new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                updateInvoiceByID();
                clearINVOICEManageDATA();
            }
            catch (Exception exc) {
                MessageBox.Show("Try again!");
            }
            
        }

        private void clearINVOICEManageDATA()
        {
            cbCustomerName.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbInvoiceNo.Text = string.Empty;
            cbItem.Text = string.Empty;
            cbDistrict.Text = string.Empty;
            nudQuantity.Value = 1;
            tbUnitPrice.Text = string.Empty;
            tbTotal.Text = string.Empty;
        }

        private void updateInvoiceByID()
        {

            int @quantity = 1;
            double @unitPrice = 0;
            double @total = 0;

            string @customerName = cbCustomerName.Text.ToString();
            int @phone = Convert.ToInt32(tbPhone.Text);
            string @address = tbAddress.Text;
            string @mail = tbEmail.Text;
            string @item = cbItem.Text.ToString();
            string @distric = cbDistrict.Text.ToString();
            //@quantity = Convert.ToInt32(nudQuantity.Value);

            @quantity = Convert.ToInt32(nud_Quantity.Value);
            if (textBox_unitprice.Text.Length > 0)
            {
                @unitPrice = double.Parse(textBox_unitprice.Text);
            }
            else
            {
                @unitPrice = 00.00;
            }
            @total = quantity * unitPrice;


            con.Open();

            SqlCommand cmdUpdateInvoice = new SqlCommand("EXEC upd_invoice '"+ @INVOICE_NO + "','" + @customerName + "', '" + @phone + "', '" + @address + "', '" + @mail + "', '" + @item + "', '" + @distric + "', '" + @quantity + "', '" + @unitPrice + "', '" + @total + "'", con);
            cmdUpdateInvoice.ExecuteNonQuery();
            MessageBox.Show("1 record successfully updated!");
            con.Close();

            loadGridToData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calcTotalPrice();
        }

        private void calcTotalPrice()
        {
            try
            {
                int quantity = Convert.ToInt32(nudQuantity.Value.ToString());
                float unitPrice = float.Parse(tbUnitPrice.Text);
                float total;

                if (unitPrice / 1 != unitPrice)
                {
                    MessageBox.Show("Invalid unit price");
                    btn_update.Enabled = false;
                }
                else
                {
                    btn_update.Enabled = true;
                }

                total = quantity * unitPrice;

                tbTotal.Text = total.ToString();
            }
            catch {
                MessageBox.Show("Invalid unit price. Enter again");
                tbUnitPrice.Text = string.Empty;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            tbPhone.MaxLength = 10;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDATA();
        }
    }
}
