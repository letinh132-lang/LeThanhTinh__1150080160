using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab06_QuanLyNhaXuatBan
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối theo yêu cầu của bạn:
        private readonly string strCon =
            @"Data Source=LAPTOP-D1LMSN48\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True;TrustServerCertificate=True";

        private SqlConnection _cnn;

        public Form1()
        {
            InitializeComponent(); // do Designer tạo
        }

        // ===== KẾT NỐI DB =====
        private void OpenConn()
        {
            if (_cnn == null) _cnn = new SqlConnection(strCon);
            if (_cnn.State != ConnectionState.Open) _cnn.Open();
        }
        private void CloseConn()
        {
            if (_cnn != null && _cnn.State == ConnectionState.Open) _cnn.Close();
        }

        // ===== FORM LOAD =====
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPublishers();
                txtMaXB.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }
        }

        // ===== HIỂN THỊ DANH SÁCH NXB =====
        private void LoadPublishers()
        {
            lsvDanhSach.Items.Clear();

            OpenConn();
            using (var cmd = new SqlCommand("HienThiXB", _cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        var item = new ListViewItem(rd.GetString(0)); // MaXB
                        item.SubItems.Add(rd.GetString(1));            // TenXB
                        item.SubItems.Add(rd.GetString(2));            // DiaChi
                        lsvDanhSach.Items.Add(item);
                    }
                }
            }
            CloseConn();
        }

        // ===== HIỂN THỊ CHI TIẾT THEO MÃ =====
        private void ShowPublisherById(string maXB)
        {
            if (string.IsNullOrWhiteSpace(maXB)) return;

            OpenConn();
            using (var cmd = new SqlCommand("HienThiChiTietXB", _cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maXB", maXB);

                using (var rd = cmd.ExecuteReader())
                {
                    txtMaXB.Clear();
                    txtTenXB.Clear();
                    txtDiaChi.Clear();

                    if (rd.Read())
                    {
                        txtMaXB.Text = rd.GetString(0);
                        txtTenXB.Text = rd.GetString(1);
                        txtDiaChi.Text = rd.GetString(2);
                    }
                }
            }
            CloseConn();
        }

        // ===== SỰ KIỆN CHỌN DÒNG TRONG LISTVIEW =====
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            var id = lsvDanhSach.SelectedItems[0].SubItems[0].Text;
            ShowPublisherById(id);
        }

        // ===== THÊM =====
        private void btnThemDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaXB.Text) ||
                    string.IsNullOrWhiteSpace(txtTenXB.Text))
                {
                    MessageBox.Show("Nhập tối thiểu Mã XB và Tên XB.");
                    return;
                }

                OpenConn();
                using (var cmd = new SqlCommand("ThemDuLieu", _cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maXB", txtMaXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenXB", txtTenXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text.Trim());

                    var kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Thêm thành công!" : "Không có bản ghi nào được thêm.");
                }
                LoadPublishers();
                ClearInputs();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL lỗi (Thêm): " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi (Thêm): " + ex.Message);
            }
            finally { CloseConn(); }
        }

        // ===== SỬA =====
        private void btnSuaDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaXB.Text))
                {
                    MessageBox.Show("Chọn Mã XB cần sửa.");
                    return;
                }

                OpenConn();
                using (var cmd = new SqlCommand("SuaDuLieu", _cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maXB", txtMaXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenXB", txtTenXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text.Trim());

                    var kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Cập nhật thành công!" : "Không có bản ghi nào được cập nhật.");
                }
                LoadPublishers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL lỗi (Sửa): " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi (Sửa): " + ex.Message);
            }
            finally { CloseConn(); }
        }

        // ===== XÓA =====
        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaXB.Text))
                {
                    MessageBox.Show("Chọn Mã XB cần xóa.");
                    return;
                }
                if (MessageBox.Show("Xóa nhà xuất bản này?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                OpenConn();
                using (var cmd = new SqlCommand("XoaDuLieu", _cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maXB", txtMaXB.Text.Trim());

                    var kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Xóa thành công!" : "Không có bản ghi nào bị xóa.");
                }
                LoadPublishers();
                ClearInputs();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL lỗi (Xóa): " + ex.Message + "\nGhi chú: nếu bảng Sách còn tham chiếu MaXB, cần xử lý trước.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi (Xóa): " + ex.Message);
            }
            finally { CloseConn(); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtMaXB.Clear();
            txtTenXB.Clear();
            txtDiaChi.Clear();
            txtMaXB.Focus();
        }
    }
}
