using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao_Nhom2
{
    public partial class LichHoc : Form
    {
        QLDTEntities db = new QLDTEntities();
        string username;
        public LichHoc(String nametk)
        {
            username = nametk;
            InitializeComponent(); 
        }

        private void LichHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            QLSinhVien sv = db.QLSinhViens.FirstOrDefault(x => x.EmailSV.Contains(username));
            var result = (from  
                              c in db.QLLopMons
                              join hk in db.QLHocKies on c.MaHocKy equals hk.MaHocKy
                              join lh in db.QLLiches on hk.MaHocKy equals lh.MaHocKy
                              join giaovien in db.QLGiangViens on c.MaGV equals giaovien.MaGV
                              join lopmon in db.QLLopMons on giaovien.MaGV equals lopmon.MaGV
                              join lop in db.QLLops on lopmon.MaLop equals lop.MaLop
                              join nganh in db.QLNganhs on lop.MaLop equals nganh.MaLop
                              join sinhvien in db.QLSinhViens on nganh.MaSV equals sinhvien.MaSV
                              join phong in db.QLPhongs on c.MaPhong equals phong.MaPhong
                              join mon in db.QLMonHocs on c.MaMonHoc equals mon.MaMonHoc
                              where sinhvien.MaSV == sv.MaSV
                              select new
                              {
                                  MaHocKy = c.MaHocKy,
                                  GioHoc = lh.GioHoc,
                                  NgayHoc = lh.NgayHoc,
                                  HoTenGV = giaovien.HoTenGV,
                                  TenPhong = phong.TenPhong,
                                  TenLop = lop.TenLop,
                                  TenMon = mon.TenMonHoc
                              });
                 result.Distinct().ToList().ForEach(x => dvThongTin.Rows.Add(x.MaHocKy, x.GioHoc, x.NgayHoc.Value.Date.ToString().Substring(0,10), x.HoTenGV, x.TenPhong, x.TenLop, x.TenMon));
                 dvThongTin.Update();
        }

        private void LichHocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichHoc form = new LichHoc(username);
            form.ShowDialog();
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinhVien form = new SinhVien(username);
            form.ShowDialog();
            this.Close();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemDiem form = new XemDiem(username);
            form.ShowDialog();
            this.Close();
        }
    }
}
