using CRPGarments.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPGarments
{
    public partial class AccountControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        AddAccountControl addControl = new AddAccountControl();
        public AccountControl()
        {
            InitializeComponent();
        }

        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            CommonMethod.showControl(addControl, ContentPanel);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            displayData(txt_search.Text);
        }

        private static DataTable searchUser(string search)
        {
            con.Open();
            string query = null;
            if (search == "")
            {
                query = "SELECT AccountId, LastName + ', ' + FirstName as FullName, ContactNumber, Address, UserName FROM AccountManagement ORDER BY AccountId desc";
            }
            else
            {
                query = "SELECT AccountId, LastName + ', ' + FirstName as FullName, ContactNumber, Address, UserName FROM AccountManagement WHERE AccountId LIKE '%" + search + "%' OR LastName LIKE '%" + search + "%' OR FirstName LIKE '%" + search + "%' OR ContactNumber LIKE '%" + search + "%' OR Address LIKE '%" + search + "%' OR Username LIKE '%" + search + "%' ORDER BY AccountId desc";
            }
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }

        private void displayData(string search)
        {
            userAccountDataGridView.Rows.Clear();
            DataTable dataTable = searchUser(search);
            foreach (DataRow row in dataTable.Rows)
            {
                userAccountDataGridView.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            }
        }

        private void userAccountDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult message;
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            SessionStrings.sessionId = userAccountDataGridView.Rows[currentRow].Cells[0].Value.ToString();
            if (currentColumnIndex == 5)
            {
                SessionStrings.processType = "Update";
                CommonMethod.showControl(addControl, ContentPanel);
            }
            else if (currentColumnIndex == 6)
            {
                message = MessageBox.Show("Are you sure you want to delete this account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (message == DialogResult.Yes)
                {
                    con.Open();
                    string deleteQuery = "DELETE AccountManagement WHERE AccountId = '" + SessionStrings.sessionId + "'";
                    con.ExecuteNonQuery(deleteQuery);
                    MessageBox.Show("Account was deleted successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
            displayData("");
        }

        private void AccountControl_Load(object sender, EventArgs e)
        {
            displayData("");
        }
    }
}
