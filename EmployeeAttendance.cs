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
    public partial class EmployeeAttendance : Form
    {

        String employeeId;
        String employeeName;
        DateTime startTime;
        DateTime endTime;

        public EmployeeAttendance()
        {
            InitializeComponent();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            employeeId = txtEmployeeId.Text.ToString().Trim();
            employeeName = txtbEmployeeName.Text.ToString().Trim();
            //startTime = dtpStartTime.Value;
            //endTime = dtpEndTime.Value;

        }

        private void txtEmployeeId_KeyUp(object sender, KeyEventArgs e)
        {

            employeeId = txtEmployeeId.Text.ToString().Trim();
            employeeName = txtbEmployeeName.Text.ToString().Trim();
            //startTime = dtpStartTime.Value;
            //endTime = dtpEndTime.Value;

            if (employeeId == "10001")
            {
                txtbEmployeeName.Text = "Lahiru Sandaruwan";
            }
            else
            {
                txtbEmployeeName.Text = "";
            }
        }
    }
}
