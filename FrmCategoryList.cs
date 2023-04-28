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
    public partial class FrmCategoryList : Form
    {
        CategoryDTO dto = new CategoryDTO();

        CategoryDetailDTO cat_Selected = new CategoryDetailDTO();
        CategoryBLL bll = new CategoryBLL();
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            RefreshGrid();
        }

        void RefreshGrid()
        {
            CategoryBLL bll = new CategoryBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.category;
        }
        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Category Name";
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            List<CategoryDetailDTO> list = dto.category;
            list = list.Where(x => x.CategoryName.Contains(txtCategory.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cat_Selected.CategoryName == "")
            {
                MessageBox.Show("No category was selected.");
            }
            else
            {
                FrmCategory frm = new FrmCategory();
                frm.isUpdate = true;
                frm.cat_ToUpdate = cat_Selected;
                this.Hide();
                frm.ShowDialog();

                this.Visible = true;

                RefreshGrid();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dto.category.Count > 0)
            {
                cat_Selected.CategoryName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cat_Selected.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cat_Selected.ID == 0)
            {
                MessageBox.Show("No row was selected", "DELETE", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult wndResponse = MessageBox.Show("Are you sure?", "WARNING", MessageBoxButtons.YesNo);
                if (wndResponse == DialogResult.Yes)
                {
                    if (bll.Delete(cat_Selected))
                    {
                        MessageBox.Show("Category deleted", "DELETE", MessageBoxButtons.OK);
                        RefreshGrid();
                        txtCategory.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Category NOT deleted", "ERROR", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
