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
    public partial class AddRetailersControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        public AddRetailersControl()
        {
            InitializeComponent();
        }

        private void btn_addRetailers_Click(object sender, EventArgs e)
        {
            if (txt_lastName.Text == "" || txt_firstName.Text == "" || txt_contactNumber.Text == "" || txt_address.Text == "" || txt_category.Text == "" || txt_status.Text == "")
            {
                MessageBox.Show("Please fill up the necessary details.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                if (SessionStrings.processType == "Update")
                {
                    string updateQuery = "Update RetailerInformation SET LastName = '" + txt_lastName.Text + "', FirstName = '" + txt_firstName.Text + "', ContactNumber = '" + txt_contactNumber.Text + "', Address = '" + txt_address.Text + "',  Status = '" + txt_status.Text + "',  Category = '" + txt_category.Text + "', ModifiedBy = '" + SessionStrings.username + "', ModifiedDate = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE RetailerNo = '" + SessionStrings.sessionId + "'";
                    con.ExecuteNonQuery(updateQuery);
                    MessageBox.Show("Retailer partner updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string validateQuery = "SELECT * FROM RetailerInformation WHERE LastName = '" + txt_lastName.Text + "' AND FirstName = '" + txt_firstName.Text + "'";
                    SqlDataReader sdr = con.ExecuteReader(validateQuery);
                    if (sdr.Read())
                    {
                        MessageBox.Show("Retailer partner already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sdr.Close();
                        string insertQuery = "Insert into RetailerInformation values('" + txt_lastName.Text + "', '" + txt_firstName.Text + "', '" + txt_contactNumber.Text + "', '" + txt_address.Text + "', '" + txt_status.Text + "', '" + txt_category.Text + "', '" + SessionStrings.username + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + SessionStrings.username + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        con.ExecuteNonQuery(insertQuery);
                        MessageBox.Show("Retailer partner was added successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    RetailersControl retailersControl = new RetailersControl();
                    CommonMethod.showControl(retailersControl, ContentPanel);
                }
                con.Close();
            }        
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            RetailersControl retailersControl = new RetailersControl();
            CommonMethod.showControl(retailersControl, ContentPanel);
        }

        private void AddRetailersControl_Load(object sender, EventArgs e)
        {
            if (SessionStrings.processType == "Update")
            {
                con.Open();
                string query = "SELECT LastName, FirstName, ContactNumber, Address, Status, Category FROM RetailerInformation WHERE RetailerNo = '" + SessionStrings.sessionId + "'";
                SqlDataReader sdr = con.ExecuteReader(query);
                if (sdr.Read())
                {
                    txt_lastName.Text = sdr.GetString(0);
                    txt_firstName.Text = sdr.GetString(1);
                    txt_contactNumber.Text = sdr.GetString(2);
                    txt_address.Text = sdr.GetString(3);
                    txt_status.Text = sdr.GetString(4);
                    txt_category.Text = sdr.GetString(5);
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
                txt_status.Text = "";
                txt_category.Text = "";
            }
        }
    }
}
