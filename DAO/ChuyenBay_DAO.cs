using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dataprovider;
using System.Data;

namespace DAO
{
    public class ChuyenBay_DAO
    {
        private static ChuyenBay_DAO instance;

        public  static ChuyenBay_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChuyenBay_DAO();
                return instance;
            }
           
        }
        public DataTable XemChuyenBay()
        {
            DataTable chuyenbay = new DataTable();

            string query = "Select * from CHUYENBAY";
            //Dataprovider.Dataprovider.Instance.ExcuteNonQuery();
            chuyenbay = Dataprovider.Dataprovider.Instance.ExcuteQuery(query);
            return chuyenbay;
        }
    }
}
