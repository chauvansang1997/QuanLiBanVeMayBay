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
    public partial class FORM_TRACUU_CHUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        public FORM_TRACUU_CHUYENBAY()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Search_icon1;
            pageNumber = 0;
        }

        private void bnt_Find_Click(object sender, EventArgs e)
        {           

            ChuyenBay_BUS.Instance.XemChuyenBay(dGVDachSanhSB, dGVSanBayTG, pageSize, pageNumber);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }
    }
}
