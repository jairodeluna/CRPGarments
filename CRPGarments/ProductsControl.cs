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
    public partial class ProductsControl : UserControl
    {
        private static readonly ConnectionString con = new ConnectionString();
        AddProductControl addProductControl = new AddProductControl();
        public ProductsControl()
        {
            InitializeComponent();
        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {
            displayData("");
            loadCategory();
            loadStatus();
        }

        private void btn_addProducts_Click(object sender, EventArgs e)
        {
            SessionStrings.processType = "Add Products";
            CommonMethod.showControl(addProductControl, ContentPanel);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            displayData(txt_search.Text);
        }

        public static DataTable searchProducts(string search)
        {
            con.Open();
            string query = null;
            if (search == "")
            {
                query = "SELECT ProductId, ImagePath, ProductName, Size, NoOfStocks, Price, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM Products";
            }
            else
            {
                query = "SELECT ProductId, ImagePath, ProductName, Size, NoOfStocks, Price, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM Products WHERE ProductId LIKE '%" + search + "%' OR ProductName LIKE '%" + search + "%' OR Size LIKE '%" + search + "%' OR Price LIKE '%" + search + "%' OR Category LIKE '%" + search + "%' OR ModifiedBy LIKE '%" + search + "%' OR ModifiedDate LIKE '%" + search + "%' OR CreatedBy LIKE '%" + search + "%' OR ModifiedDate LIKE '%" + search + "%' ORDER BY CreatedDate desc";
            }
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }

        private void displayData(string search)
        {
            productsDataGridView.Rows.Clear();
            productsDataGridView.RowTemplate.Height = 60;
            DataTable dataTable = searchProducts(search);

            foreach (DataRow row in dataTable.Rows)
            {
                productsDataGridView.Rows.Add(row[0].ToString(), Bitmap.FromFile(row[1].ToString()), row[2].ToString().ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString() + "/" + row[9].ToString(), row[10].ToString() + "/" + row[11].ToString());
            }
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult message;
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            SessionStrings.sessionId = productsDataGridView.Rows[currentRow].Cells[0].Value.ToString();
            if (currentColumnIndex == 10)
            {
                SessionStrings.processType = "Update";
                CommonMethod.showControl(addProductControl, ContentPanel);
            }
            else if (currentColumnIndex == 11)
            {
                message = MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (message == DialogResult.Yes)
                {
                    con.Open();
                    string deleteQuery = "DELETE Products WHERE ProductId = '" + SessionStrings.sessionId + "'";
                    con.ExecuteNonQuery(deleteQuery);
                    MessageBox.Show("Product was deleted successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
            displayData("");
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            con.Open();
            if (cmb_filterCategory.SelectedIndex >= 0) 
            {
                string status = string.Empty;
                if (cmb_filterStatus.SelectedIndex >= 0) { status = cmb_filterStatus.SelectedItem.ToString(); }
                filterData(cmb_filterCategory.SelectedItem.ToString(), status);
            }
            else
            {
                MessageBox.Show("Please select a category first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable filterProducts(string category, string status = "")
        {
            con.Open();
            string query = null;
            if (status != "")
            {
                query = "SELECT ProductId, ImagePath, ProductName, Size, NoOfStocks, Price, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM Products WHERE Category = '" + category + "' AND Status = '"+status+"'";
            }
            else
            {
                query = "SELECT ProductId, ImagePath, ProductName, Size, NoOfStocks, Price, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM Products WHERE Category = '" + category + "'";
            }
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }
       
        private void filterData(string category, string status = "")
        {
            productsDataGridView.Rows.Clear();
            productsDataGridView.RowTemplate.Height = 60;
            DataTable dataTable = filterProducts(category, status);

            foreach (DataRow row in dataTable.Rows)
            {
                productsDataGridView.Rows.Add(row[0].ToString(), Bitmap.FromFile(row[1].ToString()), row[2].ToString().ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString() + "/" + row[9].ToString(), row[10].ToString() + "/" + row[11].ToString());
            }
        }
        private void loadCategory()
        {
            con.Open();
            string query = "select DISTINCT Category from Products";
            SqlDataReader sdr = con.ExecuteReader(query);
            while (sdr.Read())
            {
                cmb_filterCategory.Items.Add(sdr.GetString(0));
            }
            sdr.Close();
            con.Close();
        }
        private void loadStatus()
        {
            con.Open();
            string query = "select DISTINCT Status from Products";
            SqlDataReader sdr = con.ExecuteReader(query);
            while (sdr.Read())
            {
                cmb_filterStatus.Items.Add(sdr.GetString(0));
            }
            sdr.Close();
            con.Close();
        }
    }
}
