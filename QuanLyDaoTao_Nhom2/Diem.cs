using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace QuanLyDaoTao_Nhom2
{
    public partial class Diem : Form
    {
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        QLDiem qld = new QLDiem();
        QLSinhVien qlsv = new QLSinhVien();
        QLMonHoc qlmh = new QLMonHoc();
        private int selectedRowIndex;
        DataGridViewRow selectedRow;
        string str = @"Data Source=PHANHUUHIEU\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True;Encrypt=False";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DuLieu;
        public Diem()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {

            var sql = (from c in db.QLDiems
                       join b in db.QLSinhViens
                       on c.MaSV equals b.MaSV
                       join a in db.QLMonHocs
                       on c.MaMonHoc equals a.MaMonHoc
                       select new
                       {
                           ID = c.MaDiem,
                           MaSV = c.MaSV,
                           TenMonHoc = a.TenMonHoc,
                           HoTenSV = b.HoTenSV,
                           MaMonHoc = c.MaMonHoc,
                           DiemLAB = c.DiemLab,
                           DiemThi = c.DiemThi,
                           DiemTongKet = (c.DiemLab + c.DiemThi * 2) / 3,
                       });
            dvThongTin.DataSource = sql.ToList();
            txtMaSV.Enabled = false;
            txtMaMonHoc.Enabled = false;
        }

        string lenhsv;
        string lenhmh;

        void LoadMaSV()
        {
            cboTenSV.Items.Clear();
            KetNoi = new SqlConnection(str);
            lenhsv = @"SELECT HoTenSV From QLSinhVien";
            KetNoi.Open();
            try
            {
                ThucHien = new SqlCommand(lenhsv, KetNoi);
                DuLieu = ThucHien.ExecuteReader();
                while (DuLieu.Read())
                {
                    cboTenSV.Items.Add(DuLieu[0].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                KetNoi.Close();
            }


            cboTenSV.SelectedIndexChanged += (s, e) =>
            {
                var maSV = cboTenSV.SelectedItem as string;
                if (maSV != null)
                {

                    var lenhsv = @"SELECT MaSV From QLSinhVien Where HoTenSV = @HoTenSV";
                    var thucHien = new SqlCommand(lenhsv, KetNoi);
                    thucHien.Parameters.AddWithValue("@HoTenSV", maSV);
                    KetNoi.Open();
                    var duLieu = thucHien.ExecuteReader();
                    if (duLieu.Read())
                    {
                        txtMaSV.Text = duLieu[0].ToString();
                    }
                    KetNoi.Close();
                }
            };

        }



        void LoadMaMonhoc()
        {

            cboTenMonHoc.Items.Clear();
            KetNoi = new SqlConnection(str);
            lenhmh = @"SELECT TenMonHoc From QLMonHoc";
            KetNoi.Open();
            try
            {
                ThucHien = new SqlCommand(lenhmh, KetNoi);
                DuLieu = ThucHien.ExecuteReader();
                while (DuLieu.Read())
                {
                    cboTenMonHoc.Items.Add(DuLieu[0].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                KetNoi.Close();
            }


            cboTenMonHoc.SelectedIndexChanged += (s, e) =>
            {
                var maMH = cboTenMonHoc.SelectedItem as string;
                if (maMH != null)
                {

                    var lenhmh = @"SELECT MaMonHoc From QLMonHoc Where TenMonHoc = @TenMonHoc";
                    var thucHienmh = new SqlCommand(lenhmh, KetNoi);
                    thucHienmh.Parameters.AddWithValue("@TenMonHoc", maMH);
                    KetNoi.Open();
                    var duLieumh = thucHienmh.ExecuteReader();
                    if (duLieumh.Read())
                    {
                        txtMaMonHoc.Text = duLieumh[0].ToString();
                    }
                    KetNoi.Close();
                }
            };
        }

        private void TinhDiemTB()
        {
            if (!string.IsNullOrWhiteSpace(txtDiemLAB.Text) &&
                !string.IsNullOrWhiteSpace(txtDiemThi.Text))
            {
                double lab = double.Parse(txtDiemLAB.Text);
                double thi = double.Parse(txtDiemThi.Text);
                double diemTB = (lab + thi * 2) / 3;
                lblDiemTongKet.Text = diemTB.ToString("F2");
            }
            else
            {
                lblDiemTongKet.Text = "0.0";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var CheckMH = db.QLDiems.Where(x => x.MaSV == txtMaSV.Text && x.MaMonHoc == txtMaMonHoc.Text).ToList().FirstOrDefault();

                int lengthLab = Convert.ToInt32(txtDiemLAB.TextLength);
                int lengthThi = Convert.ToInt32(txtDiemThi.TextLength);
                if (db.QLDiems.Any(diem => diem.MaDiem == txtMaDiem.Text))
                {
                    MessageBox.Show("ID đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtMaDiem.Text == "")
                {
                    MessageBox.Show("ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cboTenSV.Text == "")
                {
                    MessageBox.Show("Mã sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (CheckMH != null)
                {
                    MessageBox.Show("Mã môn học này đã được đăng ký cho sinh viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cboTenMonHoc.Text == "")
                {
                    MessageBox.Show("Mã môn học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtDiemLAB.Text == "")
                {
                    MessageBox.Show("Điểm LAB không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (Convert.ToInt32(txtDiemLAB.Text) < 0 || Convert.ToInt32(txtDiemLAB.Text) > 10)
                {
                    MessageBox.Show("Điểm LAB phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtDiemThi.Text == "")
                {
                    MessageBox.Show("Điểm thi không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Convert.ToInt32(txtDiemThi.Text) < 0 || Convert.ToInt32(txtDiemThi.Text) > 10)
                {
                    MessageBox.Show("Điểm thi phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    db.QLDiems.Add(new QLDiem()
                    {

                        MaDiem = txtMaDiem.Text,
                        MaSV = txtMaSV.Text,
                        MaMonHoc = txtMaMonHoc.Text,
                        DiemLab = double.Parse(txtDiemLAB.Text),
                        DiemThi = double.Parse(txtDiemThi.Text),
                        DiemTongKet = Convert.ToInt32(txtDiemLAB.Text + txtDiemThi.Text),
                    });

                    db.SaveChanges();
                    MessageBox.Show("Điểm đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiemLAB.Text == "")
                {
                    MessageBox.Show("Điểm LAB không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (Convert.ToInt32(txtDiemLAB.Text) < 0 || Convert.ToInt32(txtDiemLAB.Text) > 10)
                {
                    MessageBox.Show("Điểm LAB phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtDiemThi.Text == "")
                {
                    MessageBox.Show("Điểm thi không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Convert.ToInt32(txtDiemThi.Text) < 0 || Convert.ToInt32(txtDiemThi.Text) > 10)
                {
                    MessageBox.Show("Điểm thi phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                QLDiem sv = db.QLDiems.Find(sua);
                sv.DiemLab = double.Parse(txtDiemLAB.Text);
                sv.DiemThi = double.Parse(txtDiemThi.Text);
                sv.DiemTongKet = Convert.ToInt32(txtDiemLAB.Text + txtDiemThi.Text);
                db.SaveChanges();
                MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa điểm", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = txtMaDiem.Text;
            QLDiem dd = db.QLDiems.Where(p => p.MaDiem == id).FirstOrDefault();
            db.QLDiems.Remove(dd);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDiem.Text = "";
            cboTenSV.Text = "";
            txtMaSV.Text = "";
            txtMaMonHoc.Text = "";
            cboTenMonHoc.Text = "";
            txtDiemLAB.Text = "";
            txtDiemThi.Text = "";
            lblDiemTongKet.Text = "0.0";
        }

        private void txtDiemThi_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTB();
        }

        private string MaDiem;
        private string Masv;
        private string HoTensv;
        private string TenMonHocsv;
        private string MaMonHocsv;
        private string DiemLabsv;
        private string DiemThisv;
        private string DiemTongKetsv;


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.Trim().ToLower();
            dvThongTin.DataSource = db.QLSinhViens.Where(x => x.HoTenSV.ToLower().Contains(key)).ToList();
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            LoadMaSV();
            LoadMaMonhoc();
        }

        private void dvThongTin_Click(object sender, EventArgs e)
        {
            int lst = dvThongTin.CurrentRow.Index;
            btnThem.Enabled = false;
            txtMaDiem.Enabled = false;
            cboTenSV.Enabled = false;
            cboTenMonHoc.Enabled = false;
            txtMaDiem.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
            cboTenSV.Text = dvThongTin.Rows[lst].Cells[3].Value.ToString();
            cboTenMonHoc.Text = dvThongTin.Rows[lst].Cells[2].Value.ToString();
            txtDiemLAB.Text = dvThongTin.Rows[lst].Cells[5].Value.ToString();
            txtDiemThi.Text = dvThongTin.Rows[lst].Cells[6].Value.ToString();
        }


        private void btnIN_Click(object sender, EventArgs e)
        {
            if (dvThongTin.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 sinh viên để in!");
                return;
            }
            DataGridViewRow selectedRow = dvThongTin.SelectedRows[0];
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];
            int row = 1;
            for (int i = 0; i < dvThongTin.Columns.Count; i++)
            {
                worksheet.Cells[row, i + 1] = dvThongTin.Columns[i].HeaderText;
            }
            row++;

            for (int i = 0; i < dvThongTin.Columns.Count; i++)
            {
                worksheet.Cells[row, i + 1] = selectedRow.Cells[i].Value.ToString();
            }
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DiemALL.xlsx");
            if (File.Exists(filePath))
            {
                DialogResult overwriteResult = MessageBox.Show($"Bạn muốn in '{filePath}' sinh viên này?",
                                                            "File Exists",
                                                            MessageBoxButtons.YesNo);

                if (overwriteResult != DialogResult.Yes)
                {
                    return;
                }
            }
            workbook.SaveAs(filePath);
            excelApp.Quit();
            MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công!");
        }





        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            selectedRowIndex = dvThongTin.CurrentCell.RowIndex;
            selectedRow = dvThongTin.Rows[selectedRowIndex];
            MessageBox.Show("Bạn đã chọn sinh viên ở dòng " + selectedRowIndex);
            MaDiem = selectedRow.Cells[0].Value.ToString();
            Masv = selectedRow.Cells[1].Value.ToString();
            HoTensv = selectedRow.Cells[2].Value.ToString();
            TenMonHocsv = selectedRow.Cells[3].Value.ToString();
            MaMonHocsv = selectedRow.Cells[4].Value.ToString();
            DiemLabsv = selectedRow.Cells[5].Value.ToString();
            DiemThisv = selectedRow.Cells[6].Value.ToString();
            DiemTongKetsv = selectedRow.Cells[7].Value.ToString();
        }
        string filePath;
        private void btnINDIEM_Click(object sender, EventArgs e)
        {
            string inDiem = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "INDiemALL.xlsx");
            if (File.Exists(inDiem))
            {
               
                DialogResult overwriteResult = MessageBox.Show($"Chắc chưa ? '{filePath}' muốn in phải không?",
                                                                "File Exists",
                                                                MessageBoxButtons.YesNo);

                if (overwriteResult != DialogResult.Yes)
                {
                    return;
                }
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];
            int row = 1;

            for (int i = 0; i < dvThongTin.Columns.Count; i++)
            {
                worksheet.Cells[row, i + 1] = dvThongTin.Columns[i].HeaderText;
            }
            row++;

            for (int i = 0; i < dvThongTin.Rows.Count; i++)
            {
                for (int j = 0; j < dvThongTin.Columns.Count; j++)
                {
                    worksheet.Cells[row, j + 1] = dvThongTin.Rows[i].Cells[j].Value.ToString();
                }
                row++;
            }
            workbook.SaveAs(inDiem);
            excelApp.Quit();
            MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công!");

        }
    }
}
