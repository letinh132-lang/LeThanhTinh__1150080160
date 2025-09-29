using System;
using System.Windows.Forms;

namespace ThucHanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Sự kiện
            this.Load += Form1_Load;
            btnClose.Click += btnClose_Click;
            btnInput.Click += btnInput_Click;

            // Nhập bằng phím Enter
            txtInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnInput.PerformClick();
                    e.SuppressKeyPress = true; // không kêu "ding"
                }
            };

            // Chỉ cho nhập số nguyên (có thể có dấu âm)
            txtInput.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar) &&
                    e.KeyChar != '-')
                {
                    e.Handled = true;
                }
                // Chỉ cho phép 1 dấu '-' ở đầu
                if (e.KeyChar == '-' &&
                    (txtInput.SelectionStart != 0 || txtInput.Text.Contains("-")))
                {
                    e.Handled = true;
                }
            };

            btnTang2.Click += btnTang2_Click;
            btnChanDau.Click += btnChanDau_Click;
            btnLeCuoi.Click += btnLeCuoi_Click;
            btnXoaChon.Click += btnXoaChon_Click;
            btnXoaDau.Click += btnXoaDau_Click;
            btnXoaCuoi.Click += btnXoaCuoi_Click;
            btnXoaDaySo.Click += btnXoaDaySo_Click;
        }

        // ====== Handlers ======

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                                         "Xác nhận thoát",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string num = txtInput.Text.Trim();
            if (int.TryParse(num, out int a))
            {
                lsbDaySo.Items.Add(a);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Không phải số nguyên! Vui lòng nhập lại.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                lsbDaySo.Items[i] = (int)lsbDaySo.Items[i] + 2;
            }
        }

        private void btnChanDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            lsbDaySo.ClearSelected();
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if ((int)lsbDaySo.Items[i] % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            lsbDaySo.ClearSelected();
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if ((int)lsbDaySo.Items[i] % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            if (lsbDaySo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn phần tử cần xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            while (lsbDaySo.SelectedIndex != -1)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }
    }
}
