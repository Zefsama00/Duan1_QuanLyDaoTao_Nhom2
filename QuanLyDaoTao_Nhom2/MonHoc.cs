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
        public MonHoc()
        {
            InitializeComponent();
        }
       
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlCommand cmd;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter();
        private DataTable originalData;

        private void MonHoc_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=VINHPC07764\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaMonHoc as [Ma Mon], TenMonHoc as [Ten Mon] FROM QLMonHoc";
            adapter.SelectCommand = cmd;
            originalData = new DataTable();
            adapter.Fill(originalData);
            dataGridView1.DataSource = originalData;
            txtMaMonhoc.Text = "";
            txtTenMonhoc.Text = "";

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
            string str = @"Data Source=VINHPC07764\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

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
            string str = @"Data Source=VINHPC07764\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

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
            string str = @"Data Source=VINHPC07764\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int list = dataGridView1.CurrentRow.Index;
            txtMaMonhoc.Text = dataGridView1.Rows[list].Cells[0].Value.ToString();
            txtTenMonhoc.Text = dataGridView1.Rows[list].Cells[1].Value.ToString();
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
