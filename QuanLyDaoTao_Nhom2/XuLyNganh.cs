using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao_Nhom2
{
    public class XuLyNganh
    {
        public static List<QLNganh> GetListNganh()
        {
            List<QLNganh> dsNganh = new List<QLNganh>();
            using (NHOM2_QUANLY_DAOTAOEntities dbconnect = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsNganh = dbconnect.QLNganhs.ToList();
            }
            return dsNganh;
        }
    }
}
