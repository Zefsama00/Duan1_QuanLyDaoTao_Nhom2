using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyDaoTao_Nhom2
{
    public partial class LichDay : Form
    {
        QLDTEntities db = new QLDTEntities();
        string username;
        public LichDay(String nametk)
        {
            username = nametk;
            InitializeComponent();
            LoadData();
            
        }

        private void LichDay_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            using (var context = new QLDTEntities())
            {
                QLGiangVien gv = db.QLGiangViens.FirstOrDefault(x => x.EmailGV.Contains(username));
                dvThongTin.Rows.Clear();
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
                              where giaovien.MaGV == gv.MaGV
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
               result.ToList().ForEach(x =>dvThongTin.Rows.Add(x.MaHocKy,x.GioHoc,x.NgayHoc,x.HoTenGV,x.TenPhong,x.TenLop,x.TenMon));
                dvThongTin.Update();
            }
        }

        private void LichDayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichDay form2 = new LichDay(username);
            form2.ShowDialog();
            this.Close();
        }

        private void LenDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem formLuuDiem = new Diem(username);
            formLuuDiem.ShowDialog();
            this.Close();
        }

        private void DSSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemDSSV form = new XemDSSV(username);
            form.ShowDialog();
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiangVien form2 = new GiangVien(username);
            form2.ShowDialog();
            this.Close();
        }
    }
}
