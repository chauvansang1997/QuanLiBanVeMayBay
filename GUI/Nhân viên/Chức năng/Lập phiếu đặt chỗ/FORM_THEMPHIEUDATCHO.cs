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
    public partial class FORM_THEMPHIEUDATCHO : Form
    {
        private string maHangVe;

        private string check_TenHanhKhach;
        private uint check_SoDienThoai;
        private uint check_CMND;

        /// <summary>
        /// Hàm khởi tạo 
        /// </summary>
        /// <param name="_maChuyenBay">mã sân bay mà ta đã chọn từ form trước</param>
        /// <param name="_tenHangVe"></param>
        /// <param name="_maHangVe">mã hạng vé</param>
        /// <param name="_giaTien">giá tiền</param>
        public FORM_THEMPHIEUDATCHO(string _maChuyenBay,string _tenHangVe,string _maHangVe,string _giaTien)
        {           

            InitializeComponent();
            txtMaChuyenBay.Text = _maChuyenBay;
            txtTenHangVe.Text = _tenHangVe;
            txtGiaVe.Text = _giaTien;
            maHangVe = _maHangVe;
        }
        /// <summary>
        /// Sự kiện nhấn nút đật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
        
            string message="";
            if(PhieuDatCho_BUS.LapPhieuDatCho(txtTenHanhKhach.Text, txtCMND.Text, txtSoDienThoai.Text, txtMaChuyenBay.Text,maHangVe, dtPKNgayDat.Value))
            {
                message = "Đặt chỗ thành công";
                txtTenHanhKhach.Text = "";
                txtCMND.Text = "";
                txtSoDienThoai.Text = "";
            }
            else
            {
                message = "Đặt chỗ không thành công";
            }
            MessageBox.Show(message);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenHanhKhach_Leave(object sender, EventArgs e)
        {
            if (txtTenHanhKhach.Text == "")
            {
                errorTenHanhKhach.Icon = Properties.Resources.error_icon1;
                errorTenHanhKhach.SetError(txtTenHanhKhach, "Chưa điền đầy đủ thông tin");
            }
            else
            {
                errorTenHanhKhach.Clear();
            }
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            if (txtCMND.Text == "")
            {
                errorCMND.Icon = Properties.Resources.error_icon1;
                errorCMND.SetError(txtCMND, "Chưa điền đầy đủ thông tin");
            }
            else
            {
                errorCMND.Clear();
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                errorSoDT.Icon = Properties.Resources.error_icon1;
                errorSoDT.SetError(txtSoDienThoai, "Chưa điền đầy đủ thông tin");
            }
            else
            {
                errorSoDT.Clear();
            }
        }



        /// <summary>
        /// Tránh nhập số vào tên người
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenHanhKhach_TextChanged(object sender, EventArgs e)
        {
            if (txtTenHanhKhach.Text == "")
            {
                return;
            }
            if (!HelpFuction.isContainsNumber(txtTenHanhKhach.Text))
            {
                check_TenHanhKhach = txtTenHanhKhach.Text;
            }
            else
            {
                txtTenHanhKhach.Text = check_TenHanhKhach;
            }
        }
        /// <summary>
        /// Trành nhập kí tự vào số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtCMND.Text == "")
            {
                return;
            }
            if (!HelpFuction.IsContainsText(txtCMND.Text))
            {
                check_CMND = Convert.ToUInt32(txtCMND.Text);
            }
            else
            {
                txtCMND.Text = check_CMND.ToString();
            }
        }
        /// <summary>
        /// Trành nhập kí tự vào số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                return;
            }
            if (!HelpFuction.IsContainsText(txtSoDienThoai.Text))
            {
                check_SoDienThoai = Convert.ToUInt32(txtSoDienThoai.Text);
            }
            else
            {
                txtSoDienThoai.Text = check_SoDienThoai.ToString();
            }
        }
    }
}
