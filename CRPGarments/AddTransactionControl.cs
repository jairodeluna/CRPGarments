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
    public partial class AddTransactionControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        private string filePath;
        public AddTransactionControl()
        {
            InitializeComponent();
        }
        private void AddTransactionControl_Load(object sender, EventArgs e)
        {
            lbl_noOfStocks.Visible = false;
            txt_amount.Enabled = false;
            loadProducts();
            if (SessionStrings.processType == "Update")
            {
                con.Open();
                string query = "SELECT TransactionNo, ImagePath, ProductName, Size, Quantity, Status, Amount, Category FROM OverallTransaction WHERE TransactionNo = '" + SessionStrings.sessionId + "'";
                SqlDataReader sdr = con.ExecuteReader(query);
                if (sdr.Read())
                {
                    filePath = sdr.GetString(1);
                    pic_item.ImageLocation = filePath;
                    pic_item.SizeMode = PictureBoxSizeMode.StretchImage;
                    cmb_productName.SelectedItem = sdr.GetString(2);
                    loadCategory();
                    loadSizes();
                    cmb_size.SelectedItem = sdr.GetString(3);
                    txt_quantity.Text = sdr.GetInt32(4).ToString();
                    loadAmount();
                    txt_status.Text = sdr.GetString(5);
                    txt_amount.Text = sdr.GetInt64(6).ToString();
                    cmb_category.SelectedItem = sdr.GetString(7);
                }
                sdr.Close();
                con.Close();
            }
            else
            {
                cmb_category.SelectedIndex = -1;
                filePath = null;
                pic_item.ImageLocation = filePath;
                pic_item.SizeMode = PictureBoxSizeMode.StretchImage;
                cmb_productName.SelectedIndex = -1;
                cmb_size.SelectedIndex = -1;
                txt_quantity.Text = "";
                txt_status.Text = "";
                txt_amount.Text = "";
            }
        }
        private void btn_saveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_productName.SelectedIndex < 0 || cmb_category.SelectedIndex < 0 || cmb_size.SelectedIndex < 0 || txt_quantity.Text == "" || txt_status.Text == "")
                {
                    MessageBox.Show("Please fill up the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    int noOfStocks = 0;
                    string imagePath = "";
                    string productsStocksQuery = "select NoOfStocks, ImagePath from Products where ProductName = '" + cmb_productName.SelectedItem+ "' AND Size = '" + cmb_size.SelectedItem + "' AND Status !='Out of Stocks'";
                    SqlDataReader sdr = con.ExecuteReader(productsStocksQuery);
                    if (sdr.Read())
                    {
                        noOfStocks = sdr.GetInt32(0);
                        imagePath = sdr.GetString(1);
                    }
                    sdr.Close();
                    int transactionQuantity = 0;
                    string transactionQuantityQuery = "select Quantity from OverallTransaction where ProductName = '" + cmb_productName.SelectedItem + "' AND Size = '" + cmb_size.SelectedItem + "'";
                    SqlDataReader sdr1 = con.ExecuteReader(transactionQuantityQuery);
                    while (sdr1.Read())
                    {
                        transactionQuantity = transactionQuantity + sdr1.GetInt32(0);
                    }
                    sdr1.Close();
                    int result = noOfStocks - (transactionQuantity + Convert.ToInt32(txt_quantity.Text));
                    if (result >= 0)
                    {
                        string sql = "INSERT INTO OverallTransaction VALUES ('" + imagePath + "', '" + cmb_productName.SelectedItem + "', '" + cmb_size.SelectedItem + "', '" + txt_quantity.Text + "', '" + txt_amount.Text + "', '" + txt_status.Text + "', '"+cmb_category.SelectedItem+"', '" + SessionStrings.username + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + SessionStrings.username + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        con.ExecuteNonQuery(sql);
                        MessageBox.Show("Transaction was successfully added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TransactionControl transactionControl = new TransactionControl();
                        CommonMethod.showControl(transactionControl, ContentPanel);
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            TransactionControl transactionControl = new TransactionControl();
            CommonMethod.showControl(transactionControl, ContentPanel);
        }

        private void cmb_productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCategory();
            loadSizes();
        }

        private void loadProducts()
        {
            con.Open();
            string query = "select DISTINCT ProductName from Products where Status !='Out of Stocks'";
            SqlDataReader sdr = con.ExecuteReader(query);
            while (sdr.Read())
            {
                cmb_productName.Items.Add(sdr.GetString(0));
            }
            sdr.Close();
            con.Close();
        }

        private void loadCategory()
        {
            con.Open();
            string query = "select DISTINCT Category from Products where ProductName = '" + cmb_productName.SelectedItem+"'";
            SqlDataReader sdr = con.ExecuteReader(query);
            while (sdr.Read())
            {
                cmb_category.Items.Add(sdr.GetString(0));
            }
            sdr.Close();
            con.Close();
        }
        private void loadSizes()
        {
            con.Open();
            string query = "select DISTINCT Size from Products where ProductName = '" + cmb_productName.SelectedItem + "'";
            SqlDataReader sdr = con.ExecuteReader(query);
            while (sdr.Read())
            {
                cmb_size.Items.Add(sdr.GetString(0));
            }
            sdr.Close();
            con.Close();
        }

        private void loadAmount()
        {
            if (txt_quantity.Text != "")
            {
                con.Open();
                string query = "select Price, ImagePath, NoOfStocks from Products where ProductName = '" + cmb_productName.SelectedItem + "' AND Size = '" + cmb_size.SelectedItem + "'";
                SqlDataReader sdr = con.ExecuteReader(query);
                if (sdr.Read())
                {
                    long price = sdr.GetInt64(0);
                    txt_amount.Text = (Convert.ToInt64(txt_quantity.Text) * price).ToString();
                    filePath = sdr.GetString(1);
                    lbl_noOfStocks.Visible = true;
                    lbl_noOfStocks.Text = "No of Stocks: " + sdr.GetInt32(2).ToString();
                    pic_item.ImageLocation = filePath;
                    pic_item.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                sdr.Close();
                con.Close();
            }
        }

        private void cmb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAmount();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            loadAmount();
        }
    }
}
