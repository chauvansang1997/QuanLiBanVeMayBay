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
using System.Threading;
using Help_Fuction;
using DTO;


namespace GUI
{
    public partial class FORM_TRACUU_CHUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;


        public FORM_TRACUU_CHUYENBAY(State state)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Search_icon1;
            pageNumber = 1;
            dGVDanhSachCB.SelectionChanged += DGVDachSanhCB_SelectionChanged;

            if (state == State.TraCuu)
            {
                btnDatCho.Visible = false;
                btnDatVe.Visible = false;
            }
            Init();
        }

        private void Init()
        {


            dGVDanhSachCB.TopLeftHeaderCell.Value = "STT";
            dGVDanhSachCB.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            dGVDSHangGhe.TopLeftHeaderCell.Value = "STT";
            dGVDSHangGhe.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            dGVSanBayTG.TopLeftHeaderCell.Value = "STT";
            dGVSanBayTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
        }

        /// <summary>
        /// Sự kiện nhấn vào các chuyến bay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVDachSanhCB_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGV = sender as DataGridView;



            if (dataGV.SelectedRows.Count == 0)
            {

                dGVDSHangGhe.DataSource = ChuyenBay_BUS.TraCuuSoGhe("");
                dGVSanBayTG.DataSource = ChuyenBay_BUS.TraCuuSBTG("");
            }
            if (dataGV.SelectedRows.Count > 0)
            {
                dGVDSHangGhe.Columns.Clear();
                dGVDSHangGhe.DataSource = ChuyenBay_BUS.TraCuuSoGhe(dataGV.SelectedRows[0].Cells[0].Value.ToString());

                this.dGVDSHangGhe.Columns[0].Visible = false;

                dGVSanBayTG.Columns.Clear();
                dGVSanBayTG.DataSource = ChuyenBay_BUS.TraCuuSBTG(dataGV.SelectedRows[0].Cells[0].Value.ToString());

                this.dGVSanBayTG.Columns[0].Visible = false;
            }
        }



        private void bnt_Find_Click(object sender, EventArgs e)
        {
            isClick = true;
            string sanbaydi = cmbSanBayDi.Text;
            string sanbayden = cmbSanBayDen.Text;
            DateTime ngayKHTu = dtPKNgayKHTu.Value;
            DateTime ngayKHDen = dtPKNgayKhDen.Value;

            totalPage = ChuyenBay_BUS.DemChuyenBay(sanbaydi, sanbayden, ngayKHTu, ngayKHDen);

            totalPage=HelpFuction.TinhKichThuocTrang(totalPage,pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();
           
            //dGVDachSanhCB.Columns.Clear();
            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, ngayKHTu, ngayKHDen);
        }


        /// <summary>
        /// Sự kiện nhấn vào trang đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }
        /// <summary>
        /// Sự kiện nhấn vào trang cuối
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }
        /// <summary>
        /// Sự kiện nhấn vào trang trước
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }
        /// <summary>
        /// Sự kiện nhấn vào trang sau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }



        //Sự kiện load form
        private void FORM_TRACUU_CHUYENBAY_Load(object sender, EventArgs e)
        {
            SanBay_BUS.LoadSanBay(cmbSanBayDi);
           

            totalPage = ChuyenBay_BUS.DemChuyenBay(null, null, null, null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();


            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
        }
        //Sự kiện khi thay đổi chọn giá trị trong sân bay đi
        private void cmbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            if (combobox != null)
            {
                if (combobox.SelectedItem != null)
                {
                    SanBay sanbay = combobox.SelectedItem as SanBay;

                    SanBay_BUS.LoadSanBayDen(sanbay.MaSanBay, cmbSanBayDen);
                }

            }

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVSanBayTG_SelectionChanged(object sender, EventArgs e)
        {
            dGVSanBayTG.ClearSelection();
        }

        private void dGVSanBayTG_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVSanBayTG_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDSHangGhe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDSHangGhe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDachSanhCB_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDachSanhCB_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVDanhSachCB.SelectedRows.Count > 0 && dGVDSHangGhe.SelectedRows.Count > 0)
                {
                    DataGridViewCellCollection cells = dGVDSHangGhe.SelectedRows[0].Cells;
                    int soGheTrong = (int)cells[3].Value;
                    if (soGheTrong > 0)
                    {
                        string maChuyenBay = dGVDanhSachCB.SelectedRows[0].Cells[0].Value.ToString();
                        string maHangVe = cells[0].Value.ToString();
                        string tenHangVe= cells[1].Value.ToString();
                        string giaVe = cells[4].Value.ToString();
                        this.Hide();
                        FORM_THEMPHIEUDATCHO form = new FORM_THEMPHIEUDATCHO(maChuyenBay,tenHangVe,maHangVe,giaVe);
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Chuyến bay đã đầy chỗ");
                    }
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVDanhSachCB.SelectedRows.Count > 0 && dGVDSHangGhe.SelectedRows.Count > 0)
                {
                    DataGridViewCellCollection cells = dGVDSHangGhe.SelectedRows[0].Cells;
                    int soGheTrong = (int)cells[3].Value;
                    if (soGheTrong > 0)
                    {
                        string maChuyenBay = dGVDanhSachCB.SelectedRows[0].Cells[0].Value.ToString();
                        string maHangVe = cells[0].Value.ToString();
                        string tenHangVe = cells[1].Value.ToString();
                        string giaVe = cells[4].Value.ToString();
                        this.Hide();
                        FORM_GHINHANDATVE form = new FORM_GHINHANDATVE(maChuyenBay, tenHangVe, maHangVe, giaVe);
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Chuyến bay đã đầy chỗ");
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
