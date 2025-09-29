using System.Drawing;
using System.Windows.Forms;

namespace ApDung2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPassword, lblKeyboard, lblLog;
        private TextBox txtPassword;
        private Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private Button btnClear, btnEnter, btnRing;
        private DataGridView dgvLog;

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
            this.ClientSize = new Size(640, 420);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Security Panel - Áp dụng 2";

            // ==== Password ====
            lblPassword = new Label();
            lblPassword.AutoSize = true;
            lblPassword.Text = "Password:";
            lblPassword.Location = new Point(16, 18);

            txtPassword = new TextBox();
            txtPassword.Location = new Point(100, 14);
            txtPassword.Size = new Size(300, 25);
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = true;

            // ==== Keyboard label ====
            lblKeyboard = new Label();
            lblKeyboard.AutoSize = true;
            lblKeyboard.Text = "Keyboard:";
            lblKeyboard.Location = new Point(16, 56);

            // ==== Number buttons (3x3) ====
            int leftStart = 40, topStart = 88, w = 56, h = 38, gap = 14;

            btn1 = new Button() { Text = "1", Location = new Point(leftStart + (w + gap) * 0, topStart + (h + gap) * 0), Size = new Size(w, h) };
            btn2 = new Button() { Text = "2", Location = new Point(leftStart + (w + gap) * 1, topStart + (h + gap) * 0), Size = new Size(w, h) };
            btn3 = new Button() { Text = "3", Location = new Point(leftStart + (w + gap) * 2, topStart + (h + gap) * 0), Size = new Size(w, h) };

            btn4 = new Button() { Text = "4", Location = new Point(leftStart + (w + gap) * 0, topStart + (h + gap) * 1), Size = new Size(w, h) };
            btn5 = new Button() { Text = "5", Location = new Point(leftStart + (w + gap) * 1, topStart + (h + gap) * 1), Size = new Size(w, h) };
            btn6 = new Button() { Text = "6", Location = new Point(leftStart + (w + gap) * 2, topStart + (h + gap) * 1), Size = new Size(w, h) };

            btn7 = new Button() { Text = "7", Location = new Point(leftStart + (w + gap) * 0, topStart + (h + gap) * 2), Size = new Size(w, h) };
            btn8 = new Button() { Text = "8", Location = new Point(leftStart + (w + gap) * 1, topStart + (h + gap) * 2), Size = new Size(w, h) };
            btn9 = new Button() { Text = "9", Location = new Point(leftStart + (w + gap) * 2, topStart + (h + gap) * 2), Size = new Size(w, h) };

            // ==== Action buttons ====
            btnClear = new Button()
            {
                Text = "Clear",
                BackColor = Color.Khaki,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(360, topStart + 0 * (h + gap)),
                Size = new Size(96, h)
            };

            btnEnter = new Button()
            {
                Text = "Enter",
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(360, topStart + 1 * (h + gap)),
                Size = new Size(96, h)
            };

            btnRing = new Button()
            {
                Text = "RING",
                BackColor = Color.LightCoral,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(360, topStart + 2 * (h + gap)),
                Size = new Size(96, h)
            };

            // ==== Log ====
            lblLog = new Label();
            lblLog.AutoSize = true;
            lblLog.Text = "Login Log:";
            lblLog.Location = new Point(16, 240);

            dgvLog = new DataGridView();
            dgvLog.Location = new Point(20, 264);
            dgvLog.Size = new Size(600, 130);
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToResizeRows = false;
            dgvLog.RowHeadersVisible = false;
            dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.ReadOnly = true;

            dgvLog.Columns.Add("colTime", "Ngày giờ");
            dgvLog.Columns.Add("colGroup", "Nhóm");
            dgvLog.Columns.Add("colResult", "Kết quả");

            // ==== Add controls ====
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);

            this.Controls.Add(lblKeyboard);
            this.Controls.Add(btn1); this.Controls.Add(btn2); this.Controls.Add(btn3);
            this.Controls.Add(btn4); this.Controls.Add(btn5); this.Controls.Add(btn6);
            this.Controls.Add(btn7); this.Controls.Add(btn8); this.Controls.Add(btn9);

            this.Controls.Add(btnClear);
            this.Controls.Add(btnEnter);
            this.Controls.Add(btnRing);

            this.Controls.Add(lblLog);
            this.Controls.Add(dgvLog);
        }
        #endregion
    }
}
