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
    public partial class FORM_THAYDOICHUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        public FORM_THAYDOICHUYENBAY()
        {
            InitializeComponent();
            pageNumber = 0;
        }

        private void bnt_Tim_Click(object sender, EventArgs e)
        {
            //ChuyenBay_BUS.Instance.XemChuyenBay(dGVDanhSachCB, dGVDanhSachSBTG, pageSize, pageNumber);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0)
            {
                return;
            }
            pageNumber--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
