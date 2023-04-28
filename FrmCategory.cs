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
    public partial class FrmCategory : Form
    {
        CategoryBLL bll = new CategoryBLL();
        public bool isUpdate = false;
        public CategoryDetailDTO cat_ToUpdate = new CategoryDetailDTO();
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category can't be empty");
            }
            else
            {
                if (isUpdate)
                {
                    DialogResult wndAlert =  MessageBox.Show("Are you sure?", "ALERT!",MessageBoxButtons.OKCancel);
                    if (wndAlert == DialogResult.OK)
                    {
                        cat_ToUpdate.CategoryName = txtCategory.Text;
                        if (bll.Update(cat_ToUpdate))
                        {
                            MessageBox.Show("Update done","OK");
                            this.Close();
                        }
                        else{
                            MessageBox.Show("ERROR");
                        }
                    }
                    else
                    {
                        txtCategory.Text = cat_ToUpdate.CategoryName;
                    }
                }
                else
                {
                    CategoryDetailDTO cat = new CategoryDetailDTO();
                    cat.CategoryName = txtCategory.Text;
                    if (bll.Insert(cat))
                    {
                        MessageBox.Show("Category was added");
                        txtCategory.Clear();
                        this.Close();
                    }
                }
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtCategory.Text = cat_ToUpdate.CategoryName;
            }
        }
    }
}
