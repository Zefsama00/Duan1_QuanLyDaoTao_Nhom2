using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao_Nhom2
{
    public partial class QuanLyLop : Form
    {
        string username;
        QLDTEntities db = new QLDTEntities();
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlCommand cmd;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter();
        private DataTable originalData;

        public QuanLyLop(string nametk)
        {
            InitializeComponent();
            username = nametk;
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySinhVien form2 = new QuanLySinhVien(username);
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

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem form2 = new Diem(username);
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

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc form2 = new MonHoc(username);
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

        private void lịchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLich form2 = new QuanLyLich(username);
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

        private void chuyênNgànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChuyenNganh form2 = new ChuyenNganh(username);
            form2.ShowDialog();
            this.Close();
        }

        private void lớpMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLopMon form2 = new QuanLyLopMon(username);
            form2.ShowDialog();
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu form = new TrangChu(username);
            form.ShowDialog();
            this.Close();
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }
        void LoadData()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dvThongTin.Rows.Clear();
            var result = (from
                              c in db.QLLops
                          select new
                          {
                              MaLop = c.MaLop,
                              TenLop = c.TenLop

                          });
            result.Distinct().ToList().ForEach(x => dvThongTin.Rows.Add(x.MaLop, x.TenLop));
            dvThongTin.Update();
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtTimKiem.Text = "";
        }
        private bool IsValidInput()
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            // Thêm các kiểm tra khác tùy vào yêu cầu của ứng dụng

            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

            if (IsValidInput())
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    string query = "INSERT INTO QLLop (MaLop, TenLop) VALUES (@MaLop, @TenLop)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                        command.Parameters.AddWithValue("@TenLop", txtTenLop.Text);

                        command.ExecuteNonQuery();
                    }
                }

                LoadData();
                MessageBox.Show("Thêm lớp thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

            if (IsValidInput())
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    string query = "UPDATE QLLop  SET TenLop = @Ten WHERE MaLop = @Malop";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Malop", txtMaLop.Text);
                        command.Parameters.AddWithValue("@Ten", txtTenLop.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thông tin lớp thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy lớp có mã là: " + txtMaLop.Text);
                        }
                    }
                }

                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "DELETE FROM QLLop WHERE MaLop = @MaLop";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTenLop.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa lớp thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp có mã là: " + txtMaLop.Text);
                    }
                }

                conn.Close();

                LoadData();
            }
        }
        void TimKiemDichVu(string searchValue)
        {
            DataTable searchData = string.IsNullOrWhiteSpace(searchValue) ? originalData : PerformSearch(searchValue);

            dvThongTin.DataSource = searchData;
        }
        DataTable PerformSearch(string searchValue)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaLop as [Ma Lop], TenLop as [Ten Lop] FROM QLLop WHERE MaLop = @SearchValue OR TenLop = @SearchValue";
            cmd.Parameters.AddWithValue("@SearchValue", searchValue);

            DataTable searchResult = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(searchResult);

            return searchResult;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            TimKiemDichVu(txtTimKiem.Text);
        }

        private void dvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int list = dvThongTin.CurrentRow.Index;
            txtMaLop.Text = dvThongTin.Rows[list].Cells[0].Value.ToString();
            txtTenLop.Text = dvThongTin.Rows[list].Cells[1].Value.ToString();
        }
    }
}
