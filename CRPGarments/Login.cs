using CRPGarments.Method;
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

namespace CRPGarments
{
    public partial class Login : Form
    {
        private static readonly ConnectionString con = new ConnectionString();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_userName.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please fill up the necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string query = "select Username,Password, AccountType, FirstName, LastName from AccountManagement where Username ='" + txt_userName.Text + "'and Password='" + txt_password.Text + "'";
                SqlDataReader sdr = con.ExecuteReader(query);
                if (sdr.Read())
                {
                    MessageBox.Show("Login Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SessionStrings.username = sdr.GetString(0);
                    SessionStrings.userType = sdr.GetString(2);
                    SessionStrings.firstName = sdr.GetString(3);
                    SessionStrings.lastName = sdr.GetString(4);
                    createDirectory();
                    HomePage dashboard = new HomePage();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sdr.Close();
                con.Close();
            }
            
        }

        private void lbl_forgotPassword_Click(object sender, EventArgs e)
        {
            if (txt_userName.Text == "")
            {
                MessageBox.Show("Please enter your username to continue", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SessionStrings.username = txt_userName.Text;
                ChangePassword cp = new ChangePassword();
                this.Hide();
                cp.Show();
            }
        }

        private void createDirectory()
        {
            SessionStrings.filePath = "C:\\CRPGarments";
            if (!File.Exists(SessionStrings.filePath))
            {
                Directory.CreateDirectory(SessionStrings.filePath);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
