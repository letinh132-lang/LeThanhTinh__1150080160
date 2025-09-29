using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ApDung3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện
            btnDangNhap.Click += btnDangNhap_Click;
            btnThoat.Click += (s, e) => Close();
            txtUser.Validating += txtUser_Validating;
            txtPass.Validating += txtPass_Validating;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                e.Cancel = true;
                err.SetError(txtUser, "Username không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtUser, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                e.Cancel = true;
                err.SetError(txtPass, "Password không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtPass, null);
            }
        }
    }
}
