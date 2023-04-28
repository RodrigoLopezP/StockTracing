using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTracing.BLL;
using StockTracing.DAL.DTO;
namespace StockTracing
{
    public partial class FrmDeleted : Form
    {
        SalesBLL salesBll= new SalesBLL();
        CategoryBLL catBll = new CategoryBLL();
        ProductBLL prodBll = new ProductBLL();
        CustomerBLL custBll = new CustomerBLL();
        UserBLL userBLL = new UserBLL();
        SalesDTO isDeletedDto = new SalesDTO();

        CategoryDetailDTO categorySelected = new CategoryDetailDTO();
        CustomerDetailDTO customerSelected = new CustomerDetailDTO();
        ProductDetailDTO productSelected = new ProductDetailDTO();
        SalesDetailDTO saleSelected = new SalesDetailDTO();
        UserDetailDTO userSelected = new UserDetailDTO();
        public FrmDeleted()
        {
            InitializeComponent();
        }


         private void FrmDeleted_Load(object sender, EventArgs e)
        {
            cmbDeleteData.Items.Add("Category");
            cmbDeleteData.Items.Add("Product");
            cmbDeleteData.Items.Add("Customer");
            cmbDeleteData.Items.Add("Sales");
            cmbDeleteData.Items.Add("Users");

            isDeletedDto = salesBll.Select(true);
        }

        private void cmbDeleteData_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (cmbDeleteData.SelectedIndex == 0)//Category
            {
                dataGridView1.DataSource = isDeletedDto.Category;
                dataGridView1.Columns[0].Visible = false; //category ID
                dataGridView1.Columns[1].HeaderText = "Category Name";
            }
            if (cmbDeleteData.SelectedIndex == 1)//Product
            {
                dataGridView1.DataSource = isDeletedDto.Products;
                dataGridView1.Columns[0].HeaderText = "Product";
                dataGridView1.Columns[1].HeaderText = "Category";
                dataGridView1.Columns[2].HeaderText = "Stock Amount";
                dataGridView1.Columns[3].HeaderText = "Price";
                dataGridView1.Columns[4].Visible = false; //prod id
                dataGridView1.Columns[5].Visible = false; // cat id
                dataGridView1.Columns[6].HeaderText= "Category deleted";  //Sales ID

            }
            if (cmbDeleteData.SelectedIndex == 2)//Customer
            {
                dataGridView1.DataSource = isDeletedDto.Customer;
                dataGridView1.Columns[0].Visible = false;  // Customer ID
                dataGridView1.Columns[1].HeaderText = "Customer Name";
            }
            if (cmbDeleteData.SelectedIndex == 3)//Sales
            {
                dataGridView1.DataSource = isDeletedDto.Sales;
                dataGridView1.Columns[3].Visible = false;   //CustomerID
                dataGridView1.Columns[4].Visible = false;   //ProductID
                dataGridView1.Columns[5].Visible = false;   // CategoryID
                dataGridView1.Columns[10].Visible = false;  //Sales ID

                dataGridView1.Columns[0].HeaderText = "Customer";
                dataGridView1.Columns[1].HeaderText = "Product";
                dataGridView1.Columns[2].HeaderText = "Category";
                dataGridView1.Columns[6].HeaderText = "Sales Amount";
                dataGridView1.Columns[7].HeaderText = "Price";
                dataGridView1.Columns[8].HeaderText = "Sale Date";
                dataGridView1.Columns[9].HeaderText = "Stock Amount";
                dataGridView1.Columns[11].HeaderText = "Product deleted";
                dataGridView1.Columns[12].HeaderText = "Category deleted";
                dataGridView1.Columns[13].HeaderText = "Customer deleted";
            }
            if (cmbDeleteData.SelectedIndex == 4)
            {
                dataGridView1.DataSource = isDeletedDto.Users;
                dataGridView1.Columns[0].Visible = false; //User ID
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].Visible = false; //User Password
                dataGridView1.Columns[3].HeaderText = "Admin";
                dataGridView1.Columns[4].Visible = false; //Permission ID
                dataGridView1.Columns[5].HeaderText = "Permission";
                dataGridView1.Columns[6].HeaderText = "Deleted";//Is deleted
                dataGridView1.Columns[7].HeaderText = "Deleted Date";//Is deleted
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            switch (cmbDeleteData.SelectedIndex)
            {
                default:
                    break;
                case 0: //Category
                    categorySelected.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    break;
                case 1: //Product
                    productSelected.productID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    productSelected.categoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    productSelected.isCategoryDeleted= Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                    break;
                case 2://Customer
                    customerSelected.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    break;
                case 3://Sales
                    saleSelected.SalesID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                    saleSelected.CustomerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    saleSelected.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    saleSelected.SalesAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                    saleSelected.StockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                    saleSelected.isProductDeleted= Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
                    saleSelected.isCategoryDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
                    saleSelected.isCustomerDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
                    break;
                case 4://Users
                    userSelected.UserId= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    break;
            }
        }

        private void btnGetBack_Click(object sender, EventArgs e)
        {
            if (cmbDeleteData.SelectedIndex == -1)
            {
                MessageBox.Show("No row was selected","WARNING");
            }
            else
            {
                DialogResult wndConfirm = MessageBox.Show("Get back this element?","WARNING",MessageBoxButtons.YesNo);
                if (wndConfirm == DialogResult.Yes)
                {
                    switch (cmbDeleteData.SelectedIndex)
                    {
                        case 0: //Category
                            if (catBll.GetBack(categorySelected))
                            {
                                MessageBox.Show("Category restored", "OK", MessageBoxButtons.OK);
                            }
                            break;
                        case 1: //Product
                            if (productSelected.isCategoryDeleted)
                            {
                                MessageBox.Show("Product can't be restored. Category was deleted", "DENIED", MessageBoxButtons.OK);
                            }
                            else if (prodBll.GetBack(productSelected))
                            {
                                MessageBox.Show("Product restored", "OK", MessageBoxButtons.OK);
                            }
                            break;
                        case 2://Customer
                            if (custBll.GetBack(customerSelected))
                            {
                                MessageBox.Show("Customer restored", "OK",MessageBoxButtons.OK);
                            }
                            break;
                        case 3://Sales
                            if (saleSelected.isCategoryDeleted)
                            {
                                MessageBox.Show("Sale can't be restored. Category was deleted", "DENIED", MessageBoxButtons.OK);
                            }
                            else if (saleSelected.isProductDeleted)
                            {
                                MessageBox.Show("Sale can't be restored. Product was deleted", "DENIED", MessageBoxButtons.OK);
                            }
                            else if (saleSelected.isCustomerDeleted)
                            {
                                MessageBox.Show("Sale can't be restored. Customer was deleted", "DENIED", MessageBoxButtons.OK);
                            }
                            else if (salesBll.GetBack(saleSelected))
                            {
                                MessageBox.Show("Sale restored", "OK", MessageBoxButtons.OK);
                            }
                            break;
                        case 4://Users
                            if (userBLL.GetBack(userSelected))
                            {
                                MessageBox.Show("User restored", "OK", MessageBoxButtons.OK);
                            }
                            break;
                    }
                    refreshGrid();
                }
            }
        }

        void refreshGrid()
        {
            SalesBLL salesBllUpdated = new SalesBLL();
            isDeletedDto = salesBll.Select(true);

            if (cmbDeleteData.SelectedIndex == 0)//Category
            {
                dataGridView1.DataSource = isDeletedDto.Category;
            }
            if (cmbDeleteData.SelectedIndex == 1)//Product
            {
                dataGridView1.DataSource = isDeletedDto.Products;
            }
            if (cmbDeleteData.SelectedIndex == 2)//Customer
            {
                dataGridView1.DataSource = isDeletedDto.Customer;
            }
            if (cmbDeleteData.SelectedIndex == 3)//Sales
            {
                dataGridView1.DataSource = isDeletedDto.Sales;
            }
            if (cmbDeleteData.SelectedIndex == 4)//Sales
            {
                dataGridView1.DataSource = isDeletedDto.Users;
            }
        }
    }
}
