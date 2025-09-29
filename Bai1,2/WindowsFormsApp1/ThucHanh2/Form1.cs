using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện
            btnTinhTien.Click += btnTinhTien_Click;
            btnThoat.Click += (s, e) => Close();
            txtTenKH.Validating += txtTenKH_Validating;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double thanhTien = 0;

            // Kiểm tra hợp lệ tên KH (ErrorProvider)
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (chkLayCaoRang.Checked)
                    thanhTien += 50_000;

                if (chkTayTrangRang.Checked)
                    thanhTien += 100_000;

                if (chkHanRang.Checked)
                    thanhTien += (int)nupHanRang.Value * 100_000;

                if (chkBeRang.Checked)
                    thanhTien += (int)nupBeRang.Value * 10_000;

                if (chkBocRang.Checked)
                    thanhTien += (int)nupBocRang.Value * 1_000_000;

                txtThanhTien.Text = thanhTien.ToString("N0") + " VND";
            }
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text.Trim()))
            {
                e.Cancel = true;
                err.SetError(txtTenKH, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
            }
        }
    }
}
