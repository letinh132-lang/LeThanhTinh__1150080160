using System;
using System.Windows.Forms;

namespace ApDung2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Bàn phím số
            btn1.Click += (s, e) => txtPassword.Text += "1";
            btn2.Click += (s, e) => txtPassword.Text += "2";
            btn3.Click += (s, e) => txtPassword.Text += "3";
            btn4.Click += (s, e) => txtPassword.Text += "4";
            btn5.Click += (s, e) => txtPassword.Text += "5";
            btn6.Click += (s, e) => txtPassword.Text += "6";
            btn7.Click += (s, e) => txtPassword.Text += "7";
            btn8.Click += (s, e) => txtPassword.Text += "8";
            btn9.Click += (s, e) => txtPassword.Text += "9";

            btnClear.Click += (s, e) => txtPassword.Clear();
            btnEnter.Click += BtnEnter_Click;
            btnRing.Click += (s, e) =>
                MessageBox.Show("Chuông báo động!!!", "RING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string input = txtPassword.Text.Trim();
            string nhom = "Không có";
            string ketqua = "Từ chối!";

            // bảng password
            if (input == "1496" || input == "2673") { nhom = "Phát triển công nghệ"; ketqua = "Chấp nhận!"; }
            else if (input == "7462") { nhom = "Nghiên cứu viên"; ketqua = "Chấp nhận!"; }
            else if (input == "8884" || input == "3842" || input == "3383")
            { nhom = "Thiết kế mô hình"; ketqua = "Chấp nhận!"; }

            dgvLog.Rows.Add(DateTime.Now.ToString("g"), nhom, ketqua);
            txtPassword.Clear();
        }
    }
}
