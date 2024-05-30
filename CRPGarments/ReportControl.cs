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
    public partial class ReportControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        public ReportControl()
        {
            InitializeComponent();
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            displayData("");
            displayTotalAmount(Convert.ToDateTime("2000-01-01"), Convert.ToDateTime("3000-01-01"));
        }

        public static DataTable searchReport(string search)
        {
            con.Open();
            string query = null;
            if (search == "")
            {
                query = "SELECT TransactionNo, ImagePath, ProductName, Size, Quantity,  Amount, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM OverallTransaction ORDER BY CreatedDate desc";
            }
            else
            {
                query = "SELECT TransactionNo, ImagePath, ProductName, Size, Quantity, Amount, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM OverallTransaction WHERE TransactionNo LIKE '%" + search + "%' OR ProductName LIKE '%" + search + "%' OR Size LIKE '%" + search + "%' OR Category LIKE '%" + search + "%' OR ModifiedBy LIKE '%" + search + "%' OR ModifiedDate LIKE '%" + search + "%' OR CreatedBy LIKE '%" + search + "%' OR CreatedDate LIKE '%" + search + "%' ORDER BY CreatedDate desc";
            }
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }

        private void displayData(string search)
        {
            transactionDataGridView.Rows.Clear();
            transactionDataGridView.RowTemplate.Height = 60;
            DataTable dataTable = searchReport(search);

            foreach (DataRow row in dataTable.Rows)
            {
                transactionDataGridView.Rows.Add(row[0].ToString(), Bitmap.FromFile(row[1].ToString()), row[2].ToString().ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString() + "/" + row[9].ToString(), row[10].ToString() + "/" + row[11].ToString());
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            displayDataUsingDate(dateFromTimePicker.Value, dateToTimePicker.Value);
        }

        public static DataTable searchReportUsingDate(DateTime dateFrom, DateTime dateTo)
        {
            con.Open();
            string query = "SELECT TransactionNo, ImagePath, ProductName, Size, Quantity, Amount, Status, Category, ModifiedBy, ModifiedDate, CreatedBy, CreatedDate FROM OverallTransaction WHERE CreatedDate >= '" + dateFrom.ToString("yyyy-MM-dd") + "' AND CreatedDate <= '" + dateTo.ToString("yyyy-MM-dd") + "' ORDER BY CreatedDate desc";
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }

        private void displayDataUsingDate(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            transactionDataGridView.Rows.Clear();
            transactionDataGridView.RowTemplate.Height = 60;
            DataTable dataTable = searchReportUsingDate(dateTimeFrom, dateTimeTo);
            displayTotalAmount(dateTimeFrom, dateTimeTo);
            foreach (DataRow row in dataTable.Rows)
            {
                transactionDataGridView.Rows.Add(row[0].ToString(), Bitmap.FromFile(row[1].ToString()), row[2].ToString().ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString() + "/" + row[9].ToString(), row[10].ToString() + "/" + row[11].ToString());
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            displayData(txt_search.Text);
        }

        private void displayTotalAmount(DateTime dateFrom, DateTime dateTo)
        {
            con.Open();
            string reportQueryValidation = "SELECT * FROM OverallTransaction WHERE CreatedDate >= '" + dateFrom.ToString("yyyy-MM-dd") + "' AND CreatedDate <= '" + dateTo.ToString("yyyy-MM-dd") + "'";
            SqlDataReader sdr1 = con.ExecuteReader(reportQueryValidation);
            if (sdr1.Read())
            {
                sdr1.Close();
                if (dateFrom != Convert.ToDateTime("2000-01-01"))
                {
                    string reportQuery = "SELECT SUM(Amount) FROM OverallTransaction WHERE CreatedDate >= '" + dateFrom.ToString("yyyy-MM-dd") + "' AND CreatedDate <= '" + dateTo.ToString("yyyy-MM-dd") + "'";
                    SqlDataReader sdr2 = con.ExecuteReader(reportQuery);
                    if (sdr2.Read())
                    {
                        lbl_totalSalesAmountValue.Text = "Total Sales Amount: P" + sdr2.GetInt64(0).ToString();
                    }
                    sdr2.Close();
                }
                else
                {
                    string reportQuery = "SELECT SUM(Amount) FROM OverallTransaction";
                    SqlDataReader sdr = con.ExecuteReader(reportQuery);
                    if (sdr.Read())
                    {
                        lbl_totalSalesAmountValue.Text = "Total Sales Amount: P" + sdr.GetInt64(0).ToString();
                    }
                    sdr.Close();
                }
            }
            else { lbl_totalSalesAmountValue.Text = "Total Sales Amount: P0"; }
            con.Close();
        }
    }
}
