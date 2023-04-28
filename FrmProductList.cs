using StockTracing.BLL;
using StockTracing.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace StockTracing
{
    public partial class FrmProductList : Form
    {
        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();

        ProductDetailDTO prod_Selected = new ProductDetailDTO();
        public FrmProductList()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.prod_ToUpdate = prod_Selected;
            frm.isUpdate = true;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            ProductBLL bllUpdated = new ProductBLL();
            dto = bllUpdated.Select();
            dataGridView1.DataSource = dto.products;
            CleanFilter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (prod_Selected.productID == 0)
            {
                MessageBox.Show("No product was selected", "DELETE", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult wndResponse = MessageBox.Show("Are you sure?", "WARNING", MessageBoxButtons.YesNo);
                if (wndResponse == DialogResult.Yes)
                {
                    if (bll.Delete(prod_Selected))
                    {
                        MessageBox.Show("Product deleted", "DELETE", MessageBoxButtons.OK);
                        ProductBLL bllUpdated = new ProductBLL();
                        dto = bllUpdated.Select();
                        dataGridView1.DataSource = dto.products;
                        cmbCategory.DataSource = dto.categories;
                        CleanFilter();
                    }

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            this.Hide();
            frm.ShowDialog();

            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.products;
            RefreshDataInWinForm();
            CleanFilter();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        void RefreshDataInWinForm()
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.products;

            cmbCategory.DataSource = dto.categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            RefreshDataInWinForm();
            dataGridView1.Columns[0].HeaderText = "Product";
            dataGridView1.Columns[1].HeaderText = "Category";
            dataGridView1.Columns[2].HeaderText = "Stock Amount";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].Visible = false; //prod id
            dataGridView1.Columns[5].Visible = false; // cat id

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProductDetailDTO> productsFiltered = new List<ProductDetailDTO>();
            productsFiltered = dto.products;
            if (!String.IsNullOrEmpty(txtProduct.Text))
            {
                productsFiltered = productsFiltered.Where(
                    x => x.productName.ToLower().Contains(txtProduct.Text.ToLower())
                    ).ToList();
            }
            if (!String.IsNullOrEmpty(txtPrice.Text))
            {
                if (rbPriceEqual.Checked){
                    productsFiltered = productsFiltered.Where(
                        x => x.price == Convert.ToInt32(txtPrice.Text)
                        ).ToList();
                }
                else if (rbPriceLess.Checked)
                {
                    productsFiltered = productsFiltered.Where(
                        x => x.price < Convert.ToInt32(txtPrice.Text)
                        ).ToList();
                }
                else if (rbPriceMore.Checked)
                {
                    productsFiltered = productsFiltered.Where(
                        x => x.price > Convert.ToInt32(txtPrice.Text)
                        ).ToList();
                }

            }
            if (!String.IsNullOrEmpty(txtStock.Text))
            {
                if (rbStockEqual.Checked)
                {
                    productsFiltered = productsFiltered.Where(
                        x => x.stockAmount == Convert.ToInt32(txtStock.Text)
                        ).ToList();
                }
                else if (rbStockLess.Checked)
                {
                    productsFiltered = productsFiltered.Where(
                         x => x.stockAmount < Convert.ToInt32(txtStock.Text)
                        ).ToList();
                }
                else if (rbStockMore.Checked)
                {
                    productsFiltered = productsFiltered.Where(
                         x => x.stockAmount > Convert.ToInt32(txtStock.Text)
                        ).ToList();
                }

            }
            if (cmbCategory.SelectedIndex != -1)
            {
                productsFiltered = productsFiltered.Where(
                    x => x.categoryID == Convert.ToInt32(cmbCategory.SelectedValue)
                     ).ToList();
            }
            dataGridView1.DataSource = productsFiltered;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanFilter();
        }

        void CleanFilter()
        {
            txtProduct.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cmbCategory.SelectedIndex = -1;

            rbPriceEqual.Checked = true;
            rbPriceLess.Checked = false;
            rbPriceMore.Checked = false;

            rbStockEqual.Checked = true;
            rbStockLess.Checked = false;
            rbStockMore.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            prod_Selected.productName= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prod_Selected.stockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            prod_Selected.price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            prod_Selected.productID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            prod_Selected.categoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
        }
    }
}
