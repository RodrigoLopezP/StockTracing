using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracing
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FrmSalesList frm = new FrmSalesList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCostumerList frm = new FrmCostumerList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductList frm = new FrmProductList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            FrmAddStock frm = new FrmAddStock();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategoryList frm = new FrmCategoryList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            FrmDeleted frm = new FrmDeleted();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            stlblName.Text = "Username: "+UserStatic.username;
            stlblPermission.Text ="Permission: "+ UserStatic.permissionName;
            if (UserStatic.isAdmin)
            {
                stlblIsAdmin.Text = "ADMIN";
            }
            else
            { 
                btnCustomer.Hide();
                btnProduct.Hide();
                btnSales.Hide();
                btnAddStock.Hide();
                btnCategory.Hide();
                btnDeleted.Hide();
                btnUsers.Hide();
                switch (UserStatic.permissionID)
                {
                    default:
                        break;
                    case 1://vendendor
                        btnSales.Visible = true;
                        btnSales.Location= new Point(12, 12);
                        break;
                    case 2://reponedor
                        btnCategory.Visible = true;
                        btnProduct.Visible = true;
                        btnAddStock.Visible = true;

                        btnCategory.Location =  new Point(12, 12);
                        btnProduct.Location  =  new Point(140, 12);
                        btnAddStock.Location =  new Point(270, 12);
                        break;
                    case 3://comercial
                        btnCustomer.Visible = true;
                        btnProduct.Visible = true;

                        btnCustomer.Location = new Point(12, 12);
                        btnProduct.Location = new Point(140, 12);
                        
                        break;
                    case 4://Recursos humanos
                        btnUsers.Visible = true;
                        btnUsers.Location = new Point(12, 12);
                        break;
                }
            }


        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUserList frm = new FrmUserList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
