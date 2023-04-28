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
    public partial class FrmProduct : Form
    {
        ProductBLL bll = new ProductBLL();
        public ProductDTO dto = new ProductDTO();

        public bool isUpdate = false;
        public ProductDetailDTO prod_ToUpdate = new ProductDetailDTO();
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
                dto = bll.Select();
                cmbCategory.DataSource = dto.categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "ID";
                cmbCategory.SelectedIndex = -1;
            if (isUpdate)
            {
                txtProduct.Text = prod_ToUpdate.productName;
                cmbCategory.SelectedValue = prod_ToUpdate.categoryID;
                txtPrice.Text = prod_ToUpdate.price.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProduct.Text))
            {
                MessageBox.Show("Product can't be empty","Check product");
            }
            else if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Price can't be empty", "Check price");
            }
            else if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Category can't be empty","Check category");
            }
            else
            {
                if (isUpdate)
                {
                    DialogResult wndAlert = MessageBox.Show("Are you sure?", "ALERT!", MessageBoxButtons.OKCancel);
                    if (wndAlert == DialogResult.OK)
                    {
                        prod_ToUpdate.productName = txtProduct.Text;
                        prod_ToUpdate.categoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                        prod_ToUpdate.price = Convert.ToInt32(txtPrice.Text);
                        if (bll.Update(prod_ToUpdate))
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
                        txtProduct.Text = prod_ToUpdate.productName;
                        cmbCategory.SelectedValue = prod_ToUpdate.categoryID;
                        txtPrice.Text = prod_ToUpdate.price.ToString();
                    }
                }
                else
                {
                    ProductDetailDTO productToSave = new ProductDetailDTO();
                    productToSave.categoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                    productToSave.productName = txtProduct.Text;
                    productToSave.price = Convert.ToInt32(txtPrice.Text);

                    if (bll.Insert(productToSave))
                    {
                        MessageBox.Show("Product added.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR, RIP.");
                    }
                }
            }
        }
    }
}
