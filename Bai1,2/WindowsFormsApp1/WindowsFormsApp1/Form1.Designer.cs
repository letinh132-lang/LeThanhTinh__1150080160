namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary> Required designer variable. </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo control (Designer quản lý)
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;

        /// <summary> Clean up any resources being used. </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỰC HIỆN CÁC PHÉP TÍNH SỐ HỌC";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(60, 70);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(92, 23);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Nhập số a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(60, 105);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(93, 23);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Nhập số b:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(60, 185);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(73, 23);
            this.lblKQ.TabIndex = 9;
            this.lblKQ.Text = "Kết quả:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(160, 66);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(220, 30);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "3";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(160, 101);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(220, 30);
            this.txtB.TabIndex = 4;
            this.txtB.Text = "3";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(150, 185);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(220, 30);
            this.txtKetQua.TabIndex = 10;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(60, 140);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(70, 28);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(150, 140);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(70, 28);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(240, 140);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(70, 28);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click_1);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(330, 140);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(70, 28);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(160, 220);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 28);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(260, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 28);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực hành 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
