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
    public partial class QuanLyLich : Form
    {
        List<QLLich> dsLich;
        List<QLHocKy> dsHocKy;
        public QuanLyLich()
        {
            InitializeComponent();
        }
        private void updateDataGridView()
        {
            dsLich = XuLyCode.GetListLich();
            dvThongTin.Rows.Clear();
            dsLich.ForEach(row => dvThongTin.Rows.Add(
                    row.MaLichHoc,
                    row.MaHocKy,
                    row.NgayHoc,
                    row.GioHoc
            ));
            dvThongTin.Update();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QLLich lichAdd = new QLLich();
            lichAdd.MaLichHoc = txtMaLichhoc.Text;
            lichAdd.MaHocKy = dsHocKy.Find(
                loai => loai.TenHocKy == cmxHocKy.SelectedItem.ToString()).MaHocKy;
            lichAdd.GioHoc = int.Parse(txtGioHoc.Text);
            lichAdd.NgayHoc = datetimeNgayHoc.Value;
            if (XuLyCode.addLich(lichAdd))
            {
                MessageBox.Show("Đã thêm thành công");
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

        private void QuanLyLich_Load(object sender, EventArgs e)
        {
            this.updateDataGridView();
            dsHocKy = XuLyCode.GetListHocKy();
            dsHocKy.ForEach(loai => cmxHocKy.Items.Add(loai.TenHocKy));
        }
    }
}
