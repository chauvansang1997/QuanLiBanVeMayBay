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
using Help_Fuction;
using DTO;

namespace GUI
{
    public partial class FORM_QUANLYTUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private string sanBayDi;
        private string sanBayDen;
        private bool isClick = false;
        public FORM_QUANLYTUYENBAY()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sự kiện nhấn nút thêm tuyến bay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            FORM_THEMMOITUYENBAY form = new FORM_THEMMOITUYENBAY();
            form.ShowDialog();
            dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
            dGVDanhSachTB.Columns[1].Visible = false;
            dGVDanhSachTB.Columns[3].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sự kiện nhấn nút tìm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            isClick = true;

            bool check = false;

            foreach (var item in cmbSanBayDi.Items)
            {
                SanBay sanbay = item as SanBay;
                if (sanbay.TenSanBay == cmbSanBayDi.Text)
                {
                    check = true;
                }
            }
            if (!check)
            {
                MessageBox.Show("Sân bay đi không có trong danh sách");
                return;
            }
            check = false;
            foreach (var item in cmbSanBayDen.Items)
            {
                SanBay sanbay = item as SanBay;
                if (sanbay.TenSanBay == cmbSanBayDen.Text)
                {
                    check = true;
                }
            }
            if (!check)
            {
                MessageBox.Show("Sân bay đến không có trong danh sách");
                return;
            }

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            totalPage = TuyenBay_BUS.DemTuyenBay(sanBayDi, sanBayDen);
            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(sanBayDi, sanBayDen, pageSize, pageNumber);
            dGVDanhSachTB.Columns[1].Visible = false;
            dGVDanhSachTB.Columns[3].Visible = false;

        }
        #region Thêm trang
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(sanBayDi, sanBayDen, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 == 0)
            {
                pageNumber = 1;
            }
            else
            {
                --pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(sanBayDi, sanBayDen, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNumber + 1 > totalPage)
            {
                pageNumber = 1;
            }
            else
            {
                ++pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(sanBayDi, sanBayDen, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(sanBayDi, sanBayDen, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
        }
        #endregion
        /// <summary>
        /// Sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FORM_QUANLYTUYENBAY_Load(object sender, EventArgs e)
        {
            dGVDanhSachTB.TopLeftHeaderCell.Value = "STT";
            dGVDanhSachTB.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            pageNumber = 1;
            totalPage = TuyenBay_BUS.DemTuyenBay(null, null);



            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            SanBay_BUS.LoadSanBayDi(cmbSanBayDi);


            dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
            dGVDanhSachTB.Columns[1].Visible = false;
            dGVDanhSachTB.Columns[3].Visible = false;
        }

        /// <summary>
        /// Sự kiện chọn sân bay đi sân bay đến tự dộng chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbSanBayDi.SelectedItem != null)
            {
                SanBay sanbay = cmbSanBayDi.SelectedItem as SanBay;
                SanBay_BUS.LoadSanBayDen(sanbay.MaSanBay, cmbSanBayDen);
                sanBayDi = sanbay.MaSanBay;
            }
        }
        #region Thêm số thứ tự cho DataGridView
        private void dGVDanhSachTB_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDanhSachTB_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }
        #endregion

        private void cmbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSanBayDen.SelectedItem != null)
            {
                SanBay sanbay = cmbSanBayDen.SelectedItem as SanBay;

                sanBayDen = sanbay.MaSanBay;
            }
        }
    }
}
