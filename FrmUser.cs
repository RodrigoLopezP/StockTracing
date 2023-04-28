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
    public partial class FrmUser : Form
    {
        UserBLL userBll = new UserBLL();
        UserDTO dto = new UserDTO();
        public bool isUpdate = false;
        public UserDetailDTO userToUpdate = new UserDetailDTO();
        public FrmUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
          
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Write an username");
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Write an password");
            }
            else if (cmbPermission.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a permission");
            }
            else if (txtUsername.Text.Contains(" ") || txtPassword.Text.Contains(" "))
            {
                MessageBox.Show("Don't use spaces");
                txtUsername.Clear();
                txtPassword.Clear();
            }

            else
            {

                if (!isUpdate)
                {
                    var list = dto.users.FirstOrDefault(x => x.Username == txtUsername.Text);
                    if (list != null)
                    {
                        MessageBox.Show("Username already used");
                    }
                    else {
                        UserDetailDTO userToAdd = new UserDetailDTO();
                        userToAdd.Username = txtUsername.Text;
                        userToAdd.Password = txtPassword.Text;
                        userToAdd.PermissionId = Convert.ToInt32(cmbPermission.SelectedValue);
                        userToAdd.isAdmin = chIsAdmin.Checked;
                        if (userBll.Insert(userToAdd))
                        {
                            MessageBox.Show("User added", "OK", MessageBoxButtons.OK);
                            RefreshElements();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Add user failed, contact administrator", "ERROR");
                        }
                    }
                }
                else
                {
                    var list = dto.users.FirstOrDefault(x => x.Username == txtUsername.Text && x.UserId!=userToUpdate.UserId);
                    if (txtUsername.Text!="" && list==null)
                    {
                        userToUpdate.Username = txtUsername.Text;
                        userToUpdate.Password = txtPassword.Text;
                        userToUpdate.PermissionId = Convert.ToInt32(cmbPermission.SelectedValue);
                        userToUpdate.isAdmin = chIsAdmin.Checked;
                        if (userBll.Update(userToUpdate))
                        {
                            MessageBox.Show("User updated", "OK", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update user failed, contact administrator", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username already used");
                        txtUsername.Text = userToUpdate.Username;
                    }
                }

            }

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            RefreshElements();
            if (isUpdate)
            {
                txtUsername.Text = userToUpdate.Username;
                txtPassword.Text = userToUpdate.Password;
                cmbPermission.SelectedValue = userToUpdate.PermissionId;
                chIsAdmin.Checked = userToUpdate.isAdmin;
            }
        }

        void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbPermission.SelectedIndex = -1;
            chIsAdmin.Checked = false;
        }

        void RefreshElements()
        {
            UserBLL userBllUpdated = new UserBLL(); 
            dto = userBllUpdated.Select();
            cmbPermission.DataSource = dto.permissions;
            cmbPermission.DisplayMember = "PermissionName";
            cmbPermission.ValueMember = "PermissionID";
            cmbPermission.SelectedIndex = -1;
        }
    }
}
