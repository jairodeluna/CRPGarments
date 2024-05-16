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
    public partial class RetailersControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        AddRetailersControl addRetailersControl = new AddRetailersControl();
        public RetailersControl()
        {
            InitializeComponent();
        }

        private void btn_addRetailers_Click(object sender, EventArgs e)
        {
            CommonMethod.showControl(addRetailersControl, ContentPanel);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            displayData(txt_search.Text);
        }
        public static DataTable searchRetail(string search)
        {
            con.Open();
            string query = null;
            if (search == "")
            {
                query = "SELECT RetailerNo, FirstName + '' + LastName as FullName, ContactNumber, Address, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM RetailerInformation ORDER BY CreatedDate desc";
            }
            else
            {
                query = "SELECT RetailerNo, FirstName + '' + LastName as FullName, ContactNumber, Address, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM RetailerInformation WHERE RetailerNos LIKE '%" + search + "%' OR FirstName LIKE '%" + search + "%' OR LastName LIKE '%" + search + "%' OR Category LIKE '%" + search + "%' OR Status LIKE '%" + search + "%' OR Address LIKE '%" + search + "%' OR ModifiedBy LIKE '%" + search + "%' OR ModifiedDate LIKE '%" + search + "%' OR CreatedBy LIKE '%" + search + "%' OR CreatedDate LIKE '%" + search + "%' ORDER BY CreatedDate desc";
            }
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }

        private void displayData(string search)
        {
            retailersDataGridView.Rows.Clear();
            DataTable dataTable = searchRetail(search);

            foreach (DataRow row in dataTable.Rows)
            {
                retailersDataGridView.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString().ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString() + "/" + row[7].ToString(), row[8].ToString() + "/" + row[9].ToString());
            }
        }

        private void RetailersControl_Load(object sender, EventArgs e)
        {
            displayData("");
        }

        private void retailersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult message;
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            SessionStrings.sessionId = retailersDataGridView.Rows[currentRow].Cells[0].Value.ToString();
            if (currentColumnIndex == 8)
            {
                SessionStrings.processType = "Update";
                CommonMethod.showControl(addRetailersControl, ContentPanel);
            }
            else if (currentColumnIndex == 9)
            {
                message = MessageBox.Show("Are you sure you want to delete this retailer partner?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (message == DialogResult.Yes)
                {
                    con.Open();
                    string deleteQuery = "DELETE RetailerInformation WHERE RetailerNo = '" + SessionStrings.sessionId + "'";
                    con.ExecuteNonQuery(deleteQuery);
                    MessageBox.Show("Retailer partner was deleted successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
            displayData("");
        }
    }
}
