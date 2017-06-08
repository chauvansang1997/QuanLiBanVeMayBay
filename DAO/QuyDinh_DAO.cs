using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Help_Fuction;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAO
{
    public static class QuyDinh_DAO
    {
        public static DataRow LoadQuyDinh()
        {
            string query = "EXEC usp_LoadQuyDinh";

            try
            {


                var row = Dataprovider.ExcuteQuery(query).AsEnumerable().Single();

                QuyDinh.SoSanBayTGToiDa = row.Field<int>("SoSanBayTrungGianToiDa");

               
                return row;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                HelpFuction.Log(err);
                return null;
            }
        }

        public static bool ThayDoiQuyDinhSanBay()
        {
            string query = "EXEC usp_CapNhatQuyDinhSanBay @soLuongSBTD ";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soLuongSBTD",SqlDbType.Int){Value=QuyDinh.SoLuongSanBay },

            };

            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
            }
            return false;
        }

        public static bool ThayDoiQuyDinhVe()
        {
            string query = "EXEC usp_CapNhatQuyDinhVe @tgChamNhatDV,@tgChamNhatHuyVe ";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tgChamNhatDV",SqlDbType.Int){Value=QuyDinh.ThoiGianChamNhatDatVe },

                new SqlParameter("@tgChamNhatHuyVe",SqlDbType.Int){Value=QuyDinh.ThoiGianChamNhatHuyVe },

            };

            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
            }
            return false;
        }

        public static bool ThayDoiQuyDinhChuyenBay()
        {
            string query = "EXEC usp_CapNhatQuyDinhCB @tgBayToiThieu,@soSanBayTGTD ,@tgDungToiThieu , @tgDungToiDa ";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tgBayToiThieu",SqlDbType.Int){Value=QuyDinh.ThoiGianBayToiThieu },

                new SqlParameter("@soSanBayTGTD ",SqlDbType.Int){Value=QuyDinh.SoSanBayTGToiDa },

                new SqlParameter("@tgDungToiThieu",SqlDbType.Int){Value=QuyDinh.ThoiGianDungToiThieu},

                new SqlParameter(" @tgDungToiDa",SqlDbType.Int){Value=QuyDinh.ThoiGianDungToiDa },
            };

            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
            }
            return false;
        }
    }
}
