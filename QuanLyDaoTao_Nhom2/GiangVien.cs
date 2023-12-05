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
    public partial class GiangVien : Form
    {
        string username;
        public GiangVien(String nametk)
        {
            InitializeComponent();
            username = nametk;
        }

        private void btThoatGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap form = new DangNhap();
            form.ShowDialog();
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoiMatKhau form = new DoiMatKhau(username);
            form.ShowDialog();
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

        private void btThoatGV_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LichDay form2 = new LichDay(username);
            form2.ShowDialog();
            this.Close();
        }
    }
}
