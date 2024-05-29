using CRPGarments.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPGarments
{
    public partial class HomeControl : UserControl
    {
        private readonly static ConnectionString con = new ConnectionString();
        string imgLoc = "";
        public HomeControl()
        {
            InitializeComponent();
        }

        private void btn_gallery1_Click(object sender, EventArgs e)
        {
            openFileDialog();
            updateGallery(1);
            pictureBox1.ImageLocation = imgLoc;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btn_gallery2_Click(object sender, EventArgs e)
        {
            openFileDialog();
            updateGallery(2);
            pictureBox1.ImageLocation = imgLoc;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btn_gallery3_Click(object sender, EventArgs e)
        {
            openFileDialog();
            updateGallery(3);
            pictureBox1.ImageLocation = imgLoc;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btn_gallery6_Click(object sender, EventArgs e)
        {
            openFileDialog();
            updateGallery(6);
            pictureBox1.ImageLocation = imgLoc;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_gallery5_Click(object sender, EventArgs e)
        {
            openFileDialog();
            updateGallery(5);
            pictureBox1.ImageLocation = imgLoc;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_gallery4_Click(object sender, EventArgs e)
        {
            openFileDialog();
            updateGallery(4);
            pictureBox1.ImageLocation = imgLoc;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void updateGallery(int galleryId)
        {
            con.Open();
            string path = SessionStrings.filePath + "\\" + Path.GetFileName(imgLoc);
            string updateQuery = "Update Gallery SET ImagePath = '" + path + "', ModifiedBy = '"+SessionStrings.username+"', ModifiedDate = '"+ DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE GalleryId = '" + galleryId + "'";
            con.ExecuteNonQuery(updateQuery);
            con.Close();
            if (!File.Exists(path))
            {
                File.Copy(imgLoc, path, true);
            }
        }

        private void openFileDialog()
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * from Gallery";
            SqlDataReader sdr = con.ExecuteReader(query);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    string tempGalleryId = sdr[0].ToString();
                    switch (tempGalleryId)
                    {
                        case "1":
                            pictureBox1.ImageLocation = sdr[1].ToString();
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "2":
                            pictureBox2.ImageLocation = sdr[1].ToString();
                            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "3":
                            pictureBox3.ImageLocation = sdr[1].ToString();
                            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "4":
                            pictureBox4.ImageLocation = sdr[1].ToString();
                            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "5":
                            pictureBox5.ImageLocation = sdr[1].ToString();
                            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "6":
                            pictureBox6.ImageLocation = sdr[1].ToString();
                            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        default:
                            break;
                    }
                }
                sdr.Close();
            }
            else
            {
                string sql = "";
                for (int i = 0; i < 7; i++)
                {
                    sql = sql + '\n' + "INSERT INTO Gallery VALUES ('C:\\CRPGarments\\CRP-Logo.jpg', '" + SessionStrings.username + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                }
                sdr.Close();
                con.ExecuteNonQuery(sql);
            }           
            con.Close();
        }
    }
    
}
