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
    public partial class AddAccountControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        public AddAccountControl()
        {
            InitializeComponent();
        }
        private void AddAccountControl_Load(object sender, EventArgs e)
        {
            if (SessionStrings.processType == "Update")
            {
                con.Open();
                string query = "SELECT LastName, FirstName, MiddleName, ContactNumber, Address, Username FROM AccountManagement WHERE AccountId = '" + SessionStrings.sessionId + "'";
                SqlDataReader sdr = con.ExecuteReader(query);
                if (sdr.Read())
                {
                    txt_lastName.Text = sdr.GetString(0);
                    txt_firstName.Text = sdr.GetString(1);
                    txt_middleName.Text = sdr.IsDBNull(2) ? "" : sdr.GetString(2);
                    txt_contactNumber.Text = sdr.GetString(3);
                    txt_address.Text = sdr.GetString(4);
                    txt_userName.Text = sdr.GetString(5);
                    txt_userName.Enabled = false;
                    txt_password.Visible = false;
                }
                sdr.Close();
                con.Close();
            }
            else
            {
                txt_lastName.Text = "";
                txt_firstName.Text = "";
                txt_contactNumber.Text = "";
                txt_address.Text = "";
                txt_userName.Text = "";
                txt_password.Text = "";
                txt_password.Visible = true;
                lbl_password.Visible = true;
                txt_userName.Enabled = true;
            }
        }
        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            if (txt_lastName.Text == "" || txt_firstName.Text == "" || txt_contactNumber.Text == "" || txt_address.Text == "" || txt_userName.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please fill up the necessary details.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();

                if (SessionStrings.processType == "Update")
                {
                    string updateQuery = "Update AccountManagement SET LastName = '" + txt_lastName.Text + "', FirstName = '" + txt_firstName.Text + "', MiddleName = '" + txt_middleName.Text + "' ContactNumber = '" + txt_contactNumber.Text + "', Address = '" + txt_address.Text + "' WHERE AccountId = '" + SessionStrings.sessionId + "'";
                    con.ExecuteNonQuery(updateQuery);
                    MessageBox.Show("Account was updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string validateQuery = "SELECT Username FROM AccountManagement WHERE AccountId = '" + SessionStrings.sessionId + "'";
                    SqlDataReader sdr = con.ExecuteReader(validateQuery);
                    if (sdr.Read())
                    {
                        MessageBox.Show("Account already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sdr.Close();
                        string query = "Insert into AccountManagement values('" + txt_userName.Text + "', '" + txt_password.Text + "', '" + txt_lastName.Text + "', '" + txt_firstName.Text + "', '" + txt_middleName.Text + "', '" + txt_contactNumber.Text + "', '" + txt_address.Text + "', 'user')";
                        con.ExecuteNonQuery(query);
                        MessageBox.Show(txt_userName.Text + " was added successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                AccountControl accountControl = new AccountControl();
                CommonMethod.showControl(accountControl, ContentPanel);
                con.Close();
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            AccountControl accountControl = new AccountControl();
            CommonMethod.showControl(accountControl, ContentPanel);
        }
    }
}
