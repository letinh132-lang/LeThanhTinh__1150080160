using System.Windows.Forms;

namespace ApDung1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpInput;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;

        private GroupBox grpOption;
        private RadioButton rbUCLN;
        private RadioButton rbBCNN;

        private Label lblKQ;
        private TextBox txtKetQua;

        private Button btnTim;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.grpInput = new GroupBox();
            this.lblA = new Label();
            this.lblB = new Label();
            this.txtA = new TextBox();
            this.txtB = new TextBox();

            this.grpOption = new GroupBox();
            this.rbUCLN = new RadioButton();
            this.rbBCNN = new RadioButton();

            this.lblKQ = new Label();
            this.txtKetQua = new TextBox();

            this.btnTim = new Button();
            this.btnThoat = new Button();

            // ===== Form =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 280);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Tìm UCLN và BCNN của số nguyên a và b";

            // ===== grpInput =====
            this.grpInput.Text = "Nhập dữ liệu:";
            this.grpInput.Location = new System.Drawing.Point(20, 20);
            this.grpInput.Size = new System.Drawing.Size(360, 120);
            this.grpInput.BackColor = System.Drawing.Color.Honeydew;

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Text = "Số nguyên a:";
            this.lblA.Location = new System.Drawing.Point(20, 35);
            // txtA
            this.txtA.Location = new System.Drawing.Point(130, 32);
            this.txtA.Size = new System.Drawing.Size(200, 25);

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Text = "Số nguyên b:";
            this.lblB.Location = new System.Drawing.Point(20, 75);
            // txtB
            this.txtB.Location = new System.Drawing.Point(130, 72);
            this.txtB.Size = new System.Drawing.Size(200, 25);

            this.grpInput.Controls.Add(this.lblA);
            this.grpInput.Controls.Add(this.txtA);
            this.grpInput.Controls.Add(this.lblB);
            this.grpInput.Controls.Add(this.txtB);

            // ===== grpOption =====
            this.grpOption.Text = "Tùy chọn:";
            this.grpOption.Location = new System.Drawing.Point(400, 20);
            this.grpOption.Size = new System.Drawing.Size(200, 120);

            // rbUCLN
            this.rbUCLN.Text = "USCLN";
            this.rbUCLN.Location = new System.Drawing.Point(20, 35);
            this.rbUCLN.AutoSize = true;
            this.rbUCLN.Checked = true; // mặc định
            // rbBCNN
            this.rbBCNN.Text = "BSCNN";
            this.rbBCNN.Location = new System.Drawing.Point(20, 70);
            this.rbBCNN.AutoSize = true;

            this.grpOption.Controls.Add(this.rbUCLN);
            this.grpOption.Controls.Add(this.rbBCNN);

            // ===== Kết quả =====
            this.lblKQ.AutoSize = true;
            this.lblKQ.Text = "Kết quả:";
            this.lblKQ.Location = new System.Drawing.Point(20, 160);

            this.txtKetQua.Location = new System.Drawing.Point(90, 156);
            this.txtKetQua.Size = new System.Drawing.Size(470, 25);
            this.txtKetQua.ReadOnly = true;

            // ===== Buttons =====
            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(400, 200);
            this.btnTim.Size = new System.Drawing.Size(80, 28);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(490, 200);
            this.btnThoat.Size = new System.Drawing.Size(80, 28);

            // ===== Add to Form =====
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
        }
        #endregion
    }
}
