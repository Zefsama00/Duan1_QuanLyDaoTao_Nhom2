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
        string username;
        public QuanLyLich(String nametk)
        {
            username = nametk;
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
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dsHocKy = XuLyCode.GetListHocKy();
            dsHocKy.ForEach(loai => cmxHocKy.Items.Add(loai.TenHocKy));
        }

        private void dvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenPhong, tenGV, tenLop, tenMonHoc, tenHocKy;
            int selectedRowIndex = dvThongTin.SelectedCells[0].RowIndex;
            QLLich selectedPM = dsLich[selectedRowIndex];
            txtMaLichhoc.Text = selectedPM.MaLichHoc.ToString();
            txtGioHoc.Text= selectedPM.GioHoc.ToString();
            datetimeNgayHoc.Value = selectedPM.NgayHoc.Value;
            tenHocKy = dsHocKy.Find(loai => loai.MaHocKy == selectedPM.MaHocKy.ToString()).TenHocKy;
            cmxHocKy.SelectedIndex = dsHocKy.FindIndex(loai => loai.TenHocKy == tenHocKy);
            txtMaLichhoc.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLichhoc.Text = string.Empty;
            txtGioHoc.Text = string.Empty;
            datetimeNgayHoc.Value = DateTime.Now;
            cmxHocKy.SelectedIndex = -1;
            dvThongTin.ClearSelection();
            txtMaLichhoc.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dvThongTin.SelectedCells[0].RowIndex;
            QLLich selectedSP = dsLich[selectedRowIndex];
            selectedSP.GioHoc = int.Parse(txtGioHoc.Text);
            selectedSP.NgayHoc = datetimeNgayHoc.Value;
            selectedSP.MaHocKy = dsHocKy.Find(
               loai => loai.TenHocKy == cmxHocKy.SelectedItem.ToString()).MaHocKy;
            if (XuLyCode.updateLich(selectedSP))
            {
                MessageBox.Show("Đã cập nhật");
                this.updateDataGridView();
            }
            else
            {
                MessageBox.Show(
                    "Cập nhật thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
               "Xóa sản phẩm đã chọn ?",
               "Xác nhận xóa",
               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (XuLyCode.deleteLich(txtMaLichhoc.Text))
                {
                    MessageBox.Show("Đã xóa sản phẩm");
                    this.updateDataGridView();
                }
                else
                {
                    MessageBox.Show(
                        "Xóa thất bại",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu form = new TrangChu(username);
            form.ShowDialog();
            this.Close();
        }

        private void lớpMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLopMon form2 = new QuanLyLopMon(username);
            form2.ShowDialog();
            this.Close();
        }

        private void chuyênNgànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChuyenNganh form2 = new ChuyenNganh(username);
            form2.ShowDialog();
            this.Close();
        }

        private void ngànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nganh form2 = new Nganh(username);
            form2.ShowDialog();
            this.Close();
        }

        private void lịchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLich form2 = new QuanLyLich(username);
            form2.ShowDialog();
            this.Close();
        }

        private void họcKỳToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHocKy form2 = new QuanLyHocKy(username);
            form2.ShowDialog();
            this.Close();
        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc form2 = new MonHoc(username);
            form2.ShowDialog();
            this.Close();
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLop form2 = new QuanLyLop(username);
            form2.ShowDialog();
            this.Close();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem form2 = new Diem(username);
            form2.ShowDialog();
            this.Close();
        }

        private void giảngViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyGiangVien form2 = new QuanLyGiangVien(username);
            form2.ShowDialog();
            this.Close();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySinhVien form2 = new QuanLySinhVien(username);
            form2.ShowDialog();
            this.Close();
        }
    }
}
