using System.Windows.Forms;
using System.Drawing;

namespace Lab06_QuanLyNhaXuatBan
{
    public partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblMaXB;
        private Label lblTenXB;
        private Label lblDiaChi;
        private TextBox txtMaXB;
        private TextBox txtTenXB;
        private TextBox txtDiaChi;
        private ListView lsvDanhSach;
        private Button btnThemDL;
        private Button btnSuaDL;
        private Button btnXoaDL;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaXB = new System.Windows.Forms.Label();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.btnThemDL = new System.Windows.Forms.Button();
            this.btnSuaDL = new System.Windows.Forms.Button();
            this.btnXoaDL = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaXB
            // 
            this.lblMaXB.AutoSize = true;
            this.lblMaXB.Location = new System.Drawing.Point(24, 24);
            this.lblMaXB.Name = "lblMaXB";
            this.lblMaXB.Size = new System.Drawing.Size(48, 16);
            this.lblMaXB.TabIndex = 0;
            this.lblMaXB.Text = "Mã XB:";
            // 
            // lblTenXB
            // 
            this.lblTenXB.AutoSize = true;
            this.lblTenXB.Location = new System.Drawing.Point(24, 60);
            this.lblTenXB.Name = "lblTenXB";
            this.lblTenXB.Size = new System.Drawing.Size(52, 16);
            this.lblTenXB.TabIndex = 1;
            this.lblTenXB.Text = "Tên XB:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(24, 96);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(54, 16);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(96, 21);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(270, 22);
            this.txtMaXB.TabIndex = 3;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(96, 57);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(270, 22);
            this.txtTenXB.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(96, 93);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(270, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(24, 140);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(688, 280);
            this.lsvDanhSach.TabIndex = 6;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.Columns.Add("Mã XB", 100);
            this.lsvDanhSach.Columns.Add("Tên XB", 240);
            this.lsvDanhSach.Columns.Add("Địa chỉ", 320);
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // btnThemDL
            // 
            this.btnThemDL.Location = new System.Drawing.Point(392, 20);
            this.btnThemDL.Name = "btnThemDL";
            this.btnThemDL.Size = new System.Drawing.Size(120, 28);
            this.btnThemDL.TabIndex = 7;
            this.btnThemDL.Text = "Thêm";
            this.btnThemDL.UseVisualStyleBackColor = true;
            this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);
            // 
            // btnSuaDL
            // 
            this.btnSuaDL.Location = new System.Drawing.Point(392, 56);
            this.btnSuaDL.Name = "btnSuaDL";
            this.btnSuaDL.Size = new System.Drawing.Size(120, 28);
            this.btnSuaDL.TabIndex = 8;
            this.btnSuaDL.Text = "Sửa";
            this.btnSuaDL.UseVisualStyleBackColor = true;
            this.btnSuaDL.Click += new System.EventHandler(this.btnSuaDL_Click);
            // 
            // btnXoaDL
            // 
            this.btnXoaDL.Location = new System.Drawing.Point(392, 92);
            this.btnXoaDL.Name = "btnXoaDL";
            this.btnXoaDL.Size = new System.Drawing.Size(120, 28);
            this.btnXoaDL.TabIndex = 9;
            this.btnXoaDL.Text = "Xóa";
            this.btnXoaDL.UseVisualStyleBackColor = true;
            this.btnXoaDL.Click += new System.EventHandler(this.btnXoaDL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(552, 20);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 28);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1 (form)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 460);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaDL);
            this.Controls.Add(this.btnSuaDL);
            this.Controls.Add(this.btnThemDL);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenXB);
            this.Controls.Add(this.lblMaXB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhà Xuất Bản - Lab 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
