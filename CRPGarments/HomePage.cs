using CRPGarments.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPGarments
{
    public partial class HomePage : Form
    {
        private static readonly ConnectionString con = new ConnectionString();
        bool isUserAccountPanel = false;
        HomeControl homeControl = new HomeControl();
        TransactionControl transactionControl = new TransactionControl();
        ProductsControl productsControl = new ProductsControl();
        RetailersControl retailersControl = new RetailersControl();
        ReportControl reportControl = new ReportControl();
        AccountControl accountControl = new AccountControl();
        public HomePage()
        {
            InitializeComponent();
        }

        private void lbl_homeMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            homePanel.BackColor = Color.Snow;
            lbl_homeMenu.ForeColor = Color.Black;
            CommonMethod.showControl(homeControl, ContentPanel);
        }

        private void lbl_transactionMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            transactionPanel.BackColor = Color.Snow;
            lbl_transactionMenu.ForeColor = Color.Black;
            CommonMethod.showControl(transactionControl, ContentPanel);
        }

        private void lbl_productsMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            productsPanel.BackColor = Color.Snow;
            lbl_productsMenu.ForeColor = Color.Black;
            CommonMethod.showControl(productsControl, ContentPanel);
        }

        private void lbl_retailersMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            retailersPanel.BackColor = Color.Snow;
            lbl_retailersMenu.ForeColor = Color.Black;
            CommonMethod.showControl(retailersControl, ContentPanel);
        }

        private void lbl_reportMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            reportPanel.BackColor = Color.Snow;
            lbl_reportMenu.ForeColor = Color.Black;
            CommonMethod.showControl(reportControl, ContentPanel);
        }

        private void btn_userSettings_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            if (isUserAccountPanel)
            {
                userAccountPanel.Hide();
                isUserAccountPanel = false;
            }
            else
            {
                userAccountPanel.Show();
                isUserAccountPanel = true;
            }
        }

        private void defaultBackcolor()
        {
            homePanel.BackColor = Color.DarkSlateBlue;
            transactionPanel.BackColor = Color.DarkSlateBlue;
            productsPanel.BackColor = Color.DarkSlateBlue;
            retailersPanel.BackColor = Color.DarkSlateBlue;
            reportPanel.BackColor = Color.DarkSlateBlue;
            lbl_homeMenu.ForeColor = Color.White;
            lbl_transactionMenu.ForeColor = Color.White;
            lbl_productsMenu.ForeColor = Color.White;
            lbl_retailersMenu.ForeColor = Color.White;
            lbl_reportMenu.ForeColor = Color.White;
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            userAccountPanel.Hide();
            if(SessionStrings.userType == "admin")
            {
                lbl_accountManagement.Visible = true;
                lbl_accountManagement.Location = new Point(31, 2);
                lbl_changePassword.Location = new Point(33, 31);
                lbl_logout.Location = new Point(31, 56);
            }
            else
            {
                lbl_accountManagement.Visible = false;
                lbl_changePassword.Location = new Point(33, 16);
                lbl_logout.Location = new Point(31, 47);
            }
            lbl_userDisplay.Text = SessionStrings.lastName + ", " + SessionStrings.firstName;
            defaultBackcolor();
            homePanel.BackColor = Color.Snow;
            lbl_homeMenu.ForeColor = Color.Black;
            CommonMethod.showControl(homeControl, ContentPanel);
        }

        private void lbl_accountManagement_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            CommonMethod.showControl(accountControl, ContentPanel);
            userAccountPanel.Hide();
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pic_homeMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            homePanel.BackColor = Color.Snow;
            lbl_homeMenu.ForeColor = Color.Black;
            CommonMethod.showControl(homeControl, ContentPanel);
        }

        private void pic_transactionMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            transactionPanel.BackColor = Color.Snow;
            lbl_transactionMenu.ForeColor = Color.Black;
            CommonMethod.showControl(transactionControl, ContentPanel);
        }

        private void pic_productsMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            productsPanel.BackColor = Color.Snow;
            lbl_productsMenu.ForeColor = Color.Black;
            CommonMethod.showControl(productsControl, ContentPanel);
        }

        private void pic_retailersMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            retailersPanel.BackColor = Color.Snow;
            lbl_retailersMenu.ForeColor = Color.Black;
            CommonMethod.showControl(retailersControl, ContentPanel);
        }

        private void pic_reportMenu_Click(object sender, EventArgs e)
        {
            defaultBackcolor();
            reportPanel.BackColor = Color.Snow;
            lbl_reportMenu.ForeColor = Color.Black;
            CommonMethod.showControl(reportControl, ContentPanel);
        }

        private void lbl_changePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
    }
}
