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
    public partial class FORM_GHINHANDATVE : Form
    {
        private bool isSave;

        private string maHangVe;
        public FORM_GHINHANDATVE(string _maChuyenBay,string _tenHangVe,string _maHangVe,string _giaTien)
        {
            InitializeComponent();
            maHangVe = _maHangVe;
            txtGiaVe.Text = _giaTien;
            txtMaChuyenBay.Text = _maChuyenBay;
            txtTenHangVe.Text = _tenHangVe;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            
            string message = "";
            if (VeDat_BUS.GhiNhanDatVe(txtTenHanhKhach.Text, txtSoDT.Text, txtMaChuyenBay.Text, txtCMND.Text, maHangVe))
            {
                message = "Đặt vé thành công";

            }
            else
            {
                message = "Đặt vé không thành công";
            }
            MessageBox.Show(message);
        }

        private void VeDat_BUS_sqlException(object sender, System.Data.SqlClient.SqlException e)
        {
            MessageBox.Show(e.Message);
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

       

       

        private void txtTenHanhKhach_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text != "")
            {
                if (textbox == txtCMND)
                {
                    errorCMND.Clear();
                }
                if (textbox == txtSoDT)
                {
                    errorSoDT.Clear();
                }
                if (textbox==txtTenHanhKhach)
                {
                    errorTenHanhKhach.Clear();
                }
            }
        }

       
        private void FORM_GHINHANDATVE_Load(object sender, EventArgs e)
        {
            

        }
    }
}
