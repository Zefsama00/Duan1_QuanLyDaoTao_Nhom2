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
    public partial class MonHoc : Form
    {
        string username;
        QLDTEntities db = new QLDTEntities();
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlCommand cmd;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter();
        private DataTable originalData;

        public MonHoc(String nametk)
        {
            username = nametk;
            InitializeComponent();
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
        void LoadData()
        {
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            dataGridView1.Rows.Clear();
            var result = (from
                              c in db.QLMonHocs
                          select new
                          {
                              MaMonHoc = c.MaMonHoc,
                              TenMonHoc = c.TenMonHoc
                            
                          });
            result.Distinct().ToList().ForEach(x => dataGridView1.Rows.Add(x.MaMonHoc,x.TenMonHoc));
            dataGridView1.Update();
            txtMaMonhoc.Text = "";
            txtTenMonhoc.Text = "";


        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            int list = dataGridView1.CurrentRow.Index;
            txtMaMonhoc.Text = dataGridView1.Rows[list].Cells[0].Value.ToString();
            txtTenMonhoc.Text = dataGridView1.Rows[list].Cells[1].Value.ToString();
        }
        private bool IsValidInput()
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txtMaMonhoc.Text) || string.IsNullOrEmpty(txtTenMonhoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            // Thêm các kiểm tra khác tùy vào yêu cầu của ứng dụng

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

            if (IsValidInput())
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    string query = "INSERT INTO QLMonHoc (MaMonHoc, TenMonHoc) VALUES (@MaMH, @TenMH)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaMH", txtMaMonhoc.Text);
                        command.Parameters.AddWithValue("@TenMH", txtTenMonhoc.Text);

                        command.ExecuteNonQuery();
                    }
                }

                LoadData();
                MessageBox.Show("Thêm môn thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

            if (IsValidInput())
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    string query = "UPDATE QLMonHoc  SET TenMonHoc = @TenMH WHERE MaMonHoc = @MaMH";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaMH", txtMaMonhoc.Text);
                        command.Parameters.AddWithValue("@TenMH", txtTenMonhoc.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thông tin môn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy môn có mã là: " + txtMaMonhoc.Text);
                        }
                    }
                }

                LoadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "DELETE FROM QLMonHoc WHERE MaMonHoc = @MaMH";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMH", txtMaMonhoc.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTenMonhoc.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa môn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy môn có mã là: " + txtMaMonhoc.Text);
                    }
                }

                conn.Close();

                LoadData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        void TimKiemDichVu(string searchValue)
        {
            DataTable searchData = string.IsNullOrWhiteSpace(searchValue) ? originalData : PerformSearch(searchValue);

            dataGridView1.DataSource = searchData;
        }
        DataTable PerformSearch(string searchValue)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaMonHoc as [Ma Mon], TenMonHoc as [Ten Mon] FROM QLMonHoc WHERE MaMonHoc = @SearchValue OR TenMonHoc = @SearchValue";
            cmd.Parameters.AddWithValue("@SearchValue", searchValue);

            DataTable searchResult = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(searchResult);

            return searchResult;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            TimKiemDichVu(textBox1.Text);
        }
    }
}
