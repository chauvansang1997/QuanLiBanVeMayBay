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

        private State mystate;


        private DateTime ngayKHTu;
        private DateTime ngayKHDen;

        private string sanbaydi;
        private string sanbayden;
        /// <summary>
        /// Sự kiện load form
        /// </summary>
        /// <param name="state"></param>
        public FORM_TRACUU_CHUYENBAY(State state)
        {
            mystate = state;
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


        /// <summary>
        /// Sự kiện nhấn nút tìm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnt_Find_Click(object sender, EventArgs e)
        {
            isClick = true;
            sanbaydi = cmbSanBayDi.Text;
            sanbayden = cmbSanBayDen.Text;
            ngayKHTu = dtPKNgayKHTu.Value;
            ngayKHDen = dtPKNgayKhDen.Value;

            //Kiểm tra ngày khởi hành từ và ngày khởi hành đến
            if (DateTime.Compare(ngayKHTu, ngayKHDen) > 0)
            {
                MessageBox.Show("Ngày khởi hành từ phải sớm hơn ngày khởi hành đến");
                return;
            }

            //Nếu form này dùng cho việc đặt vé và đặt chỗ thì kiểm tra so với quy định
            if (mystate == State.DatVe)
            {
                int day = QuyDinh.ThoiGianChamNhatDatVe*24;
                
                if (DateTime.Compare(ngayKHTu, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(day)) < 0)
                {
                    MessageBox.Show("Bạn chỉ có thể tìm những chuyến bay khởi hành có ngày lớn hơn ngày hiện tại " + day + " ngày");
                    return;
                }
            }
           

            totalPage = ChuyenBay_BUS.DemChuyenBay(sanbaydi, sanbayden, ngayKHTu, ngayKHDen);

            totalPage=HelpFuction.TinhKichThuocTrang(totalPage,pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();
           

            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
        }


        #region Thêm trang
        /// <summary>
        /// Sự kiện nhấn vào trang đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (mystate == State.DatVe)
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(QuyDinh.ThoiGianChamNhatDatVe * 24), null);
                }
            }
            else
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
                }
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
            if (mystate == State.DatVe)
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(QuyDinh.ThoiGianChamNhatDatVe * 24), null);
                }
            }
            else
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
                }
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

            if (mystate == State.DatVe)
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(QuyDinh.ThoiGianChamNhatDatVe * 24), null);
                }
            }
            else
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
                }
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
            if (mystate == State.DatVe)
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(QuyDinh.ThoiGianChamNhatDatVe * 24), null);
                }
            }
            else
            {
                if (isClick)
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                }
                else
                {
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
                }
            }
            
        }
        #endregion


        //Sự kiện load form
        private void FORM_TRACUU_CHUYENBAY_Load(object sender, EventArgs e)
        {
            SanBay_BUS.LoadSanBayDi(cmbSanBayDi);

            if (mystate == State.DatVe)
            {
                int hours = QuyDinh.ThoiGianChamNhatDatVe * 24;

                totalPage = ChuyenBay_BUS.DemChuyenBay(null, null, DateTime.Now+HelpFuction.ConvertHoursToTotalDays(hours), null);
            }
            else
            {
                totalPage = ChuyenBay_BUS.DemChuyenBay(null, null, null, null);
            }

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();

            if (mystate == State.DatVe)
            {
               
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now+HelpFuction.ConvertHoursToTotalDays(QuyDinh.ThoiGianChamNhatDatVe * 24), null);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }

            
        }
        //Sự kiện khi thay đổi chọn giá trị trong sân bay đi

       /// <summary>
       /// Sự kiện khi chọn sân bay đi thì sân bay đến tự động thay đổi
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
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

        #region Tạo số thứ tự cho dataGriView
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
#endregion

        /// <summary>
        /// Sự kiện nhấn nút đặt chỗ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                        if (isClick)
                        {
                            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                        }
                        else
                        {
                            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(QuyDinh.ThoiGianChamNhatDatVe * 24), null);
                        }
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

        /// <summary>
        /// Sự kiện nhấn nút đặt vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        if (isClick)
                        {
                            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(sanbaydi, sanbayden, pageSize, pageNumber, ngayKHTu, ngayKHDen);
                        }
                        else
                        {
                            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(QuyDinh.ThoiGianChamNhatDatVe * 24), null);
                        }
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
