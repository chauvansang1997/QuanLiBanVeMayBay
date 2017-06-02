using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO;


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

        /// <summary>
        /// Nhận lịch chuyến bay
        /// </summary>
        /// <param name="_chuyenbay">Thông tin chuyến bay</param>
        /// <returns></returns>
        public bool NhanLichCB(ChuyenBay _chuyenbay)
        {
            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.VarChar){Value=_chuyenbay.SanBayDi},

                new SqlParameter("@SanBayDen",SqlDbType.VarChar){Value=_chuyenbay.SanBayDen},

                new SqlParameter("@GiaVe",SqlDbType.Int){Value=_chuyenbay.GiaVe},

                new SqlParameter("@ThoiGianBay",SqlDbType.Int){Value=_chuyenbay.ThoiGianBay},

                new SqlParameter("@NgayGioKH",SqlDbType.DateTime){Value=_chuyenbay.NgayGioKH},

            };

          
            for (int i = 0; i < _chuyenbay.SoGheCacHangVe.Count; i++)
            {
                //SqlParameter parameter=new SqlParameter()
            }
            if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Thay đổi thông tin chuyến bay bao gồm: ngày giờ bay, số lượng vé
        /// </summary>
        /// <param name="_maCB">Mã chuyến bay muốn thay đổi</param>
        /// <param name="_chuyenbay">Thông tin mới muốn thay đổi</param>
        /// <returns></returns>
        public bool ThayDoiChuyenBay(string _maCB,ChuyenBay _chuyenbay)
        {
            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@NgayGioKH",SqlDbType.DateTime){Value=_chuyenbay.NgayGioKH},

              
            };

            for (int i = 0; i < _chuyenbay.SoGheCacHangVe.Count; i++)
            {
                //string 
               // SqlParameter parameter=new SqlParameter("@")
            }
            if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Hủy chuyến bay
        /// </summary>
        /// <param name="_maChuyenBay">Mã chuyến bay mà ta muốn xóa</param>
        /// <returns></returns>
        public bool HuyChuyenBay(string _maChuyenBay)
        {
            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaChuyenBay",SqlDbType.VarChar){Value =_maChuyenBay },
            };

            if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chuyenbay"></param>
        /// <returns></returns>
        public int DemSoChuyenBay(string _sanBayDi, string _sanBayDen, DateTime? _ngayKHTu, DateTime? _ngayKHDen)
        {
            string query = "EXEC DEM_CHUYENBAY @SanBayDi,@SanBayDen,@NgayKHTu,@NgayKHDen";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.NVarChar){IsNullable=true,Value=_sanBayDi??(Object)DBNull.Value},

                new SqlParameter("@SanBayDen",SqlDbType.NVarChar){IsNullable=true,Value=_sanBayDen??(Object)DBNull.Value},

                new SqlParameter("@NgayKHTu",SqlDbType.DateTime){  IsNullable=true, Value = _ngayKHTu ??(Object)DBNull.Value},

                new SqlParameter("@NgayKHDen",SqlDbType.DateTime){IsNullable=true, Value =_ngayKHDen ??(Object)DBNull.Value},
            };
            ;

            try
            {
                return Convert.ToInt32(Dataprovider.Instance.ExcuteScalar(query, parameters.ToArray()));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chuyenbay"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public DataTable TraCuuChuyenBay(string SanBayDi, string SanBayDen, DateTime? _ngayKHTu, DateTime? _ngayKHDen, int pageSize, int pageNumber)
        {
            string query = "EXEC TRACUU_CHUYENBAY @SanBayDi,@SanBayDen,@ngayKHTu,@NgayKHDen,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.NVarChar){IsNullable=true,Value=SanBayDi??(Object)DBNull.Value},

                new SqlParameter("@SanBayDen",SqlDbType.NVarChar){IsNullable=true,Value=SanBayDen??(Object)DBNull.Value},

                new SqlParameter("@NgayKHTu",SqlDbType.DateTime){  IsNullable=true, Value = _ngayKHTu ??(Object)DBNull.Value},

                new SqlParameter("@NgayKHDen",SqlDbType.DateTime){IsNullable=true, Value = _ngayKHDen ??(Object)DBNull.Value},

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

            string query = "EXEC TRACUU_SANBAYTG @maChuyenBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value=_maCB},
            };

            sanbayTG = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());

            return sanbayTG;
        }
    }
}
