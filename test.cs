using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KM
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textFilePath.Text = dlg.FileName;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFile(textFilePath.Text);
            MessageBox.Show("Saved");
        }
        private void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                string extn = new FileInfo(filePath).Extension;
                string query = "insert into Documents(data,Extension)values(@data,@extn)";

                //string query = "insert into Purchasing(Supplier_Name)values(@SupplierName)";


                using (SqlConnection cn = GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=UIS96;Database=DMS;Integrated Security=true;");
        }
        private void LoadData()
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "select ID,Data,Extension from Documents";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("search result found");
                }
            }
        }

        private void test_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
