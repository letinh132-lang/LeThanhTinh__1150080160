using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh7
{
    public partial class Form1 : Form
    {
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon;
        private string _selectedMaSVForEdit = null; // dùng cho Sửa/Xóa

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

        private void HienThiDanhSach()
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(
                    "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM dbo.SinhVien ORDER BY MaSV", sqlCon))
                using (var rd = cmd.ExecuteReader())
                {
                    lsvDanhSachSV.Items.Clear();
                    while (rd.Read())
                    {
                        var item = new ListViewItem(rd.GetString(0));
                        item.SubItems.Add(rd.GetString(1));
                        item.SubItems.Add(rd.GetString(2));
                        item.SubItems.Add(rd.GetDateTime(3).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(rd.GetString(4));
                        item.SubItems.Add(rd.GetString(5));
                        lsvDanhSachSV.Items.Add(item);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hiển thị: " + ex.Message); }
            finally { DongKetNoi(); }
        }

        #region Validate/Clear
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)) { MessageBox.Show("Vui lòng nhập Mã SV"); txtMaSV.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtTenSV.Text)) { MessageBox.Show("Vui lòng nhập Tên SV"); txtTenSV.Focus(); return false; }
            if (cbGioiTinh.SelectedItem == null) { MessageBox.Show("Vui lòng chọn Giới tính"); cbGioiTinh.DroppedDown = true; return false; }
            if (string.IsNullOrWhiteSpace(txtQueQuan.Text)) { MessageBox.Show("Vui lòng nhập Quê quán"); txtQueQuan.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtMaLop.Text)) { MessageBox.Show("Vui lòng nhập Mã lớp"); txtMaLop.Focus(); return false; }
            return true;
        }
        private void ClearInput()
        {
            txtMaSV.ReadOnly = false;
            _selectedMaSVForEdit = null;

            txtMaSV.Clear();
            txtTenSV.Clear();
            cbGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Today;
            txtQueQuan.Clear();
            txtMaLop.Clear();
            txtMaSV.Focus();
        }
        #endregion

        #region Thêm
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            string queQuan = txtQueQuan.Text.Trim();
            string maLop = txtMaLop.Text.Trim();

            try
            {
                MoKetNoi();
                const string sql =
                    @"INSERT INTO dbo.SinhVien (MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop)
                      VALUES (@MaSV, @TenSV, @GioiTinh, @NgaySinh, @QueQuan, @MaLop)";
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 20).Value = maSV;
                    cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar, 100).Value = tenSV;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = gioiTinh;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                    cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 100).Value = queQuan;
                    cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 20).Value = maLop;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công!");
                        HienThiDanhSach();
                        ClearInput();
                    }
                    else MessageBox.Show("Không có bản ghi nào được thêm.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message); }
            finally { DongKetNoi(); }
        }
        #endregion

        #region Sửa
        private void lsvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachSV.SelectedItems.Count == 0) return;

            var it = lsvDanhSachSV.SelectedItems[0];
            _selectedMaSVForEdit = it.SubItems[0].Text;
            txtMaSV.Text = _selectedMaSVForEdit;
            txtMaSV.ReadOnly = true;

            txtTenSV.Text = it.SubItems[1].Text;
            cbGioiTinh.SelectedItem = it.SubItems[2].Text;
            dtpNgaySinh.Value = DateTime.ParseExact(it.SubItems[3].Text, "dd/MM/yyyy", null);
            txtQueQuan.Text = it.SubItems[4].Text;
            txtMaLop.Text = it.SubItems[5].Text;
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (_selectedMaSVForEdit == null) { MessageBox.Show("Chọn một sinh viên để sửa."); return; }
            if (!ValidateInput()) return;

            try
            {
                MoKetNoi();
                const string sql =
                    @"UPDATE dbo.SinhVien SET
                        TenSV=@TenSV, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh,
                        QueQuan=@QueQuan, MaLop=@MaLop
                      WHERE MaSV=@MaSV";
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar, 100).Value = txtTenSV.Text.Trim();
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = cbGioiTinh.SelectedItem.ToString();
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value.Date;
                    cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 100).Value = txtQueQuan.Text.Trim();
                    cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 20).Value = txtMaLop.Text.Trim();
                    cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 20).Value = _selectedMaSVForEdit;

                    if (cmd.ExecuteNonQuery() > 0)
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
        #endregion

        #region Xóa
        // TH4 – KHÔNG dùng Parameter (chỉ để minh họa, KHÔNG khuyến nghị):
        private int Xoa_KhongParameter(string maSV)
        {
            var sql = "DELETE FROM dbo.SinhVien WHERE MaSV = '" + maSV.Replace("'", "''") + "'";
            using (var cmd = new SqlCommand(sql, sqlCon)) { return cmd.ExecuteNonQuery(); }
        }

        // ÁP DỤNG 3 – CÓ dùng Parameter (khuyến nghị, sẽ dùng mặc định)
        private int Xoa_CoParameter(string maSV)
        {
            const string sql = "DELETE FROM dbo.SinhVien WHERE MaSV=@MaSV";
            using (var cmd = new SqlCommand(sql, sqlCon))
            {
                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 20).Value = maSV;
                return cmd.ExecuteNonQuery();
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            // chọn từ list
            string ma = _selectedMaSVForEdit ?? txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Hãy chọn 1 sinh viên (hoặc nhập Mã SV) để xóa.");
                return;
            }

            if (MessageBox.Show($"Bạn chắc chắn xóa SV: {ma}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                MoKetNoi();

                // CHỌN 1 TRONG 2 DÒNG DƯỚI (mặc định dùng Parameter)
                //int kq = Xoa_KhongParameter(ma);   // TH4: nối chuỗi
                int kq = Xoa_CoParameter(ma);        // Áp dụng 3: parameter

                if (kq > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    HienThiDanhSach();
                    ClearInput();
                }
                else MessageBox.Show("Không tìm thấy Mã SV để xóa.");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            finally { DongKetNoi(); }
        }
        #endregion
    }
}
