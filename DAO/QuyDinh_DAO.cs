using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Help_Fuction;
using System.Data;

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

                HelpFuction.Log(err);
                return null;
            }
        }
    }
}
