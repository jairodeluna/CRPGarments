using CRPGarments.Method;
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

namespace CRPGarments
{
    public partial class ChangePassword : Form
    {
        private static readonly ConnectionString con = new ConnectionString();
        Login login = new Login();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            if (txt_newPassword.Text != txt_password.Text)
            {
                MessageBox.Show("Password not matched.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string query = "SELECT * FROM AccountManagement WHERE UserName ='" + SessionStrings.username + "'";
                SqlDataReader sdr = con.ExecuteReader(query);
                if (sdr.Read())
                {
                    sdr.Close();
                    string updateQuery = "UPDATE AccountManagement SET Password = '" + txt_password.Text + "' WHERE Username ='" + SessionStrings.username + "'";
                    con.ExecuteNonQuery(updateQuery);
                    MessageBox.Show("Changed Password Successfuly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Username is invalid.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txt_userName.Text = SessionStrings.username;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
