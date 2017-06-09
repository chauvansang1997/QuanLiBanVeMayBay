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
using Help_Fuction;
namespace GUI
{
    public partial class FORM_SANBAYTRUNGGIAN : Form
    {
        private int thoiGianDung=QuyDinh.ThoiGianBayToiThieu;
        private DataGridView danhsachSBTG;

        private string SanBayDi;
        private string SanBayDen;
        public FORM_SANBAYTRUNGGIAN(DataGridView _danhsachSBTG,string _sanBayDi,string _sanBayDen)
        {           
            InitializeComponent();
            this.danhsachSBTG = _danhsachSBTG;
            SanBayDi = _sanBayDi;
            SanBayDen = _sanBayDen;
        }

        /// <summary>
        /// Thêm sân bay trung gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemSanBayTG_Click(object sender, EventArgs e)
        {
            bool check = false;

            //Kiểm tra quy định
            if (danhsachSBTG.Rows.Count == QuyDinh.SoSanBayTGToiDa)
            {
                string message = string.Format("Bạn chỉ được phép nhập tối đa {0} {1}", QuyDinh.SoSanBayTGToiDa, "sân bay trung gian");
                MessageBox.Show(message);
                return;
            }

            try
            {
                //Kiểm tra quy dinh thời gian dùng tối thiểu
                if(Convert.ToInt32(txtThoiGianDung.Text)>=QuyDinh.ThoiGianDungToiThieu)
                {
                    check = true;
                }
                if (!check)
                {
                    throw new Exception(string.Format("Thời gian dừng tối thiểu phải là {0}",QuyDinh.ThoiGianDungToiThieu));
        
                }
                check = false;
                //Kiểm tra thời gian dừng tối đa
                if(Convert.ToInt32(txtThoiGianDung.Text) <= QuyDinh.ThoiGianDungToiDa)
                {
                    check = true;
                }
                if (!check)
                {
                    throw new Exception(string.Format("Thời gian dừng tối đa phải là {0}",QuyDinh.ThoiGianDungToiDa));

                }
                check = false;
                //Kiểm tra xem sân bay đã tồn tại chưa
                foreach (var item in cmbSanBay.Items)
                {
                    SanBay sanbay = item as SanBay;
                    if (sanbay.TenSanBay == cmbSanBay.Text)
                    {
                        check=true;
                        break;
                    }
                }
                if (!check)
                {
                    throw new Exception("Sân bay không có trong danh sách");

                }

                if (cmbSanBay.SelectedItem != null)
                {
                    SanBay sanbay = cmbSanBay.SelectedItem as SanBay;

                    if (danhsachSBTG.Contains(sanbay.MaSanBay, 0))
                    {
                        throw new Exception("Sân bay trung gian đã tồn tại");
                    }
                    int thoigiandung = Convert.ToInt32(txtThoiGianDung.Text);

                    DataTable table = (DataTable)danhsachSBTG.DataSource;

                    DataRow row = table.NewRow();

                    row[0] = sanbay.MaSanBay;
                    row[1] = sanbay.TenSanBay;
                    row[2] = thoigiandung;
                    row[3] = txtGhiChu.Text;
                    table.Rows.Add(row);

                }
                

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FORM_SANBAYTRUNGGIAN_Load(object sender, EventArgs e)
        {
            txtThoiGianDung.Text = QuyDinh.ThoiGianDungToiThieu.ToString();


            if (danhsachSBTG.RowCount > 0)
            {
               cmbSanBay.DataSource= ChuyenBay_BUS.LoadDanhSachSanBayTG(danhsachSBTG.SelectedRows[0].Cells[0].Value.ToString(),SanBayDi,SanBayDen);
                cmbSanBay.DisplayMember = "TenSanBay";
               cmbSanBay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
               cmbSanBay.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                cmbSanBay.DataSource= ChuyenBay_BUS.LoadDanhSachSanBayTG( null, SanBayDi, SanBayDen);
                cmbSanBay.DisplayMember = "TenSanBay";
                cmbSanBay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbSanBay.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        /// <summary>
        /// Tránh nhập kí tự 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtThoiGianDung_TextChanged(object sender, EventArgs e)
        {
            if (txtThoiGianDung.Text == "")
            {
                return;
            }
            if (!HelpFuction.IsContainsText(txtThoiGianDung.Text))
            {

                thoiGianDung = Convert.ToInt32( txtThoiGianDung.Text);

            }
            else
            {
                txtThoiGianDung.Text = thoiGianDung.ToString();
            }
        }
    }
}
