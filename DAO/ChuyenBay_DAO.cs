using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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

        

        public List<string> LoadMaCB()
        {
            

            string query = "Select MaChuyenBay from CHUYENBAY";
            DataTable table= Dataprovider.Instance.ExcuteQuery(query); ;
            //Chuyển Table thành List
            List<string> danhSachMCB = table.AsEnumerable()
            .Select(row =>row.Field<string>("MaChuyenBay")).ToList();
           
            return danhSachMCB;
        }
        public void NhanLichCB()
        {

        }
    }
}
