using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChuyenBay_TraCuu
    {
        private string sanBayDi;
        private string sanBayDen;
        private DateTime ngayKHTu;
        private DateTime ngayKHDen;

        public string SanBayDi
        {
            get
            {
                return sanBayDi;
            }

            set
            {
                sanBayDi = value;
            }
        }

        public string SanBayDen
        {
            get
            {
                return sanBayDen;
            }

            set
            {
                sanBayDen = value;
            }
        }

        public DateTime NgayKHTu
        {
            get
            {
                return ngayKHTu;
            }

            set
            {
                ngayKHTu = value;
            }
        }

        public DateTime NgayKHDen
        {
            get
            {
                return ngayKHDen;
            }

            set
            {
                ngayKHDen = value;
            }
        }
    }
}
