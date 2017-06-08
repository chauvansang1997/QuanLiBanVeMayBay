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
    public partial class FORM_THONGTINNHANVIEN : Form
    {
        public FORM_THONGTINNHANVIEN()
        {
            InitializeComponent();
        }

        private void FORM_THONGTINNHANVIEN_Load(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = User.TenNhanVien;
            txtCMND.Text = User.CMND;
            txtDiaChi.Text = User.DiaChi;
            txtSoDienThoai.Text = User.SoDienThoai;
           
        }
    }
}
