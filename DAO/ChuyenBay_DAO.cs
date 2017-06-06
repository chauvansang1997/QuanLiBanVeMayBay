using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Help_Fuction;

namespace DAO
{
    public static class ChuyenBay_DAO
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_tenSanBay"></param>
        /// <returns></returns>
        public static List<SanBay> LoadDanhSachSBTG(string _tenSanBay)
        {
            string query = " EXEC usp_LoadTenSanBayTG @tenSanBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenSanBay",SqlDbType.NVarChar){IsNullable =true,Value=_tenSanBay??(Object)DBNull.Value},
            };

            try
            {
                List<SanBay> temp = Dataprovider.ExcuteQuery(query, parameters.ToArray()).AsEnumerable().ToList().ConvertAll(x =>
                  new SanBay(x[0].ToString(), x[1].ToString()));
                return temp;
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return null;
            }
          
        }

        public static bool XoaSanBayTrungGian(string _maChuyenBay)
        {
            string query = " EXEC usp_XoaSanBayTrungGian @maChuyenBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChuyenBay",SqlDbType.NVarChar){Value=_maChuyenBay},
            };
            try
            {
                if (Dataprovider.ExcuteNonQuery(query,parameters.ToArray()) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);
                return false;
            }
           
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="_tenSanBay"></param>
       /// <returns></returns>
        public static DataTable LoadDanhSachSBTG()
        {
            string query = " EXEC usp_LoadDanhSachSanBayTG ";


            return Dataprovider.ExcuteQuery(query);

        } 
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public static List<string> LoadMaChuyenBay()
        {
            
            string query = "Select MaChuyenBay from CHUYENBAY";
            DataTable table= Dataprovider.ExcuteQuery(query); ;
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
        public static bool NhapLichCB(ChuyenBay _chuyenbay,out string _maChuyenBay)
        {
            string query = "EXEC usp_NhapThongTinChuyenBay @sanBayDi,@sanBayDen,@ngayGioKH,@thoiGianBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@sanBayDi",SqlDbType.VarChar){Value=_chuyenbay.SanBayDi},

                new SqlParameter("@sanBayDen",SqlDbType.VarChar){Value=_chuyenbay.SanBayDen},


                new SqlParameter("@thoiGianBay",SqlDbType.Int){Value=_chuyenbay.ThoiGianBay},

                new SqlParameter("@ngayGioKH",SqlDbType.DateTime){Value=_chuyenbay.NgayGioKH},


            };

            try
            {
                _maChuyenBay = (string)Dataprovider.ExcuteScalar(query,parameters.ToArray());

                return true;
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                _maChuyenBay = null;
                return false;
                
            }
            
        
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_hangGhe"></param>
        public static void NhapChiTietHangGhe(HangGhe _hangGhe)
        {
            string query = "EXEC usp_NhapChiTietSoGhe @maChuyenBay,@maHangVe,@soGhe";


            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value=_hangGhe.MaChuyenBay },

                new SqlParameter("@maHangVe",SqlDbType.VarChar){Value=_hangGhe.MaHangVe },

                new SqlParameter("@soGhe",SqlDbType.Int){Value=_hangGhe.SoGhe },

            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);
            }
            
        }
        public static void NhapDonGia(string _machuyenbay,int _dongia)
        {
            string query = "EXEC usp_NhapDonGia  @maChuyenBay,@donGia";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value=_machuyenbay},

                new SqlParameter("@donGia",SqlDbType.Int){Value=_dongia},

            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);
            }
        }
        public static void NhapChiTietChuyenBay(SanBayTrungGian _sanbay)
        {
            string query = "EXEC usp_NhapChiTietChuyenBay @maChuyenBay,@maSanBay,@thoiGianDung,@ghiChu";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value =_sanbay.MaChuyenBay },

                new SqlParameter("@maSanBay",SqlDbType.VarChar){Value =_sanbay.MaSanBay },

                new SqlParameter("@thoiGianDung",SqlDbType.Int){Value =_sanbay.ThoiGianDung },

                new SqlParameter("@ghiChu",SqlDbType.VarChar){ Value =_sanbay.GhiChu },

            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
            }

        }


    
        // public static DataTable 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadDanhSachHangGhe()
        {
            string query = "EXEC usp_LoadDanhSachHangGhe";
            try
            {
                return Dataprovider.ExcuteQuery(query);
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return null;
            }
            
        }
        /// <summary>
        /// Thay đổi thông tin chuyến bay bao gồm: ngày giờ bay, số lượng vé
        /// </summary>
        /// <param name="_maCB">Mã chuyến bay muốn thay đổi</param>
        /// <param name="_chuyenbay">Thông tin mới muốn thay đổi</param>
        /// <returns></returns>
        public static bool ThayDoiChuyenBay(string _maCB,ChuyenBay _chuyenbay)
        {
            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@NgayGioKH",SqlDbType.DateTime){Value=_chuyenbay.NgayGioKH},

              
            };
            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return false;
            }
           
        }

        /// <summary>
        /// Hủy chuyến bay
        /// </summary>
        /// <param name="_maChuyenBay">Mã chuyến bay mà ta muốn xóa</param>
        /// <returns></returns>
        public static bool HuyChuyenBay(string _maChuyenBay)
        {
            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaChuyenBay",SqlDbType.VarChar){Value =_maChuyenBay },
            };

            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return false;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chuyenbay"></param>
        /// <returns></returns>
        public static int DemSoChuyenBay(string _sanBayDi, string _sanBayDen, DateTime? _ngayKHTu, DateTime? _ngayKHDen)
        {
            string query = "EXEC usp_DemChuyenBay @SanBayDi,@SanBayDen,@NgayKHTu,@NgayKHDen";

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
                return Convert.ToInt32(Dataprovider.ExcuteScalar(query, parameters.ToArray()));
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
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
        public static DataTable TraCuuChuyenBay(string SanBayDi, string SanBayDen, DateTime? _ngayKHTu, DateTime? _ngayKHDen, int pageSize, int pageNumber)
        {
            string query = "EXEC usp_TraCuuChuyenBay @SanBayDi,@SanBayDen,@ngayKHTu,@NgayKHDen,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.NVarChar){IsNullable=true,Value=SanBayDi??(Object)DBNull.Value},

                new SqlParameter("@SanBayDen",SqlDbType.NVarChar){IsNullable=true,Value=SanBayDen??(Object)DBNull.Value},

                new SqlParameter("@NgayKHTu",SqlDbType.DateTime){  IsNullable=true, Value = _ngayKHTu ??(Object)DBNull.Value},

                new SqlParameter("@NgayKHDen",SqlDbType.DateTime){IsNullable=true, Value = _ngayKHDen ??(Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.Int){Value = pageSize },

                new SqlParameter("@pageNumber",SqlDbType.Int){Value = pageNumber },
            };

            try
            {
                return Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return null;
            }
            
        }
        public static DataTable TraCuuSoGhe(string _maChuyenBay)
        {
            string query = "EXEC usp_ThongTinGhe @machuyenbay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@machuyenbay",SqlDbType.VarChar){Value=_maChuyenBay},
            };

            try
            {
               return Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return null;                
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maCB"></param>
        /// <returns></returns>
        public static DataTable TraCuuSanBayTG(string _maCB)
        {
            DataTable sanbayTG = new DataTable();

            string query = "EXEC usp_TraCuuSanBayTG @maChuyenBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value=_maCB},
            };

            try
            {
                return Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);

                return null;
            }

        }
    }
}
