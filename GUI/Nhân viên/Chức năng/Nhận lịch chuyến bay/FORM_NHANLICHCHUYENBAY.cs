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
        }

        private void txtTenChuyenBay_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenChuyenBay.Text))
            {
                errorTenChuyenBay.Icon = Properties.Resources.error_icon1;
                errorTenChuyenBay.SetError(txtTenChuyenBay, "Tên chuyến bay rỗng");
            }
            else
            {
                errorTenChuyenBay.Icon = Properties.Resources.ok_icon;
                errorTenChuyenBay.SetError(txtTenChuyenBay, "Ok");
            }
        }
    }
}
