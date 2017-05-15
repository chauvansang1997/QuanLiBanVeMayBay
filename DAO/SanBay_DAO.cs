using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanBay_DAO
    {
        private static SanBay_DAO instance;

        public static SanBay_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanBay_DAO();
                return instance;
            }

        }
        public DataTable XemSanBay(int _page,int _pageSize)
        {
            DataTable sanbay = new DataTable();

            int PreviousPageOffSet = (_page - 1) * _pageSize;

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT TOP {0} * FROM SANBAY WHERE MaSanBay NOT INT", _pageSize);
            query.AppendFormat("(SELECT TOP {0} MaSanBay FROM SANBAY ORDER BY MaSanBay)",PreviousPageOffSet);
            

            sanbay = Dataprovider.Instance.ExcuteQuery(query.ToString());
            return sanbay;
        }


        public bool XoaSanBay(string _maSanBay)
        {
            string query="Delete SanBay when MaSanBay=@MaSanBay";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaSanBay",SqlDbType.VarChar){Value=_maSanBay}
            };

            if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
            {
                return false;
            }
            return false;
        }
        public List<string> LoadMSB()
        {
            string query = "Select MaChuyenBay from SANBAY";
            DataTable table = Dataprovider.Instance.ExcuteQuery(query); ;
            //Chuyển Table thành List
            List<string> danhSachMCB = table.AsEnumerable()
            .Select(row => row.Field<string>("MaSanBay")).ToList();

            return danhSachMCB;
        }
    }
}
