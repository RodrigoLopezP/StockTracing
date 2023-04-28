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
    public partial class FrmCostumerList : Form
    {
        CustomerBLL bll = new CustomerBLL();
        CustomerDTO dto = new CustomerDTO();

        CustomerDetailDTO custSelected = new CustomerDetailDTO();

        public FrmCostumerList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCostumer frm = new FrmCostumer();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            dto = bll.Select();
            dataGridView1.DataSource = dto.Customer;
        }

        private void FrmCostumerList_Load(object sender, EventArgs e)
        {
            dto=bll.Select();
            dataGridView1.DataSource = dto.Customer;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Customer Name";

        }

        private void txtCostumer_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dto.Customer;
            list = list.Where(x => x.Name.Contains(txtCostumer.Text)).ToList();

            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmCostumer frm = new FrmCostumer();
            frm.isUpdate = true;
            frm.cust_ToUpdate = custSelected;
            this.Hide();
            frm.ShowDialog();
            

             CustomerBLL bll_updated = new CustomerBLL();
            dto = bll_updated.Select();
            dataGridView1.DataSource = dto.Customer;
            this.Visible = true;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dto.Customer.Count > 0)
            {
                custSelected.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                custSelected.Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (custSelected.ID == 0)
            {
                MessageBox.Show("No row was selected", "DELETE", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult wndResponse = MessageBox.Show("Are you sure?", "WARNING", MessageBoxButtons.YesNo);
                if (wndResponse == DialogResult.Yes)
                {
                    if (bll.Delete(custSelected))
                    {
                        MessageBox.Show("Customer deleted", "DELETE", MessageBoxButtons.OK);
                        CustomerBLL bllUpdated = new CustomerBLL();
                        dto = bllUpdated.Select();
                        dataGridView1.DataSource = dto.Customer;
                        txtCostumer.Clear();
                    }
                }
            }
        }
    }
}
