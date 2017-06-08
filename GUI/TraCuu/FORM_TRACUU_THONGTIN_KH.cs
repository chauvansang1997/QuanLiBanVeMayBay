using BUS;
using Help_Fuction;
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
    public partial class FORM_TRACUU_THONGTIN_KH : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private bool isClick;

        public FORM_TRACUU_THONGTIN_KH()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Search_icon1;
            pageNumber = 1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            isClick = true;

            totalPage = HanhKhach_BUS.DemHanhKhach(cmbTenHK.Text,txtSoDT.Text,txtCMND.Text);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();

           
            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();
            dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(cmbTenHK.Text, txtCMND.Text, txtSoDT.Text,pageSize,pageNumber);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(cmbTenHK.Text, txtCMND.Text, txtSoDT.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(null, null, null, pageSize, pageNumber);
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
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(cmbTenHK.Text, txtCMND.Text, txtSoDT.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(null, null, null, pageSize, pageNumber);
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
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(cmbTenHK.Text, txtCMND.Text, txtSoDT.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(null, null, null, pageSize, pageNumber);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(cmbTenHK.Text, txtCMND.Text, txtSoDT.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(null, null, null, pageSize, pageNumber);
            }
        }

        private void dGVDanhSachHK_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToUInt32(txtPageNumber.Text) <= totalPage)
                {
                    pageNumber = (int)Convert.ToUInt32(txtPageNumber.Text);

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                txtPageNumber.Text = pageNumber.ToString();
            }
        }

        private void FORM_TRACUU_THONGTIN_KH_Load(object sender, EventArgs e)
        {
            dGVDanhSachHK.TopLeftHeaderCell.Value = "STT";
            dGVDanhSachHK.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            HanhKhach_BUS.LoadHanhKhach(cmbTenHK);


            totalPage = HanhKhach_BUS.DemHanhKhach(null, null, null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();

            dGVDanhSachHK.Columns.Clear();
            dGVDanhSachHK.DataSource = HanhKhach_BUS.TraCuuHanhKhach(null, null, null, pageSize, pageNumber);
        }

        private void dGVDanhSachHK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDanhSachHK_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }
    }
}
