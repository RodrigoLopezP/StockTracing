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
    public partial class FrmSalesList : Form
    {
        SalesBLL salesBLL = new SalesBLL();
        SalesDTO salesDTO = new SalesDTO();

        SalesDetailDTO saleSelected = new SalesDetailDTO();
        public FrmSalesList()
        {
            InitializeComponent();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            RefresFormElements();
            ClearFilter();
            
        }
        void RefresFormElements()
        {
            rbPriceEqual.Checked = true;
            rbSalesAmountEqual.Checked = true;

            salesDTO = salesBLL.Select();

            cmbCategory.DataSource = salesDTO.Category;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";

            dataGridView1.DataSource = salesDTO.Sales;

        }
        void ClearFilter()
        {
            cmbCategory.SelectedIndex = -1;

            txtCostumer.Clear();
            txtProduct.Clear();
            txtPrice.Clear();
            txtSalesAmount.Clear();

            rbPriceEqual.Checked = true;
            rbPriceLess.Checked = false;
            rbPriceMore.Checked = false;
            
            rbSalesAmountEqual.Checked = true;
            rbSalesAmountLess.Checked = false;
            rbSalesAmountMore.Checked = false;

            chDate.Checked = false;
            dpSalesDateTo.Enabled = false;
            dpSalesDateFrom.Enabled = false;
            dpSalesDateTo.Value = DateTime.Now;
            dpSalesDateFrom.Value = DateTime.Now;
        }
        private void FrmSalesList_Load(object sender, EventArgs e)
        {
            RefresFormElements();
            ClearFilter();
            dataGridView1.Columns[3].Visible    = false;   //CustomerID
            dataGridView1.Columns[4].Visible    = false;   //ProductID
            dataGridView1.Columns[5].Visible    = false;   // CategoryID
            dataGridView1.Columns[10].Visible   = false;  //Sales ID

            dataGridView1.Columns[0].HeaderText = "Customer";
            dataGridView1.Columns[1].HeaderText = "Product";
            dataGridView1.Columns[2].HeaderText = "Category";
            dataGridView1.Columns[6].HeaderText = "Sales Amount";
            dataGridView1.Columns[7].HeaderText = "Price";
            dataGridView1.Columns[8].HeaderText = "Sale Date";
            dataGridView1.Columns[9].HeaderText = "Stock Amount";
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            saleSelected.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            saleSelected.ProductName= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            saleSelected.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            saleSelected.StockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            saleSelected.SalesAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

            saleSelected.CustomerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            saleSelected.ProductID= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            saleSelected.SalesID= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            saleSelected.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SalesDetailDTO> list = salesDTO.Sales;

            if (!String.IsNullOrEmpty(txtCostumer.Text))
            {
                list = list.Where(x => x.CustomerName.ToLower().Contains(txtCostumer.Text.ToLower())).ToList();
            }
            if (!String.IsNullOrEmpty(txtProduct.Text))
            {
                list = list.Where(x => x.ProductName.ToLower().Contains(txtProduct.Text.ToLower())).ToList();
            }
            if (!String.IsNullOrEmpty(txtPrice.Text))
            {
                if (rbPriceEqual.Checked)
                {
                    list = list.Where(x => x.Price == Convert.ToInt32(txtPrice.Text)).ToList();
                }
                else if (rbPriceLess.Checked)
                {
                    list = list.Where(x => x.Price < Convert.ToInt32(txtPrice.Text)).ToList();
                }
                else if (rbPriceMore.Checked)
                {
                    list = list.Where(x => x.Price > Convert.ToInt32(txtPrice.Text)).ToList();
                }
            }
            if (!String.IsNullOrEmpty(txtSalesAmount.Text))
            {
                if (rbSalesAmountEqual.Checked)
                {
                    list = list.Where(x => x.SalesAmount == Convert.ToInt32(txtSalesAmount.Text)).ToList();
                }
                else if (rbSalesAmountLess.Checked)
                {
                    list = list.Where(x => x.SalesAmount < Convert.ToInt32(txtSalesAmount.Text)).ToList();
                }
                else if (rbSalesAmountMore.Checked)
                {
                    list = list.Where(x => x.SalesAmount > Convert.ToInt32(txtSalesAmount.Text)).ToList();
                }
            }
            if (cmbCategory.SelectedIndex>-1)
            {
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
            }
            if (chDate.Checked == true)
            {
                list = list.Where(x => x.SalesDate <= dpSalesDateTo.Value).ToList();
                list = list.Where(x => x.SalesDate >= dpSalesDateFrom.Value).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            ClearFilter();
            dataGridView1.DataSource = salesDTO.Sales;
        }

        private void chDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chDate.Checked == true)
            {
                dpSalesDateTo.Enabled = true;
                dpSalesDateFrom.Enabled = true;
            }
            else
            {
                dpSalesDateTo.Enabled = false;
                dpSalesDateFrom.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            frm.isUpdate = true;
            frm.saleToUpdate = this.saleSelected;
            this.Hide();
            frm.ShowDialog();

            this.Visible = true;
            SalesBLL bllUpdated = new SalesBLL();
            salesDTO = bllUpdated.Select();
            dataGridView1.DataSource = salesDTO.Sales;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (saleSelected.SalesID ==0)
            {
                MessageBox.Show("No row was selected", "DELETE", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult wndResponse = MessageBox.Show("Are you sure?", "WARNING",MessageBoxButtons.YesNo);
                if (wndResponse ==DialogResult.Yes)
                {
                    if (salesBLL.Delete(saleSelected))
                    {
                        MessageBox.Show("Sales deleted", "DELETE", MessageBoxButtons.OK);
                        SalesBLL bllUpdated = new SalesBLL();
                        salesDTO = bllUpdated.Select();
                        dataGridView1.DataSource = salesDTO.Sales;
                    }
                }
            }
        }
    }
}
