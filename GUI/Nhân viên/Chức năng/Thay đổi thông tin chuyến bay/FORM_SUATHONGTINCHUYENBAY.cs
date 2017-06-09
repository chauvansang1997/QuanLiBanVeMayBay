using BUS;
using DTO;
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
    public partial class FORM_SUATHONGTINCHUYENBAY : Form
    {
        private string maChuyenBay;

        private bool isChange = false ;
        public FORM_SUATHONGTINCHUYENBAY(string _maChuyenBay,DateTime ngayGio)
        {
            InitializeComponent();

            maChuyenBay = _maChuyenBay;

            dGVSanBayTG.TopLeftHeaderCell.Value = "STT";
            dGVSanBayTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
        }

        private void btnThemSanBayTG_Click(object sender, EventArgs e)
        {
            isChange = true;
            if (dGVSanBayTG.Rows.Count == QuyDinh.SoSanBayTGToiDa)
            {
                string message = string.Format("Bạn chỉ được phép nhập tối đa {0} {1}", QuyDinh.SoSanBayTGToiDa, "sân bay trung gian");
                MessageBox.Show(message);
            }
            else
            {
                FORM_SANBAYTRUNGGIAN form = new FORM_SANBAYTRUNGGIAN(dGVSanBayTG,null,null);

                form.ShowDialog();


            }

        }

        private void btnXoaSanBayTG_Click(object sender, EventArgs e)
        {
            isChange = true;
            if (dGVSanBayTG.RowCount > 0 && dGVSanBayTG.SelectedRows.Count > 0)
            {
                dGVSanBayTG.Rows.Remove(dGVSanBayTG.SelectedRows[0]);
            }
        }

        private void FORM_SUATHONGTINCHUYENBAY_Load(object sender, EventArgs e)
        {
            dGVSanBayTG.DataSource = ChuyenBay_BUS.TraCuuSBTG(maChuyenBay);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                try
                {
                    //if(dtPKNgayGioKH.Value <)
                    //{
                    //    MessageBox.Show("Ngày giờ bay phải")
                    //}
                    if (!ChuyenBay_BUS.XoaSanBayTrungGian(maChuyenBay))
                    {
                        MessageBox.Show("Đã có lỗi xảy ra");
                        return;
                    }
                    if (dGVSanBayTG.RowCount > 0)
                    {
                        for (int i = 0; i < dGVSanBayTG.RowCount; i++)
                        {
                            DataGridViewRow row = dGVSanBayTG.Rows[i];
                            string maSanBay = row.Cells[0].Value.ToString();
                            int thoiGianDung = (int)row.Cells[2].Value;
                            string ghiChu = row.Cells[3].Value.ToString();
                            ChuyenBay_BUS.NhapChiTietChuyenBay(maChuyenBay, maSanBay, thoiGianDung, ghiChu);
                        }
                    }
                }
                catch (Exception err)
                {
                    HelpFuction.Log(err);
                    
                }
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVSanBayTG_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dGVSanBayTG_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
    }
}
