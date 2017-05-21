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
    public partial class FORM_NHANLICHCHUYENBAY : Form
    {
        public FORM_NHANLICHCHUYENBAY()
        {
            InitializeComponent();
            cmbSanBayDen.MouseWheel += ComboBox2_MouseWheel;

            //comboBox2.AutoScrollOffset = AutoScroll;
            //cmbSanBayDen.Au
            //cmbSanBayDen.
         
        }

       

        private void ComboBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Drag");
         
        }

        private void txtTenChuyenBay_Leave(object sender, EventArgs e)
        {
        //    if (string.IsNullOrEmpty(txtTenChuyenBay.Text))
        //    {
        //        errorTenChuyenBay.Icon = Properties.Resources.error_icon1;
        //        errorTenChuyenBay.SetError(txtTenChuyenBay, "Tên chuyến bay rỗng");
        //    }
        //    else
        //    {
        //        errorTenChuyenBay.Icon = Properties.Resources.ok_icon;
        //        errorTenChuyenBay.SetError(txtTenChuyenBay, "Ok");
        //    }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show("ok");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbSanBayDen_DropDown(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            combobox.Focus();
           
        }

        private void cmbSanBayDen_MouseEnter(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            combobox.Focus();
        }
    }
}
