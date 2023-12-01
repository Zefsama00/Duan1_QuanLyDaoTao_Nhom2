using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
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
        public static List<QLLopMon> GetListLopMon()
        {
            List<QLLopMon> dsLoai = new List<QLLopMon>();
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                dsLoai = csharpDB.QLLopMons.ToList();
            }
            return dsLoai;
        }
        public static List<QLPhong> GetListPhong()
        {
            List<QLPhong> dsLoai = new List<QLPhong>();
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                dsLoai = csharpDB.QLPhongs.ToList();
            }
            return dsLoai;
        }
        public static List<QLGiangVien> GetListGV()
        {
            List<QLGiangVien> dsLoai = new List<QLGiangVien>();
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                dsLoai = csharpDB.QLGiangViens.ToList();
            }
            return dsLoai;
        }
        public static List<QLLop> GetListLop()
        {
            List<QLLop> dsLoai = new List<QLLop>();
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                dsLoai = csharpDB.QLLops.ToList();
            }
            return dsLoai;
        }
        public static List<QLMonHoc> GetListMonHoc()
        {
            List<QLMonHoc> dsLoai = new List<QLMonHoc>();
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                dsLoai = csharpDB.QLMonHocs.ToList();
            }
            return dsLoai;
        }
        public static List<QLHocKy> GetListHocKy()
        {
            List<QLHocKy> dsLoai = new List<QLHocKy>();
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                dsLoai = csharpDB.QLHocKies.ToList();
            }
            return dsLoai;
        }
        public static bool addLopMon(QLLopMon lmAdd)
        {
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                try
                {
                    csharpDB.QLLopMons.Add(lmAdd);
                    csharpDB.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static string Encrypt(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2")); // Đảm bảo luôn là 2 ký tự hex
                }

                return sb.ToString();
            }
        }
        public static bool updateLopmon(QLLopMon pm)
        {
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                try
                {
                    QLLopMon found = csharpDB.QLLopMons
                        .FirstOrDefault(sp => sp.MaLopMon == pm.MaLop);
                    found.MaLopMon = pm.MaLopMon;
                    found.MaPhong = pm.MaPhong;
                    found.MaGV = pm.MaGV;
                    found.MaLop = pm.MaLop;
                    found.MaMonHoc = pm.MaLop;
                    found.MaHocKy = pm.MaHocKy;
                    csharpDB.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static bool deleteLopMon(String Malopmon)
        {
            using (QLDTEntities csharpDB = new QLDTEntities())
            {
                try
                {
                    QLLopMon found = csharpDB.QLLopMons
                        .FirstOrDefault(sp => sp.MaLopMon == Malopmon);
                    csharpDB.QLLopMons.Remove(found);
                    csharpDB.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
