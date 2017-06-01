using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    /// <summary>
    /// Lớp này thực hiện các chức năng tra cứu bao gồm: tra cứu chuyến bay, tra cứu thông tin khách hàng, tra cứu thông tin nhân viên
    /// </summary>
    public class TraCuu_DAO
    {
        
        private static TraCuu_DAO instance;

        /// <summary>
        /// Thể hiện Singleton của lớp TraCuu_DAO
        /// </summary>
        public static TraCuu_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraCuu_DAO();
                return instance;
            }

        }

        private TraCuu_DAO()
        {

        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chuyenbay"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public DataTable TraCuuChuyenBay(ChuyenBay_TraCuu chuyenbay,int pageSize, int pageNumber)
        {
            string query = "EXEC TRACUU_CHUYENBAY @SanBayDi,@SanBayDen,@ngayKHTu,@NgayKHDen,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.NVarChar){IsNullable=true,Value=chuyenbay.SanBayDi??(Object)DBNull.Value},

                new SqlParameter("@SanBayDen",SqlDbType.NVarChar){IsNullable=true,Value=chuyenbay.SanBayDen??(Object)DBNull.Value},

                new SqlParameter("@NgayKHTu",SqlDbType.DateTime){  IsNullable=true, Value = chuyenbay.NgayKHTu ??(Object)DBNull.Value},

                new SqlParameter("@NgayKHDen",SqlDbType.DateTime){IsNullable=true, Value = chuyenbay.NgayKHDen ??(Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.Int){Value=pageSize},

                new SqlParameter("@pageNumber",SqlDbType.Int){Value=pageNumber},
            };

            DataTable dSchuyenbay = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());


            return dSchuyenbay;
        }

        public DataTable TraCuuSoGhe(string _maChuyenBay)
        {
            string query = "EXEC TRACUU_SOGHETRONG @machuyenbay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@machuyenbay",SqlDbType.VarChar){Value=_maChuyenBay},
            };

            DataTable danhsachSoGhe = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());


            return danhsachSoGhe;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maCB"></param>
        /// <returns></returns>
        public DataTable TraCuuSanBayTG(string _maCB)
        {
            DataTable sanbayTG = new DataTable();

            string query= "EXEC TRACUU_SANBAYTG @maChuyenBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value=_maCB},
            };

            sanbayTG = Dataprovider.Instance.ExcuteQuery(query,parameters.ToArray());

            return sanbayTG;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_hanhKhach"></param>
        /// <returns></returns>
        public DataTable TraCuuHK(HanhKhach _hanhKhach, int pageSize, int pageNumber)
        {
            string query = "EXEC sp_TimHanhKhach @TenKH,@CMND,@SoDT,@pageSize,@pageNumber";
           
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenKH",SqlDbType.NVarChar){IsNullable=true,Value=_hanhKhach.Name?? (Object)DBNull.Value },

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_hanhKhach.CMND?? (Object)DBNull.Value},

                new SqlParameter("@SoDT",SqlDbType.VarChar){IsNullable=true,Value=_hanhKhach.SoDT ?? (Object)DBNull.Value},


                new SqlParameter("@pageSize",SqlDbType.VarChar){Value=pageSize},

                new SqlParameter("@pageNumber",SqlDbType.VarChar){Value=pageNumber},
            };

            DataTable danhsachKH = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());

            return danhsachKH;
        }  

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nhanVien"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public DataTable TraCuuNV(NhanVien _nhanVien,int pageSize, int pageNumber)
        {
            string query = "EXEC sp_TimNhanVien @MaNhanVien,@TenNhanVien,@SoDT,@CMND,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.MaNV?? (Object)DBNull.Value},

                new SqlParameter("@TenNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.TenNV?? (Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.CMND?? (Object)DBNull.Value},

                new SqlParameter("@SoDT",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.SoDT?? (Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.VarChar){Value=pageSize},

                new SqlParameter("@pageNumber",SqlDbType.VarChar){Value=pageNumber},
            };

            DataTable danhsachNV = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());

            return danhsachNV;
        }

       
    }
}