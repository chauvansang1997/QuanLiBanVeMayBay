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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chuyenbay"></param>
        /// <returns></returns>
        public int DemSoChuyenBay(ChuyenBay_TraCuu chuyenbay)
        {
            string query = "EXEC DEM_CHUYENBAY @SanBayDi,@SanBayDen,@NgayKHTu,@NgayKHDen";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.NVarChar){IsNullable=true,Value=chuyenbay.SanBayDi??(Object)DBNull.Value},

                new SqlParameter("@SanBayDen",SqlDbType.NVarChar){IsNullable=true,Value=chuyenbay.SanBayDen??(Object)DBNull.Value},

                new SqlParameter("@NgayKHTu",SqlDbType.DateTime){  IsNullable=true, Value = chuyenbay.NgayKHTu ??(Object)DBNull.Value},

                new SqlParameter("@NgayKHDen",SqlDbType.DateTime){IsNullable=true, Value = chuyenbay.NgayKHDen ??(Object)DBNull.Value},
            };
;

            DataTable count = Dataprovider.Instance.ExcuteQuery(query,parameters.ToArray());

            return count.Rows.Count;
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

        private void TraCuuSoGhe(string _maChuyenBay)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maCB"></param>
        /// <returns></returns>
        public List<SanBayTrungGian> TraCuuSanBayTG(string _maCB)
        {
            DataTable _sanbayTG = new DataTable();

            string query="";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaCB",SqlDbType.VarChar){Value=_maCB},
            };

            _sanbayTG = Dataprovider.Instance.ExcuteQuery(query,parameters.ToArray());

            List<SanBayTrungGian> list_sanbayTG=new List<SanBayTrungGian>();
            int sTT = 1;
            foreach (var item in _sanbayTG.AsEnumerable())
            {
                SanBayTrungGian sanbayTG = new SanBayTrungGian() { TenSanBay = item["TenSanBay"].ToString(), STT = sTT,
                                                                GhiChu=item["GhiChu"].ToString(), ThoiGianDung = Convert.ToInt32( item["ThoiGianDung"]) };
                list_sanbayTG.Add(sanbayTG);
                sTT++;
            }

            return list_sanbayTG;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_hanhKhach"></param>
        /// <returns></returns>
        public DataTable TraCuuHK(HanhKhach _hanhKhach, int pageSize, int pageNumber)
        {
            string query = "";
           
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenKH",SqlDbType.NVarChar){Value=_hanhKhach.Name },
                new SqlParameter("@CMND",SqlDbType.VarChar){Value=_hanhKhach.CMND},
                new SqlParameter("@SoDT",SqlDbType.VarChar){Value=_hanhKhach.SoDT },
            };

            DataTable danhsachKH = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());

            return danhsachKH;
        }  

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_hanhKhach"></param>
        /// <returns></returns>
        public int DemSoHanhKhach(HanhKhach _hanhKhach)
        {

            string query = "";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.NVarChar){Value=_hanhKhach.Name},

                new SqlParameter("@SanBayDen",SqlDbType.VarChar){Value=_hanhKhach.CMND},

                new SqlParameter("@NgayKHTu",SqlDbType.VarChar){Value=_hanhKhach.SoDT},

            };

            DataTable count = Dataprovider.Instance.ExcuteQuery(query,parameters.ToArray());

            return count.Rows.Count;
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
            string query = "";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaNhanVien",SqlDbType.NVarChar){Value = _nhanVien.MaNV},

                new SqlParameter("@TenNhanVien",SqlDbType.NVarChar){Value = _nhanVien.TenNV},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value=_nhanVien.CMND},

                new SqlParameter("@SoDT",SqlDbType.VarChar){Value=_nhanVien.SoDT},

            };

            DataTable danhsachNV = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());

            return danhsachNV;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nhanVien"></param>
        /// <returns></returns>
        public int DemSoNhanVien(NhanVien _nhanVien)
        {

            string query = "";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaNhanVien",SqlDbType.NVarChar){Value = _nhanVien.MaNV},

                new SqlParameter("@TenNhanVien",SqlDbType.NVarChar){Value = _nhanVien.TenNV},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value=_nhanVien.CMND},

                new SqlParameter("@SoDT",SqlDbType.VarChar){Value=_nhanVien.SoDT},

            };

            DataTable count = Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());

            return count.Rows.Count;
        }
    }
}
