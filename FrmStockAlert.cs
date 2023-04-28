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
    public partial class FrmStockAlert : Form
    {
        ProductDTO dtoStockAlert = new ProductDTO();
        ProductBLL bll = new ProductBLL();

        ProductDetailDTO product_toUpdate = new ProductDetailDTO();
        public FrmStockAlert()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        void RefreshWinElements()
        {
            dtoStockAlert = bll.Select();
            dtoStockAlert.products = dtoStockAlert.products.Where(x => x.stockAmount <= 10).ToList();

            dataGridView1.DataSource = dtoStockAlert.products;


        }
        private void FrmStockAlert_Load(object sender, EventArgs e)
        {
            RefreshWinElements();
            if (dtoStockAlert.products.Count == 0)
            {
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                dataGridView1.Columns[0].HeaderText = "Product";
                dataGridView1.Columns[1].HeaderText = "Category";
                dataGridView1.Columns[2].HeaderText = "Stock";
                dataGridView1.Columns[3].HeaderText = "Price";
                dataGridView1.Columns[4].Visible = false;  //product ID
                dataGridView1.Columns[5].Visible = false;  //Category ID}

            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            product_toUpdate.productName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            product_toUpdate.stockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            product_toUpdate.price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            product_toUpdate.productID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            DialogResult wnd =MessageBox.Show("Update product?", "ALERT!", MessageBoxButtons.OKCancel);
            if (wnd==DialogResult.OK)
            {

                FrmAddStock frm = new FrmAddStock();
                frm.prod_ToUpdate = product_toUpdate;
                frm.isUpdate = true;
                this.Hide();
                frm.ShowDialog();

                RefreshWinElements();
                this.Visible=true;
            }
        }
    }
}
