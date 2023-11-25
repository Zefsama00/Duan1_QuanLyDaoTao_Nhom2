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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            using (var context = new NHOM2_QUANLY_DAOTAOEntities())
            {
                var result = (from c in context.QLSinhViens
                              select new
                              {
                                  MasV = c.MaSV,
                                  HoTen = c.HoTenSV,
                                  GioiTinh = c.GioiTinhSV,
                                  NgaySinh = c.NgaySinhSV,
                                  DiaChi = c.DiaChiSV,
                                  SoDienThoai = c.SoDienThoaiSV,
                                  email = c.EmailSV,
                              }).ToList();
                dvThongTin.DataSource = result;
            }
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
