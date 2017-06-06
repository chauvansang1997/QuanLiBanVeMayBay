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
        private DataGridView danhsachSBTG;
        public FORM_SANBAYTRUNGGIAN(DataGridView _danhsachSBTG)
        {
            this.danhsachSBTG = _danhsachSBTG;
            InitializeComponent();
        }

        private void btnThemSanBayTG_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (danhsachSBTG.Rows.Count == QuyDinh.SoSanBayTGToiDa)
            {
                string message = string.Format("Bạn chỉ được phép nhập tối đa {0} {1}", QuyDinh.SoSanBayTGToiDa, "sân bay trung gian");
                MessageBox.Show(message);
                return;
            }

            try
            {
                if (HelpFuction.IsContainsText(txtThoiGianDung.Text))
                {
                    throw new Exception("Thời gian dừng chỉ chứa số");
                }
                foreach (var item in cmbSanBay.Items)
                {
                    SanBay sanbay = item as SanBay;
                    if (sanbay.TenSanBay == cmbSanBay.Text)
                    {
                        check++;
                        break;
                    }
                }
                if (check == 0)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_SANBAYTRUNGGIAN_Load(object sender, EventArgs e)
        {
            if (danhsachSBTG.SelectedRows.Count > 0)
            {
                //ChuyenBay_BUS.LoadSanBayTG()
                ChuyenBay_BUS.LoadDanhSachSanBayTG(cmbSanBay, danhsachSBTG.SelectedRows[0].Cells[0].Value.ToString());
            }
                   
        }
    }
}
