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
    public partial class FORM_THEMPHIEUDATCHO : Form
    {
        private string maHangVe;
        public FORM_THEMPHIEUDATCHO(string _maChuyenBay,string _tenHangVe,string _maHangVe,string _giaTien)
        {           

            InitializeComponent();
            txtMaChuyenBay.Text = _maChuyenBay;
            txtTenHangVe.Text = _tenHangVe;
            txtGiaVe.Text = _giaTien;
            maHangVe = _maHangVe;
        }

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

     

       
        private void txtTenHanhKhach_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text != "")
            {
                if (textbox == txtCMND)
                {
                    errorCMND.Clear();
                }
                if (textbox == txtSoDienThoai)
                {
                    errorSoDT.Clear();
                }
                if (textbox == txtTenHanhKhach)
                {
                    errorTenHanhKhach.Clear();
                }
            }
        }


        private void FORM_THEMPHIEUDATCHO_Load(object sender, EventArgs e)
        {
       
        }
    }
}
