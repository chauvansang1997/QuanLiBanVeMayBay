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

namespace GUI
{
    public partial class FORM_TRACUU_CHUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;
        public FORM_TRACUU_CHUYENBAY()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Search_icon1;
            pageNumber = 1;
            dGVDachSanhCB.SelectionChanged += DGVDachSanhCB_SelectionChanged;
        }

        /// <summary>
        /// Sự kiện nhấn vào các chuyến bay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DGVDachSanhCB_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGV = sender as DataGridView;
            if (dataGV.SelectedRows != null)
            {

            }
        }

        private void bnt_Find_Click(object sender, EventArgs e)
        {
            isClick = true;
            string sanbaydi = cmbSanBayDi.Text;
            string sanbayden = cmbSanBayDen.Text;
            DateTime ngayKHTu =  dtPKNgayKHTu.Value;
            DateTime ngayKHDen = dtPKNgayKhDen.Value;
            ThreadPool.QueueUserWorkItem((p) =>
            {
                totalPage = TraCuu_BUS.Instance.DemChuyenBay(sanbaydi, sanbayden, ngayKHTu, ngayKHDen);
                if (totalPage == 0)
                {
                    txtTotalPage.PerformSafely(() =>
                    {
                        txtTotalPage.Text = "1";
                    });

                }
                else
                {
                    txtTotalPage.PerformSafely(()=>{
                        txtTotalPage.Text = totalPage.ToString();
                    });

                }
            });
           
            //dGVDachSanhCB.Columns.Clear();
            dGVDachSanhCB.DataSource= TraCuu_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text,cmbSanBayDen.Text, pageSize, pageNumber, ngayKHTu, ngayKHDen);
        }

   
        /// <summary>
        /// Sự kiện nhấn vào trang đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstPage_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Sự kiện nhấn vào trang cuối
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastPage_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Sự kiện nhấn vào trang trước
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 == 0 )
            {
                pageNumber = 1;
            }
            else
            {
                --pageNumber;
            }
            if (isClick)
            {
                dGVDachSanhCB.DataSource = TraCuu_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDachSanhCB.DataSource = TraCuu_BUS.Instance.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
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
            if (isClick)
            {
                dGVDachSanhCB.DataSource = TraCuu_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDachSanhCB.DataSource = TraCuu_BUS.Instance.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }

       

        //Sự kiện load form
        private void FORM_TRACUU_CHUYENBAY_Load(object sender, EventArgs e)
        {
            SanBay_BUS.Instance.LoadSanBayDi(cmbSanBayDi);
            string sanbaydi = cmbSanBayDi.Text;
            string sanbayden = cmbSanBayDen.Text;
            ThreadPool.QueueUserWorkItem((p) => {
                
                totalPage = TraCuu_BUS.Instance.DemChuyenBay(null,null , null, null);
                if (totalPage == 0)
                {
                    txtTotalPage.PerformSafely(() =>
                    {
                        txtTotalPage.Text = "1";
                    });
                }
                else
                {
                    txtTotalPage.PerformSafely(() =>
                    {
                        txtTotalPage.Text = totalPage.ToString();
                    });
                   
                }
            });
            dGVDachSanhCB.DataSource = TraCuu_BUS.Instance.TraCuuChuyenBay(null, null, pageSize, pageNumber,null,null);
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
                    
                    SanBay_BUS.Instance.LoadSanBayDen(sanbay.MaSanBay, cmbSanBayDen);
                }

            }
            
        }


    }
}
