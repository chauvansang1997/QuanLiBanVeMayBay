using BUS;
using Custom;
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

            Event();
    
        }

        private void Event()
        {            
            cmbSanBayDen.Scroll += CmbSanBayDen_Scroll1;
            

        }

        private void CmbSanBayDen_Scroll1(object sender, ScrollInfo e)
        {
            MyComboBox cmb = sender as MyComboBox;
           
                
                if (e.Info.nPos + 3 >= e.Info.nMax)
                {
                   
                }
          
            
        }


        private void FORM_NHANLICHCHUYENBAY_Load(object sender, EventArgs e)
        {

            SanBay_BUS.Instance.LoadSanBayDi(cmbSanBayDi);

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int giave = Convert.ToInt32(txtGiaVe);
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai định dạng của giá vé");
                return;
            }

            try
            {
                int thoigianbay =Convert.ToInt32( txtThoiGianBay.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Nhập sai định dạng của thời gian bay");
                return;
            }

            if (dtpkNgayKhoiHanh.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày giờ phải lớn hơn hoặc bằng ngày hiện tại");
            }


            //ChuyenBay_BUS.Instance.NhanLichChuyenBay(cmbSanBayDi.Text,cmbSanBayDen.Text,
        }

        //Sự kiện chọn sân bay đi
        private void cmbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
