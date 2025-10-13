namespace ThucHanh7_NoParam
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachSV = new System.Windows.Forms.ListView();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colQueQuan = new System.Windows.Forms.ColumnHeader();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.grpNhap.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(280, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm / Sửa / Xóa (KHÔNG dùng Parameter)";
            // 
            // grpNhap
            // 
            this.grpNhap.Controls.Add(this.btnXoaSV);
            this.grpNhap.Controls.Add(this.btnSuaThongTin);
            this.grpNhap.Controls.Add(this.btnThemSinhVien);
            this.grpNhap.Controls.Add(this.txtMaLop);
            this.grpNhap.Controls.Add(this.lblMaLop);
            this.grpNhap.Controls.Add(this.txtQueQuan);
            this.grpNhap.Controls.Add(this.lblQueQuan);
            this.grpNhap.Controls.Add(this.dtpNgaySinh);
            this.grpNhap.Controls.Add(this.lblNgaySinh);
            this.grpNhap.Controls.Add(this.cbGioiTinh);
            this.grpNhap.Controls.Add(this.lblGioiTinh);
            this.grpNhap.Controls.Add(this.txtTenSV);
            this.grpNhap.Controls.Add(this.lblTenSV);
            this.grpNhap.Controls.Add(this.txtMaSV);
            this.grpNhap.Controls.Add(this.lblMaSV);
            this.grpNhap.Location = new System.Drawing.Point(12, 36);
            this.grpNhap.Name = "grpNhap";
            this.grpNhap.Size = new System.Drawing.Size(304, 372);
            this.grpNhap.TabIndex = 1;
            this.grpNhap.TabStop = false;
            this.grpNhap.Text = "Nhập thông tin:";
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(20, 332);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(264, 28);
            this.btnXoaSV.TabIndex = 15;
            this.btnXoaSV.Text = "Xóa sinh viên";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(20, 298);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(264, 28);
            this.btnSuaThongTin.TabIndex = 14;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Location = new System.Drawing.Point(20, 264);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(264, 28);
            this.btnThemSinhVien.TabIndex = 13;
            this.btnThemSinhVien.Text = "Thêm sinh viên";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(104, 220);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(180, 23);
            this.txtMaLop.TabIndex = 12;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(22, 223);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(47, 15);
            this.lblMaLop.TabIndex = 11;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(104, 185);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(180, 23);
            this.txtQueQuan.TabIndex = 10;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(22, 188);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(62, 15);
            this.lblQueQuan.TabIndex = 9;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(104, 150);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(180, 23);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(22, 154);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(64, 15);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(104, 115);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(180, 23);
            this.cbGioiTinh.TabIndex = 6;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(22, 118);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 15);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(104, 80);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(180, 23);
            this.txtTenSV.TabIndex = 4;
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(22, 83);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(47, 15);
            this.lblTenSV.TabIndex = 3;
            this.lblTenSV.Text = "Tên SV:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(104, 45);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 23);
            this.txtMaSV.TabIndex = 2;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(22, 48);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(46, 15);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lsvDanhSachSV);
            this.grpDanhSach.Location = new System.Drawing.Point(322, 36);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(560, 372);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách sinh viên:";
            // 
            // lsvDanhSachSV
            // 
            this.lsvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan,
            this.colMaLop});
            this.lsvDanhSachSV.FullRowSelect = true;
            this.lsvDanhSachSV.GridLines = true;
            this.lsvDanhSachSV.Location = new System.Drawing.Point(16, 22);
            this.lsvDanhSachSV.MultiSelect = false;
            this.lsvDanhSachSV.Name = "lsvDanhSachSV";
            this.lsvDanhSachSV.Size = new System.Drawing.Size(528, 336);
            this.lsvDanhSachSV.TabIndex = 0;
            this.lsvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachSV.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachSV.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachSV_SelectedIndexChanged);
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 80;
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên SV";
            this.colTenSV.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 90;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê quán";
            this.colQueQuan.Width = 100;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 420);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpNhap);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThucHanh7_NoParam - Thêm/Sửa/Xóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNhap.ResumeLayout(false);
            this.grpNhap.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Button btnThemSinhVien;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnXoaSV;

        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lsvDanhSachSV;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}
