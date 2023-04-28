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
    public partial class FrmAddStock : Form
    {
        ProductDTO produDTO = new ProductDTO();
        ProductBLL prodBLL = new ProductBLL();
        ProductDetailDTO detail = new ProductDetailDTO();
        bool combofull = false;
        public bool isUpdate = false;
        public ProductDetailDTO prod_ToUpdate = new ProductDetailDTO();
        public FrmAddStock()
        {
            InitializeComponent();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddStock_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                panel1.Hide();
                txtProduct.Text = prod_ToUpdate.productName;
                txtStock.Text = prod_ToUpdate.stockAmount.ToString();
                txtPrice.Text = prod_ToUpdate.price.ToString();

                detail.productName = prod_ToUpdate.productName;
                detail.productID = prod_ToUpdate.productID;
                detail.price = prod_ToUpdate.price;
            }
            else
            {
                produDTO = prodBLL.Select();

                cmbCategory.DataSource = produDTO.categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "ID";

                cmbCategory.SelectedIndex = -1;

                dataGridView1.DataSource = produDTO.products;

                dataGridView1.Columns[0].HeaderText = "Product";
                dataGridView1.Columns[1].HeaderText = "Category";
                dataGridView1.Columns[2].HeaderText = "Stock";
                dataGridView1.Columns[3].HeaderText = "Price";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;

                combofull = false;
                if (produDTO.categories.Count > 0)
                {
                    combofull = true;
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProductDetailDTO> list = produDTO.products;

            if (combofull)
            {
                list = list.Where(x => x.categoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                if (list.Count == 0)
                {
                    txtPrice.Clear();
                    txtStock.Clear();
                    txtProduct.Clear();
                }
            }
            dataGridView1.DataSource = list;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!isUpdate)
            {
                txtProduct.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                detail.productName = txtProduct.Text;
                detail.productID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

                detail.price = Convert.ToInt32(txtPrice.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProduct.Text))
            {
                MessageBox.Show("No product selected", "AYOOO");
            }
            else if (String.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Write a stock first", "WAAAAA");
            }
            else
            {
                detail.stockAmount = Convert.ToInt32(txtStock.Text);
                if (prodBLL.Update(detail))
                {
                    if (isUpdate)
                    {
                        MessageBox.Show("Product's stock alert was updated", "Stock alert");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Stock updated in product", "NICE!");
                        produDTO = prodBLL.Select();
                        dataGridView1.DataSource = produDTO.products;
                        txtStock.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Something's wrong, contact admin","BONK!");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
