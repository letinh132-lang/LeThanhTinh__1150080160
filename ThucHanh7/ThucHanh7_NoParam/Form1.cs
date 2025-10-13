using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh7_NoParam
{
    public partial class Form1 : Form
    {
        // Kết nối LocalDB tới file DBConnect.mdf của CHÍNH project này
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon;

        public Form1()
        {
            InitializeComponent();
        }

        #region Kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedIndex = -1;

            HienThiDanhSach();
        }

        // Escape dấu nháy đơn khi NỐI CHUỖI (NoParam)
        private string Esc(string s) => (s ?? string.Empty).Replace("'", "''");

        private void HienThiDanhSach()
        {
            try
            {
                MoKetNoi();
                string sql = "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM dbo.SinhVien ORDER BY MaSV";
                using (var cmd = new SqlCommand(sql, sqlCon))
                using (var rd = cmd.ExecuteReader())
                {
                    lsvDanhSachSV.Items.Clear();
                    while (rd.Read())
                    {
                        var it = new ListViewItem(rd.GetString(0));                 // MaSV
                        it.SubItems.Add(rd.GetString(1));                            // TenSV
                        it.SubItems.Add(rd.GetString(2));                            // GioiTinh
                        it.SubItems.Add(rd.GetDateTime(3).ToString("dd/MM/yyyy"));   // NgaySinh
                        it.SubItems.Add(rd.GetString(4));                            // QueQuan
                        it.SubItems.Add(rd.GetString(5));                            // MaLop
                        lsvDanhSachSV.Items.Add(it);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)) { MessageBox.Show("Nhập Mã SV"); txtMaSV.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtTenSV.Text)) { MessageBox.Show("Nhập Tên SV"); txtTenSV.Focus(); return false; }
            if (cbGioiTinh.SelectedItem == null) { MessageBox.Show("Chọn Giới tính"); cbGioiTinh.DroppedDown = true; return false; }
            if (string.IsNullOrWhiteSpace(txtQueQuan.Text)) { MessageBox.Show("Nhập Quê quán"); txtQueQuan.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtMaLop.Text)) { MessageBox.Show("Nhập Mã lớp"); txtMaLop.Focus(); return false; }
            return true;
        }

        private void ClearInput()
        {
            txtMaSV.ReadOnly = false;
            txtMaSV.Clear();
            txtTenSV.Clear();
            cbGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Today;
            txtQueQuan.Clear();
            txtMaLop.Clear();
            txtMaSV.Focus();
        }

        // ===== THÊM (NO PARAM) =====
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string maSV = Esc(txtMaSV.Text.Trim());
            string tenSV = Esc(txtTenSV.Text.Trim());
            string gioiTinh = Esc(cbGioiTinh.SelectedItem.ToString());
            string ngaySql = dtpNgaySinh.Value.Date.ToString("yyyy-MM-dd"); // ISO để SQL hiểu đúng
            string queQuan = Esc(txtQueQuan.Text.Trim());
            string maLop = Esc(txtMaLop.Text.Trim());

            string sql = "INSERT INTO dbo.SinhVien(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop) " +
                         $"VALUES ('{maSV}', N'{tenSV}', N'{gioiTinh}', '{ngaySql}', N'{queQuan}', '{maLop}')";

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HienThiDanhSach();
                        ClearInput();
                    }
                    else MessageBox.Show("Không có bản ghi nào được thêm.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
            finally { DongKetNoi(); }
        }

        // ===== CHỌN 1 DÒNG -> ĐỔ LÊN FORM =====
        private void lsvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachSV.SelectedItems.Count == 0) return;

            var it = lsvDanhSachSV.SelectedItems[0];
            txtMaSV.Text = it.SubItems[0].Text;
            txtMaSV.ReadOnly = true; // không cho đổi khóa chính khi sửa

            txtTenSV.Text = it.SubItems[1].Text;
            cbGioiTinh.SelectedItem = it.SubItems[2].Text;
            dtpNgaySinh.Value = DateTime.ParseExact(it.SubItems[3].Text, "dd/MM/yyyy", null);
            txtQueQuan.Text = it.SubItems[4].Text;
            txtMaLop.Text = it.SubItems[5].Text;
        }

        // ===== SỬA (NO PARAM) =====
        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Hãy chọn SV để sửa."); return;
            }
            if (!ValidateInput()) return;

            string maSV = Esc(txtMaSV.Text.Trim());
            string tenSV = Esc(txtTenSV.Text.Trim());
            string gioiTinh = Esc(cbGioiTinh.SelectedItem.ToString());
            string ngaySql = dtpNgaySinh.Value.Date.ToString("yyyy-MM-dd");
            string queQuan = Esc(txtQueQuan.Text.Trim());
            string maLop = Esc(txtMaLop.Text.Trim());

            string sql = "UPDATE dbo.SinhVien SET " +
                         $"TenSV=N'{tenSV}', GioiTinh=N'{gioiTinh}', NgaySinh='{ngaySql}', " +
                         $"QueQuan=N'{queQuan}', MaLop='{maLop}' " +
                         $"WHERE MaSV='{maSV}'";

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        HienThiDanhSach();
                        ClearInput();
                    }
                    else MessageBox.Show("Không có bản ghi nào được cập nhật.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi cập nhật: " + ex.Message); }
            finally { DongKetNoi(); }
        }

        // ===== XÓA (NO PARAM) =====
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                if (lsvDanhSachSV.SelectedItems.Count > 0)
                    ma = lsvDanhSachSV.SelectedItems[0].SubItems[0].Text;
            }
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Hãy chọn/nhập Mã SV để xóa."); return;
            }

            if (MessageBox.Show($"Bạn chắc chắn muốn xóa SV: {ma}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            string sql = $"DELETE FROM dbo.SinhVien WHERE MaSV='{Esc(ma)}'";

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        HienThiDanhSach();
                        ClearInput();
                    }
                    else MessageBox.Show("Không tìm thấy Mã SV để xóa.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            finally { DongKetNoi(); }
        }
    }
}
