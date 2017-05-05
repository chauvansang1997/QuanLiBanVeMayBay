using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChuyenBay_TraCuu
    {
        private static ChuyenBay_TraCuu instance;

        public static ChuyenBay_TraCuu Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChuyenBay_TraCuu();
                return instance;
            }

        }
    }
}
