﻿using System;
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
    public partial class QuanLySinhVien : Form
    {
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        QLSinhVien qlsv = new QLSinhVien();
        public QuanLySinhVien()
        {
            InitializeComponent();
            LoadData();
            
        }

        void LoadData()
        {
            var sql = from c in db.QLSinhViens.ToList()
                      select new
                      {
                          MaSV = c.MaSV,
                          HoTenSV = c.HoTenSV,
                          GioiTinhSV = c.GioiTinhSV,
                          NgaySinhSV = c.NgaySinhSV,
                          DiaChiSV = c.DiaChiSV,
                          SoDienThoaiSV = c.SoDienThoaiSV,
                          EmailSV = c.EmailSV,
                      };
            dvThongTin.DataSource = sql.ToList();
        }

        void SaveData()
        {
            qlsv.MaSV = txtMaSV.Text;
            qlsv.HoTenSV = txtTenSV.Text;
            qlsv.SoDienThoaiSV = txtSoDienThoai.Text;
            qlsv.NgaySinhSV = DateTime.Parse(dtNgaySinh.Text);
            qlsv.EmailSV = txtEmail.Text;
            qlsv.DiaChiSV = txtDiaChi.Text;
            if (radNam.Checked == true)
            {
                qlsv.GioiTinhSV = radNam.Text;
            }
            else
            {
                qlsv.GioiTinhSV = radNu.Text;
            }
            db.QLSinhViens.Add(qlsv);
            int result = db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("Thêm Thành công");

            }
            else
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }
        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var CheckID_MaSV = db.QLSinhViens.Where(x => x.MaSV == txtMaSV.Text || x.MaSV == txtMaSV.Text).ToList().FirstOrDefault();
            var CheckSDT_Email = db.QLSinhViens.Where(x => x.SoDienThoaiSV == txtSoDienThoai.Text || x.EmailSV == txtEmail.Text).ToList().FirstOrDefault();
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)
                || string.IsNullOrWhiteSpace(txtTenSV.Text)
                || string.IsNullOrWhiteSpace(txtSoDienThoai.Text)
                || string.IsNullOrEmpty(dtNgaySinh.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {

                MessageBox.Show("Bạn đang nhập dữ chưa đủ - Vui lòng kiểm tra lại!!!");
            }
            else if(CheckID_MaSV != null )
            {
                MessageBox.Show("Mã sinh viên bị trùng - Vui lòng kiểm tra lại");
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
            }
            else if (CheckSDT_Email != null)
            {
                MessageBox.Show("Bạn đã nhập SDT hoặc Email trùng với một sinh viên khác");
            }
          
            else
            {
                SaveData();
                LoadData();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString());
            QLSinhVien sv = db.QLSinhViens.Find(sua);
            sv.HoTenSV = txtTenSV.Text;
            sv.NgaySinhSV = DateTime.Parse(dtNgaySinh.Text);
            sv.DiaChiSV = txtDiaChi.Text;
            sv.GioiTinhSV = (radNam.Checked ? radNam.Text : radNu.Text);
            sv.SoDienThoaiSV = txtSoDienThoai.Text;
            sv.EmailSV = txtEmail.Text;
            db.SaveChanges();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = txtMaSV.Text;
            QLSinhVien sv = db.QLSinhViens.Where(P => P.MaSV == id && P.HoTenSV == txtTenSV.Text).FirstOrDefault();
            db.QLSinhViens.Remove(sv);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
           
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
        }


        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            int lst = dvThongTin.CurrentRow.Index;
            DataGridViewRow selectedRow = dvThongTin.SelectedRows[0];
            txtMaSV.Enabled = false;
            txtMaSV.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
            txtTenSV.Text = dvThongTin.Rows[lst].Cells[1].Value.ToString();
            string GioiTinh = dvThongTin.Rows[lst].Cells[2].Value.ToString();
            dtNgaySinh.Text = dvThongTin.Rows[lst].Cells[3].Value.ToString();
            txtDiaChi.Text = dvThongTin.Rows[lst].Cells[4].Value.ToString();
            txtSoDienThoai.Text = dvThongTin.Rows[lst].Cells[5].Value.ToString();
            txtEmail.Text = dvThongTin.Rows[lst].Cells[6].Value.ToString();
            if (GioiTinh == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.Trim().ToLower();
            dvThongTin.DataSource = db.QLSinhViens.Where(x => x.MaSV.ToLower().Contains(key)).ToList();
        }
    }
}
