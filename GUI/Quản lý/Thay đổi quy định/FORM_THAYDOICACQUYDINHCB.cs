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
    public partial class FORM_THAYDOICACQUYDINHCB : Form
    {
        public FORM_THAYDOICACQUYDINHCB()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int temp= Convert.ToInt32(txtThoiGianBay.Text);
                if (temp <= 0)
                {
                    throw new Exception("Thời gian bay tối thiểu phải lớn hơn 0");
                }
                QuyDinh.ThoiGianBayToiThieu = temp;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return;
            }
            try
            {
                int temp = Convert.ToInt32(txtSoSanBayToiDa.Text);
                if (temp <= 0)
                {
                    throw new Exception("Thời gian bay tối thiểu phải lớn hơn 0");
                }
                QuyDinh.SoSanBayTGToiDa = temp;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return;
            }
            try
            {
                int temp = Convert.ToInt32(txtThoiGianDungTT.Text);
                if (temp <= 0)
                {
                    throw new Exception("Thời gian bay tối thiểu phải lớn hơn 0");
                }
                QuyDinh.ThoiGianDungToiThieu = temp;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return;
            }
            try
            {
                int temp = Convert.ToInt32(txtThoiGianDungTD.Text);
                if (temp <= 0)
                {
                    throw new Exception("Thời gian bay tối thiểu phải lớn hơn 0");
                }
                QuyDinh.ThoiGianDungToiDa = temp;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return;
            }
            if (QuyDinh_BUS.ThayDoiQuyDinhCB())
            {
                MessageBox.Show("Thay đổi thành công");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
