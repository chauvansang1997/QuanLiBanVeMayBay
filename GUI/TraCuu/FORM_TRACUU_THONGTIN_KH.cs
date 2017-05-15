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
    public partial class FORM_TRACUU_THONGTIN_KH : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        public FORM_TRACUU_THONGTIN_KH()
        {
            InitializeComponent();
            AddColumns();
        }

        private void AddColumns()
        {
            DataTable table = new DataTable();

        }
    }
}
