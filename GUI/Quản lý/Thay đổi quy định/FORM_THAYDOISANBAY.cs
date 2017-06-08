using BUS;
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
    public partial class FORM_THAYDOISANBAY : Form
    {
        public FORM_THAYDOISANBAY()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(txtSoLuongSB.Text);
                if (temp <= 0)
                {
                    throw new Exception("Số lượng sân bay phải lớn hơn không");
                }
                QuyDinh.SoLuongSanBay = temp;
                if (QuyDinh_BUS.ThayDoiQuyDinhSanBay())
                {
                    MessageBox.Show("Thay đổi thành công");
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
