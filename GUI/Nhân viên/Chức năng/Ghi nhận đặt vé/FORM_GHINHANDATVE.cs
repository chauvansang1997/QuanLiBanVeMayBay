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
using Help_Fuction;

namespace GUI
{
    public partial class FORM_GHINHANDATVE : Form
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
        public FORM_GHINHANDATVE(string _maChuyenBay,string _tenHangVe,string _maHangVe,string _giaTien)
        {
            InitializeComponent();
            maHangVe = _maHangVe;
            txtGiaVe.Text = _giaTien;
            txtMaChuyenBay.Text = _maChuyenBay;
            txtTenHangVe.Text = _tenHangVe;
        }

        /// <summary>
        /// Sự kiện nhấn nút đật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {           
            if(HelpFuction.isContainsNumber(txtTenHanhKhach.Text))
            {
                MessageBox.Show("Tên người không đúng định dạng");
                return;
            }
            if (HelpFuction.IsContainsText(txtSoDT.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return;
            }
            if (HelpFuction.IsContainsText(txtCMND.Text))
            {
                MessageBox.Show("Chứng minh nhân dân không đúng định dạng");
                return;
            }
            if (VeDat_BUS.GhiNhanDatVe(txtTenHanhKhach.Text, txtSoDT.Text, txtMaChuyenBay.Text, txtCMND.Text, maHangVe))
            {
                MessageBox.Show("Đặt vé thành công");
                txtCMND.Text = "";
                txtTenHanhKhach.Text = "";
                txtSoDT.Text = "";

            }
            else
            {

                MessageBox.Show("Đặt vé không thành công");
                return;
            }

        }

        private void VeDat_BUS_sqlException(object sender, System.Data.SqlClient.SqlException e)
        {
            MessageBox.Show(e.Message);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Thông báo chưa nhập thông tin
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

        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            if (txtSoDT.Text == "")
            {
                errorSoDT.Icon = Properties.Resources.error_icon1;
                errorSoDT.SetError(txtSoDT, "Chưa điền đầy đủ thông tin");
            }
            else
            {
                errorSoDT.Clear();
            }
        }

#endregion


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
            if(!HelpFuction.IsContainsText(txtCMND.Text))
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
        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDT.Text == "")
            {
                return;
            }
            if(!HelpFuction.IsContainsText(txtSoDT.Text))
            {
                check_SoDienThoai = Convert.ToUInt32(txtSoDT.Text);
            }
            else
            {
                txtSoDT.Text = check_SoDienThoai.ToString();
            }
        }
    }
}
