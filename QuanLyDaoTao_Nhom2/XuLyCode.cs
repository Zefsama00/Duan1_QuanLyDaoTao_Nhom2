using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao_Nhom2
{
    public class XuLyCode
    {
        public static List<QLChuyenNganh> GetQLChuyenNganhs()
        {
            List<QLChuyenNganh> dsNganh = new List<QLChuyenNganh>();
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsNganh = csharpDB.QLChuyenNganhs.ToList();
            }
            return dsNganh;
        }

    }
}
