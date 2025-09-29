using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // (Tuỳ chọn) hạn chế nhập sai
            txtA.KeyPress += Numeric_KeyPress;
            txtB.KeyPress += Numeric_KeyPress;

            // Gắn sự kiện nút
            btnCong.Click += btnCong_Click;
            btnTru.Click += btnTru_Click;
            btnNhan.Click += btnNhan_Click;
            btnChia.Click += btnChia_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private bool TryGetInputs(out double a, out double b)
        {
            a = 0; b = 0;
            if (!double.TryParse(txtA.Text.Trim(), out a))
            {
                MessageBox.Show("Giá trị của a không hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus(); txtA.SelectAll();
                return false;
            }
            if (!double.TryParse(txtB.Text.Trim(), out b))
            {
                MessageBox.Show("Giá trị của b không hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus(); txtB.SelectAll();
                return false;
            }
            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            if (b == 0)
            {
                MessageBox.Show("Mẫu số không được bằng 0. Vui lòng nhập lại!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus(); txtB.SelectAll();
                return;
            }
            txtKetQua.Text = (a / b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                                    "Xác nhận thoát",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
        }

        // Chỉ cho phép số, dấu chấm, dấu âm và phím điều khiển
        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            var tb = (TextBox)sender;
            if (e.KeyChar == '.' && tb.Text.Contains(".")) e.Handled = true;
            if (e.KeyChar == '-' && (tb.SelectionStart != 0 || tb.Text.Contains("-"))) e.Handled = true;
        }

        private void btnNhan_Click_1(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
