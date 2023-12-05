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
            LoadData();
        }

        private void LichHoc_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            using (QLDTEntities db = new QLDTEntities())
            {
                var result = (from ld in db.QLLiches 
                              join c in db.QLLopMons on ld.MaHocKy equals c.MaHocKy
                              join giaovien in db.QLGiangViens on c.MaGV equals giaovien.MaGV
                              select new
                              {
                                  MaLichHoc = ld.MaLichHoc,
                                  MaHocKy = ld.MaHocKy,
                                  GioHoc = ld.GioHoc,
                                  NgayHoc = ld.NgayHoc,
                                  HoTenGV = giaovien.HoTenGV


                              }).ToList();
                dvThongTin.DataSource = result;

            }
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
