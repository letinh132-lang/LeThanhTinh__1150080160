using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanSachLab7
{
    public partial class Form1 : Form
    {
        // === CHUỖI KẾT NỐI: thay đúng đường dẫn .mdf của bạn ===
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Bai1,2\Lab7,8\Lab7,8\QuanLyBanSach.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        // ===== KẾT NỐI =====
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        // ===== LOAD/HIỂN THỊ =====
        private void HienThi()
        {
            try
            {
                MoKetNoi();

                const string sql = "SELECT MaNXB, TenNXB, DiaChi FROM dbo.NhaXuatBan";
                adapter = new SqlDataAdapter(sql, sqlCon);

                // Tự sinh Insert/Update/Delete + lấy khóa chính
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _ = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "tblNhaXuatBan");

                if (ds.Tables["tblNhaXuatBan"].PrimaryKey.Length == 0)
                    ds.Tables["tblNhaXuatBan"].PrimaryKey =
                        new[] { ds.Tables["tblNhaXuatBan"].Columns["MaNXB"] };

                dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];

                // mặc định trạng thái: THÊM (được nhập PK)
                txtMaNXB.ReadOnly = false;
                ClearInputs(allowEditPK: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        // ===== TIỆN ÍCH UI =====
        private void ClearInputs(bool allowEditPK)
        {
            if (allowEditPK) txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiaChi.Clear();
            if (allowEditPK) { txtMaNXB.ReadOnly = false; txtMaNXB.Focus(); }
        }

        // ===== GRID -> Ô NHẬP (chế độ SỬA/XÓA) =====
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var ma = dgvDanhSach.Rows[e.RowIndex].Cells["MaNXB"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(ma)) return;

            var dr = ds.Tables["tblNhaXuatBan"].Rows.Find(ma);
            if (dr == null) return;

            txtMaNXB.Text = dr["MaNXB"].ToString().Trim();
            txtTenNXB.Text = dr["TenNXB"]?.ToString().Trim();
            txtDiaChi.Text = dr["DiaChi"]?.ToString().Trim();

            // Khi chọn dòng: khoá PK để tránh đổi khoá khi cập nhật/xóa
            txtMaNXB.ReadOnly = true;
        }

        // ===== NÚT: HIỂN THỊ (reload) =====
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        // ===== NÚT: THÊM =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaNXB.Text.Trim();
                string ten = txtTenNXB.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();

                if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                { MessageBox.Show("Mã NXB và Tên NXB không được để trống."); return; }

                if (ma.Length != 6)
                { MessageBox.Show("Mã NXB phải đủ 6 ký tự (VD: NXB001)."); return; }

                if (ds.Tables["tblNhaXuatBan"].Rows.Find(ma) != null)
                { MessageBox.Show("Mã NXB đã tồn tại, nhập mã khác."); return; }

                DataRow row = ds.Tables["tblNhaXuatBan"].NewRow();
                row["MaNXB"] = ma;
                row["TenNXB"] = ten;
                row["DiaChi"] = diachi;
                ds.Tables["tblNhaXuatBan"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    HienThi(); // về trạng thái thêm
                }
                else MessageBox.Show("Thêm không thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        // ===== NÚT: CẬP NHẬT =====
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaNXB.Text.Trim();
                string ten = txtTenNXB.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();

                if (string.IsNullOrWhiteSpace(ma))
                { MessageBox.Show("Chọn một dòng ở danh sách trước khi cập nhật."); return; }
                if (string.IsNullOrWhiteSpace(ten))
                { MessageBox.Show("Tên NXB không được để trống."); return; }

                DataRow dr = ds.Tables["tblNhaXuatBan"].Rows.Find(ma);
                if (dr == null) { MessageBox.Show("Không tìm thấy bản ghi!"); return; }

                dr.BeginEdit();
                dr["TenNXB"] = ten;
                dr["DiaChi"] = diachi;
                dr.EndEdit();

                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    HienThi();
                }
                else MessageBox.Show("Cập nhật không thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi cập nhật: " + ex.Message); }
        }

        // ===== NÚT: XÓA =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaNXB.Text.Trim();
                if (string.IsNullOrWhiteSpace(ma))
                { MessageBox.Show("Chọn một dòng ở danh sách trước khi xóa."); return; }

                var dr = ds.Tables["tblNhaXuatBan"].Rows.Find(ma);
                if (dr == null) { MessageBox.Show("Không tìm thấy bản ghi để xóa!"); return; }

                var confirm = MessageBox.Show($"Bạn chắc chắn muốn xóa NXB '{ma}'?",
                    "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;

                dr.Delete();
                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThi();
                }
                else MessageBox.Show("Xóa không thành công!");
            }
            catch (SqlException ex)
            {
                // thường gặp: ràng buộc FK
                MessageBox.Show("SQL error: " + ex.Message);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
        }
    }
}
