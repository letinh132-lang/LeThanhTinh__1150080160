using System;
using System.Windows.Forms;

namespace ApDung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // hạn chế nhập sai
            txtA.KeyPress += Numeric_KeyPress;
            txtB.KeyPress += Numeric_KeyPress;

            // gắn sự kiện nút
            btnTim.Click += btnTim_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a))
            {
                MessageBox.Show("Số nguyên a không hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus(); txtA.SelectAll(); return;
            }
            if (!int.TryParse(txtB.Text.Trim(), out int b))
            {
                MessageBox.Show("Số nguyên b không hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus(); txtB.SelectAll(); return;
            }

            if (rbUCLN.Checked)
            {
                int u = GCD(a, b);
                txtKetQua.Text = $"UCLN({a}, {b}) = {u}";
            }
            else if (rbBCNN.Checked)
            {
                int u = GCD(a, b);
                long bcnn = (long)Math.Abs((long)a * (long)b) / (u == 0 ? 1 : u);
                txtKetQua.Text = $"BCNN({a}, {b}) = {bcnn}";
            }
            else
            {
                MessageBox.Show("Hãy chọn UCLN hoặc BCNN!", "Thiếu lựa chọn",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
        }

        // Thuật toán Euclid
        private int GCD(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (y != 0) { int t = y; y = x % y; x = t; }
            return x;
        }

        // Chỉ cho số, dấu âm, phím điều khiển
        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
            var tb = (TextBox)sender;
            if (e.KeyChar == '-' && (tb.SelectionStart != 0 || tb.Text.Contains("-")))
                e.Handled = true;
        }
    }
}
