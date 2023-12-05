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
    public partial class XemDSSV : Form
    {
        List<QLSinhVien> dssinhvien;
        string username;
        public XemDSSV(String nametk)
        {
            username = nametk;
            InitializeComponent();
        }

        private void XemDSSV_Load(object sender, EventArgs e)
        {
            dssinhvien = XuLyCode.GetListSV();
            dvThongTin.Rows.Clear();
            dssinhvien.ForEach(row => dvThongTin.Rows.Add(
                    row.MaSV,
                    row.HoTenSV,
                    row.NgaySinhSV,
                    row.GioiTinhSV,
                    row.DiaChiSV,
                    row.EmailSV,
                    row.SoDienThoaiSV
            ));
            dvThongTin.Update();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiangVien form2 = new GiangVien(username);
            form2.ShowDialog();
            this.Close();
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
    }
}
