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
    public partial class XemDiem : Form
    {
        string username;
        List<QLDiem> dsdiem;
        List<QLMonHoc> dsmon;
        List<QLSinhVien> dssv;
        QLDTEntities db = new QLDTEntities();
        public XemDiem(String nametk)
        {
            dssv = XuLyCode.GetListSV();
            username = nametk;
            InitializeComponent();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemDiem form = new XemDiem(username);
            form.ShowDialog();
            this.Close();
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
        void LoadDiem()
        {
            QLSinhVien sv = db.QLSinhViens.FirstOrDefault(x => x.EmailSV.Contains(username));
            QLDiem diem = db.QLDiems.FirstOrDefault(x => x.MaSV == sv.MaSV);
            QLMonHoc mon = db.QLMonHocs.FirstOrDefault(x => x.MaMonHoc == diem.MaMonHoc);
            dvThongTin.Rows.Add(
                     diem.MaDiem,
                     diem.MaSV,
                     sv.HoTenSV,
                     mon.TenMonHoc,
                     diem.DiemLab,
                     diem.DiemThi,
                     ((double)diem.DiemTongKet));
            dvThongTin.Update();
        }
        private void XemDiem_Load(object sender, EventArgs e)
        {
            LoadDiem();
        }
    }
}
