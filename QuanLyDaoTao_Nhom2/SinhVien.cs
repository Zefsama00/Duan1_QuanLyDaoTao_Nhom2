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
    public partial class SinhVien : Form
    {
        string username;
        public SinhVien(String nametk)
        {
            InitializeComponent();
            username = nametk;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap form = new DangNhap();
            form.ShowDialog();
            this.Close();
        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Tạo một instance của Form 2
            LichHoc form2 = new LichHoc(username);
            // Hiển thị Form 2
            form2.ShowDialog();
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoiMatKhau form = new DoiMatKhau(username);
            form.ShowDialog();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemDiem form = new XemDiem(username);
            form.ShowDialog();
            this.Close();
        }

        private void họcKỳToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichHoc form = new LichHoc(username);
            form.ShowDialog();
            this.Close();
        }
    }
}
