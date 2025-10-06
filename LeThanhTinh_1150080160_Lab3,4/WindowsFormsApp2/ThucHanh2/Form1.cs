using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV_ApDung_Lop_SinhVien
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlCon;
        private readonly string strCon;

        public Form1()
        {
            InitializeComponent();
            strCon = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            // ListView hiển thị đẹp
            lsvSinhVien.FullRowSelect = true;
            lsvSinhVien.GridLines = true;
            lsvSinhVien.View = View.Details;
        }

        // --------- MODEL NHỎ CHO LISTBOX ----------
        private class LopItem
        {
            public string MaLop { get; set; } = "";
            public string TenLop { get; set; } = "";
            public override string ToString() => $"{TenLop} ({MaLop})";
        }

        // --------- LOAD LỚP KHI MỞ FORM ----------
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                EnsureOpen();

                using (var cmd = new SqlCommand("SELECT MaLop, TenLop FROM dbo.Lop ORDER BY TenLop", sqlCon))
                using (var rd = cmd.ExecuteReader())
                {
                    lsbDSLop.Items.Clear();
                    while (rd.Read())
                    {
                        var item = new LopItem
                        {
                            MaLop = rd["MaLop"].ToString(),
                            TenLop = rd["TenLop"].ToString()
                        };
                        lsbDSLop.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void EnsureOpen()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        // --------- CHỌN 1 LỚP -> HIỂN THỊ SINH VIÊN ----------
        private void lsbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDSLop.SelectedItem is LopItem lop)
            {
                try
                {
                    EnsureOpen();
                    lsvSinhVien.Items.Clear();

                    using (var cmd = new SqlCommand(@"
                        SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop
                        FROM dbo.SinhVien
                        WHERE MaLop = @MaLop
                        ORDER BY TenSV", sqlCon))
                    {
                        cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 20).Value = lop.MaLop;

                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                string maSV = rd["MaSV"]?.ToString();
                                string tenSV = rd["TenSV"]?.ToString();
                                string gioiTinh = rd["GioiTinh"]?.ToString();
                                string ngaySinh = rd["NgaySinh"] == DBNull.Value
                                                    ? ""
                                                    : Convert.ToDateTime(rd["NgaySinh"]).ToString("dd/MM/yyyy");
                                string queQuan = rd["QueQuan"]?.ToString();
                                string maLop = rd["MaLop"]?.ToString();

                                var lvi = new ListViewItem(maSV);
                                lvi.SubItems.Add(tenSV);
                                lvi.SubItems.Add(gioiTinh);
                                lvi.SubItems.Add(ngaySinh);
                                lvi.SubItems.Add(queQuan);
                                lvi.SubItems.Add(maLop);
                                lsvSinhVien.Items.Add(lvi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error");
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (sqlCon != null)
            {
                if (sqlCon.State != ConnectionState.Closed) sqlCon.Close();
                sqlCon.Dispose();
            }
            base.OnFormClosed(e);
        }
    }
}
