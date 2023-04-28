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
    public partial class FrmLogin : Form
    {
        UserDetailDTO userSelected = new UserDetailDTO();
        UserDTO userList = new UserDTO();
        UserBLL userBll = new UserBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Write username and password");
            }
            else
            {
                userSelected.Username = txtUsername.Text;
                userSelected.Password = txtPassword.Text;
                userList=userBll.Select();
                var list = userList.users.FirstOrDefault(x =>
                                x.Username == userSelected.Username &&
                                x.Password == userSelected.Password
                                );
                if (list!=null)
                {
                    UserStatic.username = list.Username;
                    UserStatic.password = list.Password;
                    UserStatic.userId = list.UserId;
                    UserStatic.isAdmin = list.isAdmin;
                    UserStatic.permissionID = list.PermissionId;
                    UserStatic.permissionName = list.PermissionName;
                    FrmStockAlert frm = new FrmStockAlert();
                    this.Hide();
                    frm.Visible = true;
                }
                else
                {
                    MessageBox.Show("Wrong credentials");
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
        }
    }
}
