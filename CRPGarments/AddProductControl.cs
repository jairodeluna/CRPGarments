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
    public partial class AddProductControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        string imgLoc = "";
        public AddProductControl()
        {
            InitializeComponent();
        }
        private void AddProductControl_Load(object sender, EventArgs e)
        {
            loadStatus();
            loadSizes();
            if (SessionStrings.processType == "Update")
            {
                con.Open();
                string query = "SELECT Category, ImagePath, ProductName, Size, NoOfStocks, Status, Price FROM Products WHERE ProductId = '" + SessionStrings.sessionId + "'";
                SqlDataReader sdr = con.ExecuteReader(query);
                if (sdr.Read())
                {
                    txt_category.Text = sdr.GetString(0);
                    imgLoc = sdr.GetString(1);
                    pic_item.ImageLocation = imgLoc;
                    pic_item.SizeMode = PictureBoxSizeMode.StretchImage;
                    txt_imageLink.Text = imgLoc;
                    txt_productName.Text = sdr.GetString(2);
                    cmb_sizes.SelectedItem = sdr.GetString(3);
                    txt_noOfStocks.Text = sdr.GetInt32(4).ToString();
                    cmb_status.SelectedItem = sdr.GetString(5);
                    txt_price.Text = sdr.GetInt64(6).ToString();
                }
                sdr.Close();
                con.Close();
            }
            else
            {
                txt_category.Text = "";
                imgLoc = "";
                pic_item.ImageLocation = null;
                pic_item.SizeMode = PictureBoxSizeMode.StretchImage;
                txt_imageLink.Text = "";
                txt_productName.Text = "";
                cmb_sizes.SelectedIndex = -1;
                txt_noOfStocks.Text = "0";
                cmb_status.SelectedIndex = -1;
                txt_price.Text = "";
            }
        }

        private void btn_saveProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_productName.Text == "" || txt_category.Text == "" || cmb_sizes.SelectedIndex < 0 || txt_noOfStocks.Text == "" || cmb_status.SelectedIndex < 0 || txt_price.Text == "")
                {
                    MessageBox.Show("Please fill up the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query = "select ProductName from Products where ProductName = '" + txt_productName.Text + "' AND Size = '"+cmb_sizes.SelectedItem+"' AND Status !='Out of Stocks'";
                    SqlDataReader sdr = con.ExecuteReader(query);
                    if (sdr.Read())
                    {
                        MessageBox.Show("Product and it's size already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        sdr.Close();
                        string imagelink = string.IsNullOrEmpty(txt_imageLink.Text.ToString()) ? "C:\\CRPGarments\\boutique.png" : "C:\\CRPGarments\\" + Path.GetFileName(txt_imageLink.Text);
                        string path = SessionStrings.filePath + "\\" + Path.GetFileName(txt_imageLink.Text);
                        if (!File.Exists(path))
                        {
                            File.Copy(txt_imageLink.Text, path, true);
                        }
                        string sql = "INSERT INTO Products VALUES ('" + imagelink + "', '" + txt_productName.Text + "', '" + cmb_sizes.SelectedItem + "', '" + txt_noOfStocks.Text + "', '" + txt_price.Text + "', '" + cmb_status.SelectedItem + "', '" + txt_category.Text + "', '" + SessionStrings.username + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + SessionStrings.username + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        con.ExecuteNonQuery(sql);
                        MessageBox.Show(txt_productName.Text + " was successfully added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProductsControl productsControl = new ProductsControl();
                        CommonMethod.showControl(productsControl, ContentPanel);
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
            ProductsControl productsControl = new ProductsControl();
            CommonMethod.showControl(productsControl, ContentPanel);
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pic_item.ImageLocation = imgLoc;
                    pic_item.SizeMode = PictureBoxSizeMode.StretchImage;
                    txt_imageLink.Text = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadStatus()
        {
            cmb_status.Items.Add("Available");
            if (SessionStrings.processType == "Update")
            {
                cmb_status.Items.Add("Out of Stocks");
            }            
        }

        private void loadSizes()
        {
            cmb_sizes.Items.Add("Extra Small");
            cmb_sizes.Items.Add("Small");
            cmb_sizes.Items.Add("Medium");
            cmb_sizes.Items.Add("Large");
            cmb_sizes.Items.Add("Extra Large");
            cmb_sizes.Items.Add("Double XL");
            cmb_sizes.Items.Add("Triple XL");
        }

        private void txt_noOfStocks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
