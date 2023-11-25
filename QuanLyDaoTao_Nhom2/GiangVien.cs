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
        public GiangVien()
        {
            InitializeComponent();
        }

        private void btnLenDiem_Click(object sender, EventArgs e)
        {
            Diem formLuuDiem = new Diem();
            formLuuDiem.Show();  // Hiển thị form mới
            this.Hide();
        }

        private void btnDanhSachSV_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Tạo một instance của Form 2
            QuanLySinhVien form2 = new QuanLySinhVien();

            // Hiển thị Form 2
            form2.Show();
        }
    }
}
