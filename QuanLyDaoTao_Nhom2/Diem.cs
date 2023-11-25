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
    public partial class Diem : Form
    {
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        public Diem()
        {
            InitializeComponent();
            LoadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        void LoadData()
        {
            using (var context = new NHOM2_QUANLY_DAOTAOEntities())
            {
                var result = (from c in context.QLDiems
                              select new
                              {
                                  Madiem = c.MaDiem,
                                  Diemlab = c.DiemLab,
                                  Diemthi = c.DiemThi,
                                  DiemTongket = c.DiemTongKet,
                                  Masv = c.MaSV,
                                  MaMonhoc = c.MaMonHoc,
                              }).ToList();
                dvThongTin.DataSource = result;
                cmbMaMonHoc.DataSource = context.QLMonHocs.Select(cn => cn.MaMonHoc).ToList();
            }
        }
        private bool IsMaSVAndMaMHTonTai(string maSV)
        {
            using (var context = new NHOM2_QUANLY_DAOTAOEntities())
            {
                var sinhVien = context.QLSinhViens.FirstOrDefault(sv => sv.MaSV == maSV);
                if (sinhVien == null)
                {
                    MessageBox.Show("Mã Sinh viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiemLAB.Text) &&
              !string.IsNullOrEmpty(txtDiemThi.Text) &&
              !string.IsNullOrEmpty(txtDiemTongKet.Text) &&
              !string.IsNullOrEmpty(txtMaDiem.Text) &&
              !string.IsNullOrEmpty(cmbMaMonHoc.SelectedItem.ToString()) && !string.IsNullOrEmpty(txtMaSV.Text))
            {
                if (IsMaSVAndMaMHTonTai(txtMaSV.Text))
                {
                    try
                    {
                        using (var context = new NHOM2_QUANLY_DAOTAOEntities())
                        {

                            QLDiem nganh = new QLDiem()
                            {
                                MaDiem = txtMaDiem.Text,
                                DiemLab = float.Parse(txtDiemLAB.Text),
                                DiemThi = float.Parse(txtDiemThi.Text),
                                DiemTongKet = float.Parse(txtDiemTongKet.Text),
                                MaSV = txtMaSV.Text,
                                MaMonHoc = cmbMaMonHoc.Text,
                            };

                            context.QLDiems.Add(nganh);
                            context.SaveChanges();

                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Trùng Ma Diem");
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các ô điểm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            if (dvThongTin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvThongTin.SelectedRows[0];

                txtMaDiem.Text = row.Cells["MaDiem"].Value.ToString();
                txtDiemLAB.Text = row.Cells["DiemLab"].Value.ToString();
                txtDiemThi.Text = row.Cells["DiemThi"].Value.ToString();
                txtDiemTongKet.Text = row.Cells["DiemTongKet"].Value.ToString();
                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                cmbMaMonHoc.Text = row.Cells["MaMonHoc"].Value.ToString();
            }
        }
    }
}
