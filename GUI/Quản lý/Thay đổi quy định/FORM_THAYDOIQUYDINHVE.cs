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
    public partial class FORM_THAYDOIQUYDINHVE : Form
    {
        public FORM_THAYDOIQUYDINHVE()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(txtTGDatVe.Text);
                if (temp <= 0)
                {
                    throw new Exception("Thời gian chậm nhất đặt vé phải lớn hơn 0");
                }
                QuyDinh.ThoiGianChamNhatDatVe = temp;
                temp = Convert.ToInt32(txtThoiGianHuyVe.Text);
                if(temp <= 0)
                {
                    throw new Exception("Thời gian chậm nhất hủy vé phải lớn hơn 0");
                }
                QuyDinh.ThoiGianChamNhatHuyVe = temp;
                if (QuyDinh_BUS.ThayDoiQuyDinhVe())
                {
                    MessageBox.Show("Thay đổi thành công");
                }
                else
                {
                    QuyDinh_BUS.LoadQuyDinh();
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
