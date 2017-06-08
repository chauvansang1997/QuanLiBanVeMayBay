using BUS;
using Help_Fuction;
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
    public partial class FORM_THEMNHANVIEN : Form
    {
        private string loaiNhanVien;
        public FORM_THEMNHANVIEN()
        {
            InitializeComponent();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên");
                return;
            }
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chứng minh nhân dân");
                return;
            }
            if (HelpFuction.IsContainsText(txtCMND.Text))
            {
                MessageBox.Show("Chứng minh nhân dân chỉ chứa số");
                return;
            }

            if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên");
                return;
            }
            if (HelpFuction.IsContainsText(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại chỉ chứa số");
                return;
            }
            if (!rbtnBanVe.Checked && !rbtnQuanLy.Checked)
            {
                MessageBox.Show("Bạn cần chọn loại nhân viên");
                return;
            }

            if (NhanVien_BUS.ThemNhanVien(txtTenNhanVien.Text, txtCMND.Text, txtSoDienThoai.Text, loaiNhanVien, txtDiaChi.Text))
            {
                MessageBox.Show("Thêm thành công");
            }

        }

        private void Check(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (rbtnBanVe == radioButton)
            {
                loaiNhanVien = "BV";
            }
            else
            {
                loaiNhanVien = "QT";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
