using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVien_DAO
    {
        private static NhanVien_DAO instance;

        public static NhanVien_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVien_DAO();
                return instance;
            }

        }

        private NhanVien_DAO()
        {

        }
        public List<string> LoadNhanVien()
        {
            string query = "SELECT NV.TenNhanVien[Tên Nhân Viên]  FROM NHANVIEN NV ";

            //Lấy dữ liệu lên
            DataTable table = Dataprovider.Instance.ExcuteQuery(query);

            //Chuyển Table thành List gồm có tên sân bay đi  và tên sân bay đến
            List<string> danhsachNV = table.AsEnumerable().ToList().ConvertAll(x =>
                 x[0].ToString());


            return danhsachNV;
        }

    }
}
