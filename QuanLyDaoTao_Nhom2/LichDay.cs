using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}
