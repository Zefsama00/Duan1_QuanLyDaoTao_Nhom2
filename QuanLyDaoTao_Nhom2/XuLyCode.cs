using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao_Nhom2
{
    class XuLyCode
    {
        public static String Login(String username, String password)
        {
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                QLUser found = csharpDB.QLUsers
                    .FirstOrDefault(row => row.TaiKhoan.Equals(username));
                if (found != null && found.MatKhau.Equals(password))
                {
                    return found.VaiTro;
                }
                return null;
            }
        }
    }
}
