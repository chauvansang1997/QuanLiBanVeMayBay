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
using System.Threading;
using Help_Fuction;

namespace GUI
{
    public partial class FORM_THAYDOICHUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;
        
        public FORM_THAYDOICHUYENBAY()
        {
            InitializeComponent();
            pageNumber = 1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            
            string sanbaydi = cmbSanBayDi.Text;
            string sanbayden = cmbSanBayDen.Text;
            DateTime ngayKHTu = dtPKNgayKHTu.Value;
            DateTime ngayKHDen = dtPKNgayKHDen.Value;
            
            if (DateTime.Compare(ngayKHTu, ngayKHDen) > 0)
            {
                MessageBox.Show("Ngày khởi hành đến phải sau ngày khởi hành từ");
                return;
            }
            if (DateTime.Compare(ngayKHDen, DateTime.Now)<0)
            {
                MessageBox.Show("Không thể chọn ra những chuyến bay có ngày sớm hơn ngày hiện tại");
                return;
            }

            if(DateTime.Compare(ngayKHTu,( DateTime.Now+HelpFuction.ConvertHoursToTotalDays(24) ) )  >0)
            {
                MessageBox.Show("Các chuyến bay phải có ngày khởi hành lớn hơn ngày hiện tại 1 ngày");
                return;
            }

            isClick = true;
            totalPage = ChuyenBay_BUS.DemChuyenBay(sanbaydi, sanbayden, ngayKHTu, ngayKHDen);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();

            
            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, ngayKHTu, ngayKHDen);
        }

        #region     Thay đổi trang 
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(24), null);
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
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(24), null);
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
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(24), null);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(24), null);
            }
        }
        #endregion 



        /// <summary>
        /// Nhấn nút cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dGVDanhSachCB.SelectedRows.Count > 0)
            {
                string maChuyenBay = dGVDanhSachCB.SelectedRows[0].Cells[0].Value.ToString();
                DateTime ngayGioBay= Convert.ToDateTime( dGVDanhSachCB.SelectedRows[0].Cells[3].Value.ToString());
                FORM_SUATHONGTINCHUYENBAY form = new FORM_SUATHONGTINCHUYENBAY(maChuyenBay,ngayGioBay);
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Nhấn nút hủy chuyến bay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGVDanhSachCB.SelectedRows.Count > 0)
            {
                string maChuyenBay = dGVDanhSachCB.SelectedRows[0].Cells[0].Value.ToString();
                if (ChuyenBay_BUS.HuyChuyenBay(maChuyenBay))
                {
                    MessageBox.Show("Hủy thành công");
                    dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now + HelpFuction.ConvertHoursToTotalDays(24), null);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
      
        }

        /// <summary>
        /// Nhấn nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Init()
        {
            dGVDanhSachCB.TopLeftHeaderCell.Value = "STT";
            dGVDanhSachCB.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

        }
        /// <summary>
        /// Sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FORM_THAYDOICHUYENBAY_Load(object sender, EventArgs e)
        {

            Init();

            SanBay_BUS.LoadSanBayDi(cmbSanBayDi);


            totalPage = ChuyenBay_BUS.DemChuyenBay(null, null, null, null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();


            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, DateTime.Now+HelpFuction.ConvertHoursToTotalDays(24), null);


        }

        /// <summary>
        /// Sự kiến thay đổi lựa chọn sân bay đi thì sân bay đến thay đổi theo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
       
        private void cmbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            try
            {
                SanBay sanbaydi = (SanBay)combobox.SelectedValue;
                SanBay_BUS.LoadSanBayDen(sanbaydi.MaSanBay, cmbSanBayDen);
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);
            }
        }

        #region Thêm số thứ tự vào vào các datagridview
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

        private void dGVDanhSachCB_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGV = sender as DataGridView;



           
        }

        private void dGVDanhSachCB_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDanhSachCB_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }
    #endregion
        /// <summary>
        /// Kiểm tra xem ngày khởi hành từ có nhỏ hơn ngày khởi hành đến không
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtPKNgayKHDen_ValueChanged(object sender, EventArgs e)
        {
            int results = DateTime.Compare(dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            if (results > 0)
            {
                errorNgayGio.Icon = Properties.Resources.error_icon1;
                errorNgayGio.SetError(dtPKNgayKHDen, "Ngày khởi hành đến phải sau ngày khởi hành từ");
            }
            else
            {
                errorNgayGio.Clear();
            }
        }
    }
}
