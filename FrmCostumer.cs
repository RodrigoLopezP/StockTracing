using StockTracing.BLL;
using StockTracing.DAL.DTO;
using System;
using System.Windows.Forms;
namespace StockTracing
{
    public partial class FrmCostumer : Form
    {
        CustomerBLL bll = new CustomerBLL();
        public bool isUpdate = false;
        public CustomerDetailDTO cust_ToUpdate = new CustomerDetailDTO();
        public FrmCostumer()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCostumer.Text))
            {
                MessageBox.Show("Customer name can't be empty","HOL UP");
            }
            else
            {
                if (isUpdate)
                {
                    cust_ToUpdate.Name = txtCostumer.Text;
                    DialogResult wndAreYouSure = MessageBox.Show("Change this name?","CONFIRM",MessageBoxButtons.OKCancel);
                    if(wndAreYouSure == DialogResult.OK)
                    {
                        if (bll.Update(cust_ToUpdate))
                        {
                            MessageBox.Show("Customer name updated","NICE");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERROR changing costumer name", "ERROR");
                        }
                    }
                    else
                    {
                        txtCostumer.Text = cust_ToUpdate.Name;
                    }
                        
                }   
                else
                {
                    CustomerDetailDTO customerToInsert = new CustomerDetailDTO();
                    customerToInsert.Name = txtCostumer.Text;
                    if (bll.Insert(customerToInsert))
                    {
                        MessageBox.Show("Customer added.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong, RIP", "ERROR");
                    }
                }
            }
        }
        private void FrmCostumer_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtCostumer.Text = cust_ToUpdate.Name;
            }
        }
    }
}
