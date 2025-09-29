using System.Drawing;
using System.Windows.Forms;

namespace ThucHanh3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblHeader, lblNhap, lblFunc, lblList;
        private TextBox txtInput;
        private Button btnInput, btnClose,
                       btnTang2, btnChanDau, btnLeCuoi,
                       btnXoaChon, btnXoaDau, btnXoaCuoi, btnXoaDaySo;
        private ListBox lsbDaySo;
        private Panel sep;

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
            this.ClientSize = new Size(620, 430);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng xử lý dãy số";

            // ===== Header =====
            lblHeader = new Label();
            lblHeader.Text = "Ứng dụng xử lý dãy số";
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.BackColor = Color.Teal;
            lblHeader.ForeColor = Color.White;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Height = 50;

            // ===== Nhập số =====
            lblNhap = new Label() { Text = "Nhập số nguyên:", AutoSize = true, Location = new Point(20, 65) };

            txtInput = new TextBox() { Location = new Point(140, 62), Size = new Size(180, 25) };

            btnInput = new Button() { Text = "Nhập số", Location = new Point(330, 60), Size = new Size(90, 28) };

            // ===== List & chức năng =====
            lblList = new Label() { Text = "lsbDaySo", AutoSize = true, Location = new Point(20, 100) };
            lblFunc = new Label() { Text = "Chức năng:", AutoSize = true, Location = new Point(340, 100) };

            lsbDaySo = new ListBox()
            {
                Location = new Point(20, 120),
                Size = new Size(280, 220)
            };

            sep = new Panel() { Location = new Point(315, 120), Size = new Size(1, 220), BackColor = Color.Silver };

            btnTang2 = new Button() { Text = "Tăng mỗi phần tử lên 2", Location = new Point(340, 120), Size = new Size(240, 30) };
            btnChanDau = new Button() { Text = "Chọn số chẵn đầu", Location = new Point(340, 160), Size = new Size(240, 30) };
            btnLeCuoi = new Button() { Text = "Chọn số lẻ cuối", Location = new Point(340, 200), Size = new Size(240, 30) };
            btnXoaChon = new Button() { Text = "Xóa phần tử đang chọn", Location = new Point(340, 240), Size = new Size(240, 30) };
            btnXoaDau = new Button() { Text = "Xóa phần tử đầu", Location = new Point(340, 280), Size = new Size(240, 30) };
            btnXoaCuoi = new Button() { Text = "Xóa phần tử cuối", Location = new Point(340, 320), Size = new Size(240, 30) };

            // ===== Buttons bottom =====
            btnClose = new Button() { Text = "Kết thúc ứng dụng", Location = new Point(20, 360), Size = new Size(180, 32), BackColor = Color.IndianRed, ForeColor = Color.White };
            btnXoaDaySo = new Button() { Text = "Xóa dãy số", Location = new Point(210, 360), Size = new Size(180, 32), Enabled = true };

            // Thêm control
            this.Controls.Add(lblHeader);
            this.Controls.Add(lblNhap);
            this.Controls.Add(txtInput);
            this.Controls.Add(btnInput);

            this.Controls.Add(lblList);
            this.Controls.Add(lblFunc);
            this.Controls.Add(lsbDaySo);
            this.Controls.Add(sep);

            this.Controls.Add(btnTang2);
            this.Controls.Add(btnChanDau);
            this.Controls.Add(btnLeCuoi);
            this.Controls.Add(btnXoaChon);
            this.Controls.Add(btnXoaDau);
            this.Controls.Add(btnXoaCuoi);

            this.Controls.Add(btnClose);
            this.Controls.Add(btnXoaDaySo);
        }
        #endregion
    }
}
