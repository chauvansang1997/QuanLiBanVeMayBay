using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FORM_DOIMATKHAU : Form
    {
        public FORM_DOIMATKHAU()
        {
            InitializeComponent();
        }

        private void FORM_DOIMATKHAU_Load(object sender, EventArgs e)
        {
            lbTenDangNhap.Text = User.UserName;
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != User.Password)
            {
                MessageBox.Show("Mật khẩu cũ sai");
                return;
            }
            if (txtMatKhauMoi.Text != txtMatKhauMoi_Lai.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không trùng nhau");
            }
            try
            {
                if(User_BUS.ThayDoiMatKhau(User.UserName, txtMatKhauMoi.Text))
                {
                    MessageBox.Show("Thay đổi thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
