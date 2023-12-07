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
            dvThongTin.Rows.Clear();
            var result = (from
                          c in db.QLSinhViens
                          join bdiem in db.QLDiems on c.MaSV equals bdiem.MaSV
                          join bmon in db.QLMonHocs on bdiem.MaMonHoc equals bmon.MaMonHoc
                          where c.MaSV == sv.MaSV
                          select new
                          {
                              masv = c.MaSV,
                              hoten = c.HoTenSV,
                              monhoc = bmon.TenMonHoc,
                              diemLab = bdiem.DiemLab,
                              diemThi = bdiem.DiemThi,
                              DiemTongKet = bdiem.DiemTongKet
                          });
            result.ToList().ForEach(x => dvThongTin.Rows.Add(x.masv, x.hoten, x.monhoc, x.diemLab, x.diemThi, x.DiemTongKet));
            dvThongTin.Update();
        }
        private void XemDiem_Load(object sender, EventArgs e)
        {
            LoadDiem();
        }
    }
}
