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
    public partial class FORM_THEMSANBAY : Form
    {
        
        public FORM_THEMSANBAY()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenSanBay.Text == "")
            {
                MessageBox.Show("Bạn chưa điền tên");
                return;
            }
            if (Help_Fuction.HelpFuction.isContainsNumber(txtTenSanBay.Text))
            {
                MessageBox.Show("Sân bay không được chứa số");
                return;
            }
            if (SanBay_BUS.ThemSanBay(txtTenSanBay.Text))
            {
                MessageBox.Show("Thêm sân bay thành công");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
