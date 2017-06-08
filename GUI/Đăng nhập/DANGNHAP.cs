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
     
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorPassword.Icon = Properties.Resources.error_icon1;
                errorPassword.SetError(txtPassword, "Mật khẩu chưa được điền");

            }
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (User_BUS.DangNhap(txtUserName.Text, txtPassword.Text)==0)
            {
                NHANVIEN formNhanVien = new NHANVIEN();

                this.Hide();
                formNhanVien.ShowDialog();
                this.Show();
                return;

            }
            if(User_BUS.DangNhap(txtUserName.Text, txtPassword.Text) == 1)
            {
                FORM_QUANLY quanly = new FORM_QUANLY();

                this.Hide();
                quanly.ShowDialog();
                this.Show();
                return;
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc xảy ra lỗi");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
