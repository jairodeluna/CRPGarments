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
    public partial class TransactionControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        AddTransactionControl addTransactionControl = new AddTransactionControl();
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void btn_addTransaction_Click(object sender, EventArgs e)
        {
            CommonMethod.showControl(addTransactionControl, ContentPanel);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            displayData(txt_search.Text);
        }

        public static DataTable searchTransaction(string search)
        {
            con.Open();
            string query = null;
            if (search == "")
            {
                query = "SELECT TransactionNo, ImagePath, ProductName, Size, Quantity, Amount, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM OverallTransaction WHERE CreatedDate = '" + DateTime.Now.ToString("yyyy-MM-dd")+"' ORDER BY CreatedDate desc";
            }
            else
            {
                query = "SELECT TransactionNo, ImagePath, ProductName, Size, Quantity, Amount, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM Products WHERE CreatedDate = '" + DateTime.Now.ToString("yyyy-MM-dd")+"' AND TransactionNo LIKE '%" + search + "%' OR ProductName LIKE '%" + search + "%' OR Size LIKE '%" + search + "%' OR Category LIKE '%" + search + "%' OR ModifiedBy LIKE '%" + search + "%' OR ModifiedDate LIKE '%" + search + "%' OR CreatedBy LIKE '%" + search + "%' OR CreatedDate LIKE '%" + search + "%' ORDER BY CreatedDate desc";
            }
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }

        private void displayData(string search)
        {
            transactionDataGridView.Rows.Clear();
            transactionDataGridView.RowTemplate.Height = 60;
            DataTable dataTable = searchTransaction(search);

            foreach (DataRow row in dataTable.Rows)
            {
                transactionDataGridView.Rows.Add(row[0].ToString(), Bitmap.FromFile(row[1].ToString()), row[2].ToString().ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString() + "/" + row[9].ToString(), row[10].ToString() + "/" + row[11].ToString());
            }
        }

        private void TransactionControl_Load(object sender, EventArgs e)
        {
            displayData("");
        }

        private void transactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult message;
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            SessionStrings.sessionId = transactionDataGridView.Rows[currentRow].Cells[0].Value.ToString();
            if (currentColumnIndex == 10)
            {
                SessionStrings.processType = "Update";
                CommonMethod.showControl(addTransactionControl, ContentPanel);
            }
            else if (currentColumnIndex == 11)
            {
                message = MessageBox.Show("Are you sure you want to delete this transaction?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (message == DialogResult.Yes)
                {
                    con.Open();
                    string deleteQuery = "DELETE OverallTransaction WHERE TransactionNo = '" + SessionStrings.sessionId + "'";
                    con.ExecuteNonQuery(deleteQuery);
                    MessageBox.Show("Transaction was deleted successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
            displayData("");
        }
    }
}
