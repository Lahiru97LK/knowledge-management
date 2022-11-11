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
    public partial class EmployeeAttendance : Form
    {
        int PK_ID = 0 ;
        public EmployeeAttendance()
        {
            InitializeComponent();
            LoadGrid();
            InitialValues();
        }

        private void InitialValues()
        {
            txtbEmployeeId.Text = "";
            txtbEmployeeName.Text = "";
            txtbTotalWorkingHours.Text = "";
            btnMark.Enabled = false;
        }

        SqlConnection con = new SqlConnection("Data Source=UIS96;Initial Catalog=DMS;Integrated Security=True;MultipleActiveResultSets=true");

        private void btnMark_Click(object sender, EventArgs e)
        {

            try
            {

                //int empId = 1006;
                //String empName = "Testing3";
                //string workedDate = "10/30/2022 12:00:00 AM";
                //String startTime = "08:00 AM";
                //String endTime = "05:00 PM";
                //string noOfHoursWorked = "09:00:00";
                //DateTime workedDate = DateTime.Parse(dateTimePickerDate.Text);

                int empId = Convert.ToInt32(txtbEmployeeId.Text.ToString().Trim());
                String empName = txtbEmployeeName.Text.ToString().Trim();
                String workedDate = dateTimePickerDate.Text;
                String startTime = dtpStartTime.Text;
                String endTime = dtpEndTime.Text;
                string noOfHoursWorked = txtbTotalWorkingHours.Text.ToString().Trim();

                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC ins_EmployeeDetails '" + empId + "', '" + empName + "', '" + workedDate + "','" + startTime + "','" + endTime + "', '" + noOfHoursWorked + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfylly inserted !");
                InitialValues();
                con.Close();

                LoadGrid(); // update grid
            }
            catch
            {
                MessageBox.Show("Unsuccessfully !");
            }
        }

        private void dtpEndTime_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateWorkingHours();
        }

        private void calculateWorkingHours()
        {
            TimeSpan result = this.dtpEndTime.Value - this.dtpStartTime.Value;
            this.txtbTotalWorkingHours.Text = result.ToString();



            String s = txtbTotalWorkingHours.Text.Trim();
            String[] tempArray = txtbTotalWorkingHours.Text.Split('.');
            txtbTotalWorkingHours.Text = tempArray[0];
        }

        private void dtpEndTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            calculateWorkingHours();

        }

        private void EmployeeAttendance_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EXEC selEmployeeAttendance", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvEmployeeAttendance.DataSource = dt;
            this.dgvEmployeeAttendance.Columns["ID"].Visible = false;
            
            con.Close();
        }

        private void txtbEmployeeId_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {

                String employeeNumber = (txtbEmployeeId.Text.ToString().Trim());
                int empNo = Convert.ToInt32(employeeNumber);
                LoadEmployeeName(empNo);
            }
            catch {
                MessageBox.Show("Enter numbers only");
            }
        }

        private void LoadEmployeeName(int employeeNumber)
        {

            con.Open();
            SqlCommand cmdLoadEmpName = new SqlCommand("EXEC getEMP_NAME_byEMP_ID '"+employeeNumber+"'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmdLoadEmpName);
          
            SqlDataReader reader = cmdLoadEmpName.ExecuteReader();
            con.Close();
            DataTable dt = new DataTable();
            sd.Fill(dt);

            String empName="";
            if (dt.Rows.Count > 0)
            {
                empName = dt.Rows[0][0].ToString().Trim();
                btnMark.Enabled = true;
            }
            else {
                empName = "";
                btnMark.Enabled = false;
            }
            txtbEmployeeName.Text = empName;

        }

        private void txtbEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbEmployeeId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbEmployeeId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtbEmployeeId.Text = txtbEmployeeId.Text.Remove(txtbEmployeeId.Text.Length - 1);
            }
        }

        private void dtpEndTime_DropDown(object sender, EventArgs e)
        {
            calculateWorkingHours();
        }

        private void dgvEmployeeAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployeeAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvEmployeeAttendance.CurrentRow.Selected = true;
                txtbEmployeeId.Text = dgvEmployeeAttendance.Rows[e.RowIndex].Cells["EMP_ID"].FormattedValue.ToString();
                txtbEmployeeName.Text = dgvEmployeeAttendance.Rows[e.RowIndex].Cells["EMP_NAME"].FormattedValue.ToString();
                txtbTotalWorkingHours.Text = dgvEmployeeAttendance.Rows[e.RowIndex].Cells["NO_OF_WORKING_HOURS"].FormattedValue.ToString();
                PK_ID = Convert.ToInt32(dgvEmployeeAttendance.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                //PK_ID
                String employeeNumber = (txtbEmployeeId.Text.ToString().Trim());
                int empNo = Convert.ToInt32(employeeNumber);

                con.Open();
                SqlCommand cmdLoadEmpName = new SqlCommand("EXEC delEMPbyEMP_ID '" + @PK_ID + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmdLoadEmpName);
                MessageBox.Show("1 Record successfully deleted!");
                InitialValues();

                SqlDataReader reader = cmdLoadEmpName.ExecuteReader();
                con.Close();
                DataTable dt = new DataTable();
                sd.Fill(dt);
                LoadGrid();
            }
            catch(Exception)
            {
                MessageBox.Show("Please select a record to delete!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchEmployeeByID();
        }

        private void searchEmployeeByID()
        {
          try
            {
                int PK_ID = Convert.ToInt32(txtbEmployeeId.Text.ToString().Trim());

                con.Open();
                SqlCommand cmdSearchEmpName = new SqlCommand("EXEC selEMPbyEMP_ID '" + @PK_ID + "'", con);
                cmdSearchEmpName.ExecuteNonQuery();
                SqlDataAdapter sd = new SqlDataAdapter(cmdSearchEmpName);
                

                SqlDataReader reader = cmdSearchEmpName.ExecuteReader();
                con.Close();
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Search successfully!");
                    dgvEmployeeAttendance.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record(s) not found");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a id to search!");
            }
        }

        private void txtbEmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                empDetailsUpdate();
            } catch(Exception)
            {
                throw;
            }
            
        }

        private void empDetailsUpdate()
        {
            //int @PK_ID = Convert.ToInt32(txtbEmployeeId.Text.ToString().Trim());
            int @EMPNO = Convert.ToInt32(txtbEmployeeId.Text.ToString().Trim());
            string @EMPNAME = txtbEmployeeName.Text.ToString().Trim();
            string @DATE = dateTimePickerDate.Text;
            string @STARTTIME = dtpStartTime.Text;
            string @ENDTIME = dtpEndTime.Text;
            string @NOOFWORKING_HOURS = txtbTotalWorkingHours.Text.ToString().Trim();


            con.Open();
            SqlCommand cmdUPDATE = new SqlCommand("EXEC updEmployeeAttendance '"+ @PK_ID + "', '"+ @EMPNO + "', '"+ @EMPNAME + "', '"+ @DATE + "', '"+ @STARTTIME + "', '"+ @ENDTIME + "', '"+ @NOOFWORKING_HOURS + "'", con);
            cmdUPDATE.ExecuteNonQuery();
            MessageBox.Show("Successfully updated");
            InitialValues();
            con.Close();
            LoadGrid();
        }
    }
}
