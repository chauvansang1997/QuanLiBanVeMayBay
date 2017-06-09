using BUS;
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
    public partial class FORM_SUANHANVIEN : Form
    {
        private string maNhanVien;
        public FORM_SUANHANVIEN(string _maNhanVien)
        {
            maNhanVien = _maNhanVien;
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            //if (txtCMND.Text != "" || txtDiaChi.Text != "" || txtSoDienThoai.Text != "" || txtTenNhanVien.Text != "")
            //{
            //    if(NhanVien_BUS.SuaThongTinNhanVien(maNhanVien, txtTenNhanVien.Text, txtCMND.Text, txtSoDienThoai.Text, txtDiaChi.Text))
            //    {
            //        MessageBox.Show("Cập nhật thành công");
            //        this.Close();
            //    }
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
