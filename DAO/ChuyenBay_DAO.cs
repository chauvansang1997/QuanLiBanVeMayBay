using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<ChuyenBay> XemChuyenBay()
        {
            List<ChuyenBay> chuyenbay = new List<ChuyenBay>();
            string query = "";
            
            return chuyenbay;
        }
    }
}
