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
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
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
            using (var context = new NHOM2_QUANLY_DAOTAOEntities())
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
    }
}
