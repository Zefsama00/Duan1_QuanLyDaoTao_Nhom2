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
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
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
            using ( NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsLoai = csharpDB.QLLopMons.ToList();
            }
            return dsLoai;
        }
        public static List<QLPhong> GetListPhong()
        {
            List<QLPhong> dsLoai = new List<QLPhong>();
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsLoai = csharpDB.QLPhongs.ToList();
            }
            return dsLoai;
        }
        public static List<QLGiangVien> GetListGV()
        {
            List<QLGiangVien> dsLoai = new List<QLGiangVien>();
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new   NHOM2_QUANLY_DAOTAOEntities())
            {
                dsLoai = csharpDB.QLGiangViens.ToList();
            }
            return dsLoai;
        }
        public static List<QLLop> GetListLop()
        {
            List<QLLop> dsLoai = new List<QLLop>();
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsLoai = csharpDB.QLLops.ToList();
            }
            return dsLoai;
        }
        public static List<QLMonHoc> GetListMonHoc()
        {
            List<QLMonHoc> dsLoai = new List<QLMonHoc>();
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsLoai = csharpDB.QLMonHocs.ToList();
            }
            return dsLoai;
        }
        public static List<QLHocKy> GetListHocKy()
        {
            List<QLHocKy> dsLoai = new List<QLHocKy>();
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsLoai = csharpDB.QLHocKies.ToList();
            }
            return dsLoai;
        }
        public static List<QLLich> GetListLich()
        {
            List<QLLich> dsLoai = new List<QLLich>();
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                dsLoai = csharpDB.QLLiches.ToList();
            }
            return dsLoai;
        }
        public static bool addLopMon(QLLopMon lmAdd)
        {
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
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
        public static bool addLich(QLLich lmAdd)
        {
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                try
                {
                    csharpDB.QLLiches.Add(lmAdd);
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
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                try
                {
                    QLLopMon found = csharpDB.QLLopMons
                        .FirstOrDefault(sp => sp.MaLopMon == pm.MaLop);
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
        public static bool updateLich(QLLich pm)
        {
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                try
                {
                    QLLich found = csharpDB.QLLiches
                        .FirstOrDefault(sp => sp.MaLichHoc == pm.MaLichHoc);
                    found.GioHoc = pm.GioHoc;
                    found.NgayHoc = pm.NgayHoc;
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
        public static bool deleteLopMon(String malich)
        {
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new NHOM2_QUANLY_DAOTAOEntities())
            {
                try
                {
                    QLLich found = csharpDB.QLLiches
                        .FirstOrDefault(sp => sp.MaLichHoc == malich);
                    csharpDB.QLLiches.Remove(found);
                    csharpDB.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static bool deleteLich(String malich)
        {
            using (NHOM2_QUANLY_DAOTAOEntities csharpDB = new  NHOM2_QUANLY_DAOTAOEntities ())
            {
                try
                {
                    QLLich found = csharpDB.QLLiches
                        .FirstOrDefault(sp => sp.MaLichHoc == malich);
                    csharpDB.QLLiches.Remove(found);
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
