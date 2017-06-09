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
    public partial class FORM_HUYVECB : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;

        public FORM_HUYVECB()
        {
            InitializeComponent();
            pageNumber = 1;

        }

      

        private void FORM_HUYVECB_Load(object sender, EventArgs e)
        {
            dGVDanhSachVe.TopLeftHeaderCell.Value = "STT";
            dGVDanhSachVe.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            cmbMaVe.DataSource = HangVe_BUS.LoadMaVe();
            cmbMaVe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMaVe.AutoCompleteSource = AutoCompleteSource.ListItems;


            HanhKhach_BUS.LoadHanhKhachVe(cmbTenHanhKhach);
            cmbTenHanhKhach.DisplayMember = "TenHanhKhach";
            cmbTenHanhKhach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTenHanhKhach.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbCMND.DataSource = cmbTenHanhKhach.DataSource;
            cmbCMND.DisplayMember = "CMND";
            cmbCMND.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCMND.AutoCompleteSource = AutoCompleteSource.ListItems;



            cmbMaChuyenBay.DataSource=ChuyenBay_BUS.LoadChuyenBayVe();
            cmbMaChuyenBay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMaChuyenBay.AutoCompleteSource = AutoCompleteSource.ListItems;



         

            totalPage = VeDat_BUS.DemVe(null, null, null, null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();


            dGVDanhSachVe.DataSource= VeDat_BUS.TraCuuVe(null, null, null, null, pageSize, pageNumber);

        }

        /// <summary>
        /// Tìm phiếu đặt chỗ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            isClick = true;


            totalPage = VeDat_BUS.DemVe(cmbTenHanhKhach.Text,cmbCMND.Text,cmbMaVe.Text , cmbMaChuyenBay.Text);


            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();
            dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(cmbTenHanhKhach.Text, cmbCMND.Text, cmbMaVe.Text, cmbMaChuyenBay.Text, pageSize, pageNumber);
            
        }

        private void btnFristPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(cmbTenHanhKhach.Text, cmbCMND.Text, cmbMaVe.Text, cmbMaChuyenBay.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(null, null, null, null, pageSize, pageNumber);
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
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(cmbTenHanhKhach.Text, cmbCMND.Text, cmbMaVe.Text, cmbMaChuyenBay.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(null, null, null, null, pageSize, pageNumber);
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
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(cmbTenHanhKhach.Text, cmbCMND.Text, cmbMaVe.Text, cmbMaChuyenBay.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(null, null, null, null, pageSize, pageNumber);
            }
        }
    

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(cmbTenHanhKhach.Text,cmbCMND.Text,cmbMaVe.Text,cmbMaChuyenBay.Text,pageSize,pageNumber);
            }
            else
            {
                dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(null,null,null,null, pageSize, pageNumber);
            }
        }

        private void dGVDanhSachVe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDanhSachVe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dGVDanhSachVe.RowCount > 0 && dGVDanhSachVe.SelectedRows.Count >0)
            {
                string maVe = dGVDanhSachVe.SelectedRows[0].Cells[4].Value.ToString();
                if(VeDat_BUS.HuyVe(maVe))
                {
                    if (isClick)
                    {
                        dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(cmbTenHanhKhach.Text, cmbCMND.Text, cmbMaVe.Text, cmbMaChuyenBay.Text, pageSize, pageNumber);
                    }
                    else
                    {
                        dGVDanhSachVe.DataSource = VeDat_BUS.TraCuuVe(null, null, null, null, pageSize, pageNumber);
                    }
                    MessageBox.Show("Hủy thành công");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra");

                }
               
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
