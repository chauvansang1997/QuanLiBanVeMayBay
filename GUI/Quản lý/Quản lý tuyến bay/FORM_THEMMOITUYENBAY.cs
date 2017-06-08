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
using DTO;

namespace GUI
{
    public partial class FORM_THEMMOITUYENBAY : Form
    {
        public FORM_THEMMOITUYENBAY()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in cmbSanBayDi.Items)
            {
                SanBay sanbay = item as SanBay;
                if (sanbay.TenSanBay == cmbSanBayDi.Text)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Sân bay đi không có trong danh sách sân bay");
                return;
            }
            check = false;
            foreach (var item in cmbSanBayDen.Items)
            {
                SanBay sanbay = item as SanBay;
                if (sanbay.TenSanBay == cmbSanBayDen.Text)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Sân bay đến không có trong danh sách sân bay");
                return;
            }
            if (cmbSanBayDi.Text == cmbSanBayDen.Text)
            {
                MessageBox.Show("Sân bay đi và sân bay đến không được trùng nhau");
                return;
            }

          

            SanBay sanBayDi = cmbSanBayDi.SelectedItem as SanBay;
  

            SanBay sanBayDen = cmbSanBayDen.SelectedItem as SanBay;


            if (TuyenBay_BUS.ThemTuyenBay(sanBayDi.MaSanBay, sanBayDen.MaSanBay))
            {
                MessageBox.Show("Thêm tuyến bay thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_THEMMOITUYENBAY_Load(object sender, EventArgs e)
        {
            cmbSanBayDi.DataSource=SanBay_BUS.LoadSanBay();
            cmbSanBayDi.DisplayMember = "TenSanBay";
            cmbSanBayDi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSanBayDi.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbSanBayDen.DataSource = SanBay_BUS.LoadSanBay();
            cmbSanBayDen.DisplayMember = "TenSanBay";
            cmbSanBayDen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSanBayDen.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


    }
}
