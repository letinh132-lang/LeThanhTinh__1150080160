using System.Drawing;
using System.Windows.Forms;

namespace ThucHanh2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private Label lblHeader, lblTen;
        private GroupBox grpDV, grpCN;
        private Label lblGia1, lblGia2, lblGia3, lblGia4, lblGia5, lblKq;

        private TextBox txtTenKH, txtThanhTien;

        private CheckBox chkLayCaoRang, chkTayTrangRang, chkHanRang, chkBeRang, chkBocRang;
        private NumericUpDown nupHanRang, nupBeRang, nupBocRang;

        private Button btnTinhTien, btnThoat;

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

            // ===== Form =====
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(660, 400);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Phòng khám nha khoa";

            // ===== Header =====
            lblHeader = new Label();
            lblHeader.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.BackColor = Color.LimeGreen;
            lblHeader.ForeColor = Color.White;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Height = 50;

            // ===== Tên khách hàng =====
            lblTen = new Label();
            lblTen.Text = "Tên khách hàng:";
            lblTen.AutoSize = true;
            lblTen.Location = new Point(20, 68);

            txtTenKH = new TextBox();
            txtTenKH.Location = new Point(145, 65);
            txtTenKH.Size = new Size(360, 25);

            err = new ErrorProvider(this.components);
            err.ContainerControl = this;

            // ===== Group Dịch vụ =====
            grpDV = new GroupBox();
            grpDV.Text = "Dịch vụ tại phòng khám:";
            grpDV.Location = new Point(20, 100);
            grpDV.Size = new Size(620, 180);

            chkLayCaoRang = new CheckBox() { Text = "Lấy cao răng", Location = new Point(18, 32), AutoSize = true, Checked = true };
            chkTayTrangRang = new CheckBox() { Text = "Tẩy trắng răng", Location = new Point(18, 62), AutoSize = true, Checked = true };
            chkHanRang = new CheckBox() { Text = "Hàn răng", Location = new Point(18, 92), AutoSize = true };
            chkBeRang = new CheckBox() { Text = "Bẻ răng", Location = new Point(18, 122), AutoSize = true };
            chkBocRang = new CheckBox() { Text = "Bọc răng", Location = new Point(18, 152), AutoSize = true };

            lblGia1 = new Label() { Text = "50.000đ/2 hàm", Location = new Point(190, 32), AutoSize = true };
            lblGia2 = new Label() { Text = "100.000đ/2 hàm", Location = new Point(190, 62), AutoSize = true };
            lblGia3 = new Label() { Text = "100.000đ/1 răng", Location = new Point(190, 92), AutoSize = true };
            lblGia4 = new Label() { Text = "10.000đ/1 răng", Location = new Point(190, 122), AutoSize = true };
            lblGia5 = new Label() { Text = "1.000.000đ/1 răng", Location = new Point(190, 152), AutoSize = true };

            nupHanRang = new NumericUpDown() { Location = new Point(360, 90), Width = 60, Minimum = 0, Maximum = 100, Value = 1 };
            nupBeRang = new NumericUpDown() { Location = new Point(360, 120), Width = 60, Minimum = 0, Maximum = 100, Value = 1 };
            nupBocRang = new NumericUpDown() { Location = new Point(360, 150), Width = 60, Minimum = 0, Maximum = 100, Value = 1 };

            grpDV.Controls.AddRange(new Control[] {
                chkLayCaoRang, chkTayTrangRang, chkHanRang, chkBeRang, chkBocRang,
                lblGia1, lblGia2, lblGia3, lblGia4, lblGia5,
                nupHanRang, nupBeRang, nupBocRang
            });

            // ===== Group Chức năng =====
            grpCN = new GroupBox();
            grpCN.Text = "Chức năng:";
            grpCN.Location = new Point(20, 290);
            grpCN.Size = new Size(620, 80);

            lblKq = new Label() { Text = "Kết quả:", Location = new Point(18, 36), AutoSize = true };

            txtThanhTien = new TextBox()
            {
                Location = new Point(78, 33),
                Size = new Size(260, 25),
                ReadOnly = true
            };

            btnTinhTien = new Button()
            {
                Text = "Tính tiền",
                Location = new Point(360, 31),
                Size = new Size(100, 28)
            };

            btnThoat = new Button()
            {
                Text = "Thoát",
                Location = new Point(470, 31),
                Size = new Size(100, 28)
            };

            grpCN.Controls.AddRange(new Control[] { lblKq, txtThanhTien, btnTinhTien, btnThoat });

            // ===== Add all to Form =====
            this.Controls.Add(lblHeader);
            this.Controls.Add(lblTen);
            this.Controls.Add(txtTenKH);
            this.Controls.Add(grpDV);
            this.Controls.Add(grpCN);
        }
        #endregion
    }
}
