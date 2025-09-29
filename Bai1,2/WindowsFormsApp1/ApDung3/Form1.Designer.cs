using System.Drawing;
using System.Windows.Forms;

namespace ApDung3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblUser, lblPass, lblHeader;
        private TextBox txtUser, txtPass;
        private Button btnDangNhap, btnThoat;
        private ErrorProvider err;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ==== Form ====
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 240);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";

            // ==== Header ====
            lblHeader = new Label();
            lblHeader.Text = "FORM ĐĂNG NHẬP";
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Height = 50;

            // ==== Username ====
            lblUser = new Label();
            lblUser.Text = "Username:";
            lblUser.Location = new Point(40, 70);
            lblUser.AutoSize = true;

            txtUser = new TextBox();
            txtUser.Location = new Point(140, 66);
            txtUser.Size = new Size(200, 25);

            // ==== Password ====
            lblPass = new Label();
            lblPass.Text = "Password:";
            lblPass.Location = new Point(40, 110);
            lblPass.AutoSize = true;

            txtPass = new TextBox();
            txtPass.Location = new Point(140, 106);
            txtPass.Size = new Size(200, 25);
            txtPass.UseSystemPasswordChar = true;

            // ==== Buttons ====
            btnDangNhap = new Button();
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Location = new Point(140, 160);
            btnDangNhap.Size = new Size(90, 28);

            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(250, 160);
            btnThoat.Size = new Size(90, 28);

            // ==== ErrorProvider ====
            err = new ErrorProvider(this.components);
            err.ContainerControl = this;

            // ==== Add controls ====
            this.Controls.Add(lblHeader);
            this.Controls.Add(lblUser);
            this.Controls.Add(txtUser);
            this.Controls.Add(lblPass);
            this.Controls.Add(txtPass);
            this.Controls.Add(btnDangNhap);
            this.Controls.Add(btnThoat);
        }
        #endregion
    }
}
