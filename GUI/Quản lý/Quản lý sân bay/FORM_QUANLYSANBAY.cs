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
namespace GUI
{
    public partial class FORM_QUANLYSANBAY : Form
    {

        private int page;
        private const int pageSize = 10;
        public FORM_QUANLYSANBAY()
        {
            InitializeComponent();
            KhoiTao();
            LoadSanBay();
        }

        private void KhoiTao()
        {
            page = 1;
        }

        public void LoadSanBay()
        {
            SanBay_BUS.Instance.XemSanBay(dataGridView1, page, pageSize);
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page=pageSize;
            }        
            
            SanBay_BUS.Instance.XemSanBay(dataGridView1, page, pageSize);
        }

        private void btnTrangSau_Click(object sender, EventArgs e)
        {
            if (page == pageSize)
            {
                page = 1;
            }
            SanBay_BUS.Instance.XemSanBay(dataGridView1, page, pageSize);
        }
    }
}
