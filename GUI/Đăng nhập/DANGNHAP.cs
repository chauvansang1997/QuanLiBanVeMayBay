using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorUser.Icon = Properties.Resources.error_icon1;
                errorUser.SetError(txtUserName,"Tài khoản chưa được điền");

            }
            else
            {
                errorUser.Icon = Properties.Resources.ok_icon;
                errorUser.SetError(txtUserName, "Ok");
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorPassword.Icon = Properties.Resources.error_icon1;
                errorPassword.SetError(txtPassword, "Mật khẩu chưa được điền");

            }
            else
            {
                errorPassword.Icon = Properties.Resources.ok_icon;
                errorPassword.SetError(txtPassword, "Ok");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BUS.User_BUS.Instance.DangNhap(txtUserName.Text, txtPassword.Text))
            {
                NHANVIEN formNhanVien = new NHANVIEN();
                formNhanVien.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
