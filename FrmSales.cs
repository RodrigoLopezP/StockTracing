using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTracing.DAL.DTO;
using StockTracing.BLL;

namespace StockTracing
{
    public partial class FrmSales : Form
    {
        SalesDTO dto = new SalesDTO();
        SalesBLL bll = new SalesBLL();
        bool combofull = false;
        SalesDetailDTO saleToInsert = new SalesDetailDTO();

        public SalesDetailDTO saleToUpdate = new SalesDetailDTO();
        public bool isUpdate = false;
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            dto = bll.Select();

            if (!isUpdate)
            {
                gridProduct.DataSource = dto.Products;
                gridProduct.RowHeadersVisible = false;
                gridProduct.AllowUserToResizeColumns = false;
                gridProduct.AllowUserToResizeRows = false;
                gridProduct.Columns[0].HeaderText = "Product"; //productName
                gridProduct.Columns[1].HeaderText = "Category"; //categoryName 
                gridProduct.Columns[2].HeaderText = "Stock Amount"; //stockAmount
                gridProduct.Columns[3].HeaderText = "Price"; //price 
                gridProduct.Columns[4].Visible = false; //productID
                gridProduct.Columns[5].Visible = false;  //categoryID

                gridCustomer.DataSource = dto.Customer;
                gridCustomer.AllowUserToResizeColumns = false;
                gridCustomer.AllowUserToResizeRows = false;
                gridCustomer.RowHeadersVisible = false;
                gridCustomer.Columns[0].Visible = false;     //ID
                gridCustomer.Columns[1].HeaderText = "Name"; //Name
            }
            else{
                panel1.Hide();
                txtCustomer.Text = saleToUpdate.CustomerName;
                txtProduct.Text = saleToUpdate.ProductName;
                txtPrice.Text = saleToUpdate.Price.ToString();
                txtProductSalesAmount.Text = saleToUpdate.SalesAmount.ToString();
                txtProductStock.Text = saleToUpdate.StockAmount.ToString();
            }



            cmbCategorySearch.DataSource = dto.Category;
            cmbCategorySearch.DisplayMember = "CategoryName";
            cmbCategorySearch.ValueMember= "ID";
            cmbCategorySearch.SelectedIndex = -1;

            combofull = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dto.Sales.Count>0)
            {
                txtProduct.Text = gridProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPrice.Text = gridProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtProductStock.Text = gridProduct.Rows[e.RowIndex].Cells[2].Value.ToString();

                saleToInsert.StockAmount = Convert.ToInt32(gridProduct.Rows[e.RowIndex].Cells[2].Value);
                saleToInsert.Price = Convert.ToInt32(gridProduct.Rows[e.RowIndex].Cells[3].Value);
                saleToInsert.ProductID = Convert.ToInt32(gridProduct.Rows[e.RowIndex].Cells[4].Value);
                saleToInsert.CategoryID = Convert.ToInt32(gridProduct.Rows[e.RowIndex].Cells[5].Value);
            }
        }

        private void gridCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dto.Customer.Count > 0)
            {
                txtCustomer.Text = gridCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();

                saleToInsert.CustomerID = Convert.ToInt32(gridCustomer.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void cmbCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProductDetailDTO> list = dto.Products;

            if (combofull)
            {
                list = list.Where(x => x.categoryID == Convert.ToInt32(cmbCategorySearch.SelectedValue)).ToList();
                gridProduct.DataSource = list;
            }
            if (list.Count < 1)
            {
                txtProduct.Clear();
                txtPrice.Clear();
                txtProductStock.Clear();
            }
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dto.Customer;
            list = list.Where(x => x.Name.Contains(txtCustomerSearch.Text)).ToList();
            gridCustomer.DataSource = list;
            if (list.Count < 1)
            {
                txtCustomer.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCustomer.Text))
            {
                MessageBox.Show("Choose a customer", "HOL UP");
            }
            else if (String.IsNullOrEmpty(txtProduct.Text))
            {
                MessageBox.Show("Choose a product", "YOOO");
            }
            else if (String.IsNullOrEmpty(txtProductSalesAmount.Text))
            {
                MessageBox.Show("Write the sales amount","WOPS!");
            }
            else if(int.TryParse(txtProductSalesAmount.Text, out var n)==false){
                MessageBox.Show("NOT A NUMBER", "NO LETTERS AWDNOENFO");
                txtProductSalesAmount.Clear();
            }

            else if (Convert.ToInt32(txtProductStock.Text) == 0)
            {
                MessageBox.Show("NO PRODUCTS, WAIT THE RESPAWN", "This is so sad");
            }
            else
            {
                if (!isUpdate)
                {
                    if (Convert.ToInt32(txtProductSalesAmount.Text) > Convert.ToInt32(txtProductStock.Text))
                    {
                        MessageBox.Show("You can't buy more than " + txtProductStock.Text + " units", "This is so sad");
                    }
                    saleToInsert.SalesAmount = Convert.ToInt32(txtProductSalesAmount.Text);
                    saleToInsert.SalesDate = DateTime.Today;

                    if (bll.Insert(saleToInsert))
                    {
                        MessageBox.Show("Sale insert", "OK");
                        txtCustomer.Clear();
                        txtProduct.Clear();
                        txtPrice.Clear();
                        txtProduct.Clear();
                        txtProductSalesAmount.Clear();
                        dto = bll.Select();
                        gridProduct.DataSource = dto.Products;
                    }
                }
                else // UPDATING SALE
                {
                    DialogResult wndAlert = MessageBox.Show("Are you sure?", "ALERT!", MessageBoxButtons.OKCancel);
                    if (wndAlert == DialogResult.OK)
                    {
                        int temp = saleToUpdate.StockAmount + saleToUpdate.SalesAmount;
                        if (temp < Convert.ToInt32(txtProductSalesAmount.Text))
                        {
                            MessageBox.Show("You have not enough product for sale", "NOPE");
                        }
                        else
                        {
                            saleToUpdate.SalesAmount = Convert.ToInt32(txtProductSalesAmount.Text);
                            saleToUpdate.StockAmount = temp - saleToUpdate.SalesAmount;
                        }
                        if (bll.Update(saleToUpdate))
                        {
                            MessageBox.Show("Update done", "OK");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                    else
                    {
                        txtProductSalesAmount.Text = saleToUpdate.SalesAmount.ToString();
                    }
                }
                    
                
            }
        }

        private void txtProductSalesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void gridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
