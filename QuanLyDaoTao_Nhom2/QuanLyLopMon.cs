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
    public partial class QuanLyLopMon : Form
    {
        List<QLLopMon> dsLopMon;
        List<QLPhong> dsPhong;
        List<QLGiangVien> dsGV;
        List<QLLop> dsLop;
        List<QLMonHoc> dsMonHoc;
        List<QLHocKy> dsHocKy;
        string maPhong,maGV,maLop,maMonHoc,maHocKy;
        public QuanLyLopMon()
        {
            InitializeComponent();
        }

        private void QuanLyLopMon_Load(object sender, EventArgs e)
        {
            this.updateDataGridView();
            dsPhong = XuLyCode.GetListPhong();
            dsPhong.ForEach(loai => cmxPhong.Items.Add(loai.TenPhong));
            dsGV = XuLyCode.GetListGV();
            dsGV.ForEach(loai => cmxGV.Items.Add(loai.HoTenGV));
            dsLop = XuLyCode.GetListLop();
            dsLop.ForEach(loai => cmxLop.Items.Add(loai.TenLop));
            dsMonHoc = XuLyCode.GetListMonHoc();
            dsMonHoc.ForEach(loai => cmxMonHoc.Items.Add(loai.TenMonHoc));
            dsHocKy = XuLyCode.GetListHocKy();
            dsHocKy.ForEach(loai => cmxHocKy.Items.Add(loai.TenHocKy));
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void updateDataGridView()
        {
            dsLopMon = XuLyCode.GetListLopMon();
            dvThongTin.Rows.Clear();
            dsLopMon.ForEach(row => dvThongTin.Rows.Add(
                    row.MaLopMon,
                    row.MaGV,
                    row.MaMonHoc,
                    row.MaPhong,
                    row.MaHocKy,
                    row.MaLop
            ));
            dvThongTin.Update();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QLLopMon lmAdd = new QLLopMon();
            lmAdd.MaLopMon = txtMaLopmon.Text;
            lmAdd.MaPhong =  dsPhong.Find(loai => loai.TenPhong == cmxPhong.SelectedItem.ToString()).MaPhong;
            lmAdd.MaGV = dsGV.Find(
              loai => loai.HoTenGV == cmxGV.SelectedItem.ToString()).MaGV;
            lmAdd.MaLop = dsLop.Find(
               loai => loai.TenLop == cmxLop.SelectedItem.ToString()).MaLop;
            lmAdd.MaMonHoc = dsMonHoc.Find(
               loai => loai.TenMonHoc == cmxMonHoc.SelectedItem.ToString()).MaMonHoc;
            lmAdd.MaHocKy = dsHocKy.Find(
               loai => loai.TenHocKy == cmxHocKy.SelectedItem.ToString()).MaHocKy;
            if (XuLyCode.addLopMon(lmAdd))
            {
                MessageBox.Show("Đã thêm sản phẩm");
                this.updateDataGridView();
            }
            else
            {
                MessageBox.Show(
                    "Thêm mới thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
