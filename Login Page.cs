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
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
            implPasswordField();
        }

        private void implPasswordField()
        {
            textBoxLogin_password.PasswordChar = '*';
            textBoxLogin_password.MaxLength = 8;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String userName = textBoxLogin_username.Text.ToString().Trim();
            String password = textBoxLogin_password.Text.ToString().Trim();

            if (userName == "admin" && password == "root")
            {
                MessageBox.Show("Login successfully");
                this.Hide();
                startDashboard();
                //Close();


            }
            else if (userName != "admin")
            {
                MessageBox.Show("Invalid username");
            }
            else if (password != "root") {
                MessageBox.Show("Invalid Password");
            }

            
        }

        private void startDashboard()
        {
            NewDashboard formDashboard = new NewDashboard();
            formDashboard.Show();
            
        }
    }
}
