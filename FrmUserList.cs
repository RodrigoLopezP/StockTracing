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
    public partial class FrmUserList : Form
    {
        UserDTO userDto = new UserDTO();
        UserBLL userBll = new UserBLL();
        UserDetailDTO userSelected = new UserDetailDTO();
        public FrmUserList()
        {
            InitializeComponent();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            userDto = userBll.Select();
            dataGridView1.DataSource = userDto.users;

            dataGridView1.Columns[0].Visible = false; //User ID
            dataGridView1.Columns[1].HeaderText = "Username";
            dataGridView1.Columns[2].Visible = false; //User Password
            dataGridView1.Columns[3].HeaderText = "Admin";
            dataGridView1.Columns[4].Visible = false; //Permission ID
            dataGridView1.Columns[5].HeaderText = "Permission";
            dataGridView1.Columns[6].HeaderText = "Deleted";//Is deleted
            dataGridView1.Columns[7].HeaderText = "Deleted Date";//Is deleted

            cmbPermission.DataSource = userDto.permissions;
            cmbPermission.DisplayMember = "PermissionName";
            cmbPermission.ValueMember = "PermissionID";
            cmbPermission.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPermission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            RefreshElements();
            ClearFilters();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var list = userDto.users.ToList();
            if (!String.IsNullOrEmpty(txtUsername.Text))
            {
                list = list.Where(x => x.Username.Contains(txtUsername.Text)).ToList();
            }
            if (cmbPermission.SelectedIndex != -1)
            {
                list = list.Where(x => x.PermissionId == Convert.ToInt32(cmbPermission.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
        void ClearFilters()
        {
            txtUsername.Clear();
            cmbPermission.SelectedIndex = -1;
        }
        void RefreshElements()
        {
            UserBLL userBllUpdated = new UserBLL();
            userDto = userBllUpdated.Select();
            cmbPermission.DataSource = userDto.permissions;
            cmbPermission.DisplayMember = "PermissionName";
            cmbPermission.ValueMember = "PermissionID";
            cmbPermission.SelectedIndex = -1;
            dataGridView1.DataSource = userDto.users;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                userSelected.UserId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                userSelected.Username = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                userSelected.Password = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                userSelected.isAdmin = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                userSelected.PermissionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                userSelected.PermissionName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                userSelected.isDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            frm.isUpdate = true;
            frm.userToUpdate = userSelected;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            RefreshElements();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userSelected.UserId == 0)
            {
                MessageBox.Show("No user selected");
            }
            else
            {
                DialogResult wndConfirm = MessageBox.Show("Delete this user?", "",MessageBoxButtons.YesNo);
                if (wndConfirm == DialogResult.Yes)
                {
                    if (userBll.Delete(userSelected))
                    {
                        MessageBox.Show("User deleted", "", MessageBoxButtons.OK);
                        RefreshElements();
                        ClearFilters();
                    }
                }

            }
        }
    }
}
