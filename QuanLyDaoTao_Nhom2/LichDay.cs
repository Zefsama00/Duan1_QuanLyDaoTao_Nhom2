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
    public partial class LichDay : Form
    {
        QLDTEntities db = new QLDTEntities();
        public LichDay()
        {
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
                var result = (from ld in context.QLLiches
                              select new
                              {
                                  MaLichHoc = ld.MaLichHoc,
                                  MaHocKy = ld.MaHocKy,
                                  GioHoc = ld.GioHoc,
                                  NgayHoc = ld.NgayHoc,
                                 
                              }).ToList();
                dvThongTin.DataSource = result;

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timCN = txtTimKiem.Text.Trim().ToLower();
            dvThongTin.DataSource = db.QLLiches.Where(x => x.MaHocKy.ToLower().Contains(timCN)).ToList();
        }
    }
}
