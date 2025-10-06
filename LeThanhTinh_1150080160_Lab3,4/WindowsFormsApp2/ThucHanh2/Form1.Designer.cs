namespace QLSV_ApDung_Lop_SinhVien
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDSLop;
        private System.Windows.Forms.Label lblDSSV;
        private System.Windows.Forms.ListBox lsbDSLop;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDSLop = new System.Windows.Forms.Label();
            this.lblDSSV = new System.Windows.Forms.Label();
            this.lsbDSLop = new System.Windows.Forms.ListBox();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colQueQuan = new System.Windows.Forms.ColumnHeader();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Áp dụng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSLop
            // 
            this.lblDSLop.AutoSize = true;
            this.lblDSLop.Location = new System.Drawing.Point(20, 50);
            this.lblDSLop.Name = "lblDSLop";
            this.lblDSLop.Size = new System.Drawing.Size(76, 15);
            this.lblDSLop.TabIndex = 1;
            this.lblDSLop.Text = "Danh sách lớp:";
            // 
            // lblDSSV
            // 
            this.lblDSSV.AutoSize = true;
            this.lblDSSV.Location = new System.Drawing.Point(220, 50);
            this.lblDSSV.Name = "lblDSSV";
            this.lblDSSV.Size = new System.Drawing.Size(101, 15);
            this.lblDSSV.TabIndex = 2;
            this.lblDSSV.Text = "Danh sách sinh viên:";
            // 
            // lsbDSLop
            // 
            this.lsbDSLop.FormattingEnabled = true;
            this.lsbDSLop.ItemHeight = 15;
            this.lsbDSLop.Location = new System.Drawing.Point(20, 70);
            this.lsbDSLop.Name = "lsbDSLop";
            this.lsbDSLop.Size = new System.Drawing.Size(180, 334);
            this.lsbDSLop.TabIndex = 3;
            this.lsbDSLop.SelectedIndexChanged += new System.EventHandler(this.lsbDSLop_SelectedIndexChanged);
            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaSV, this.colTenSV, this.colGioiTinh, this.colNgaySinh, this.colQueQuan, this.colMaLop});
            this.lsvSinhVien.HideSelection = false;
            this.lsvSinhVien.Location = new System.Drawing.Point(220, 70);
            this.lsvSinhVien.Name = "lsvSinhVien";
            this.lsvSinhVien.Size = new System.Drawing.Size(552, 334);
            this.lsvSinhVien.TabIndex = 4;
            this.lsvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // Columns
            // 
            this.colMaSV.Text = "Mã SV"; this.colMaSV.Width = 90;
            this.colTenSV.Text = "Tên sinh viên"; this.colTenSV.Width = 160;
            this.colGioiTinh.Text = "Giới tính"; this.colGioiTinh.Width = 80;
            this.colNgaySinh.Text = "Ngày sinh"; this.colNgaySinh.Width = 100;
            this.colQueQuan.Text = "Quê quán"; this.colQueQuan.Width = 120;
            this.colMaLop.Text = "Mã lớp"; this.colMaLop.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.lsvSinhVien);
            this.Controls.Add(this.lsbDSLop);
            this.Controls.Add(this.lblDSSV);
            this.Controls.Add(this.lblDSLop);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
