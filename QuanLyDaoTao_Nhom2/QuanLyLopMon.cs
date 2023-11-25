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
    public partial class QuanLyLopMon : Form
    {
        List<QLLopMon> dsLopMon;
        List<QLPhong> dsPhong;
        List<QLGiangVien> dsGV;
        List<QLLop> dsLop;
        List<QLMonHoc> dsMonHoc;
        List<QLHocKy> dsHocKy;

        private void dvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenPhong, tenGV, tenLop, tenMonHoc, tenHocKy;
            int selectedRowIndex = dvThongTin.SelectedCells[0].RowIndex;
            QLLopMon selectedPM = dsLopMon[selectedRowIndex];
            txtMaLopmon.Text = selectedPM.MaLopMon.ToString();
            
            tenPhong = dsPhong.Find(loai => loai.MaPhong == selectedPM.MaPhong.ToString()).TenPhong;
            cmxPhong.SelectedIndex = dsPhong.FindIndex(loai=>loai.TenPhong == tenPhong);
            
            tenGV = dsGV.Find(loai => loai.MaGV == selectedPM.MaGV.ToString()).HoTenGV;
            cmxGV.SelectedIndex = dsGV.FindIndex(loai => loai.HoTenGV == tenGV);
            
            tenLop = dsLop.Find(loai => loai.MaLop == selectedPM.MaLop.ToString()).TenLop;
            cmxLop.SelectedIndex = dsLop.FindIndex(loai => loai.TenLop == tenLop);
            
            tenMonHoc = dsMonHoc.Find(loai => loai.MaMonHoc == selectedPM.MaMonHoc.ToString()).TenMonHoc;
            cmxMonHoc.SelectedIndex = dsMonHoc.FindIndex(loai => loai.TenMonHoc == tenMonHoc);
            
            tenHocKy = dsHocKy.Find(loai => loai.MaHocKy == selectedPM.MaHocKy.ToString()).TenHocKy;
            cmxHocKy.SelectedIndex = dsHocKy.FindIndex(loai => loai.TenHocKy == tenHocKy);
            
            txtMaLopmon.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLopmon.Text = "";
            cmxPhong.SelectedIndex = -1;
            cmxGV.SelectedIndex = -1;
            cmxLop.SelectedIndex = -1;
            cmxMonHoc.SelectedIndex = -1;
            cmxHocKy.SelectedIndex = -1;
            dvThongTin.ClearSelection();
            txtMaLopmon.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
