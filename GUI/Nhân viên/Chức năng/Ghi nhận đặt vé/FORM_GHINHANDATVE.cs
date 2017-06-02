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
    public partial class FORM_GHINHANDATVE : Form
    {
        private bool isSave;
        public FORM_GHINHANDATVE()
        {
            InitializeComponent();
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }




 

        private void txtTenHanhKhach_Leave(object sender, EventArgs e)
        {
            if (txtTenHanhKhach.Text == "")
            {
                errTenHanhKhach.Icon = Properties.Resources.error_icon1;
                errTenHanhKhach.SetError(txtTenHanhKhach, "Chưa điền đầy đủ thông tin");
            }
            else
            {
                errTenHanhKhach.Clear();
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

        private void cmbMaChuyenBay_Leave(object sender, EventArgs e)
        {
            if (cmbMaChuyenBay.Text == "")
            {
                errorMaCB.Icon = Properties.Resources.error_icon1;
                errorMaCB.SetError(cmbMaChuyenBay, "Chưa điền đầy đủ thông tin");
            }
            else
            {
                errorMaCB.Clear();
            }
        }

        private void cmbHangVe_Leave(object sender, EventArgs e)
        {
            if (cmbHangVe.Text == "")
            {
                errorHangVe.Icon = Properties.Resources.error_icon1;
                errorHangVe.SetError(cmbHangVe, "Chưa điền đầy đủ thông tin");
            }
            else
            {
                errorHangVe.Clear();
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
                    errTenHanhKhach.Clear();
                }
            }
        }

        private void cmbMaChuyenBay_TextChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            if (combobox.Text != "")
            {
                if (combobox == cmbHangVe)
                {
                    errorHangVe.Clear();
                }
                else
                {
                    errorMaCB.Clear();
                }
            }
        }
    }
}
