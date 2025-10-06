namespace RestaurantOrderPDA
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblTotalItems;

        // Các button món (tạo sẵn như ảnh minh hoạ)
        private System.Windows.Forms.Button bComChienTrung;
        private System.Windows.Forms.Button bBanhMyOpla;
        private System.Windows.Forms.Button bCoca;
        private System.Windows.Forms.Button bLipton;
        private System.Windows.Forms.Button bOcRangMuoi;
        private System.Windows.Forms.Button bKhoaiTayChien;
        private System.Windows.Forms.Button b7up;
        private System.Windows.Forms.Button bCam;
        private System.Windows.Forms.Button bMyXaoHaiSan;
        private System.Windows.Forms.Button bCaVienChien;
        private System.Windows.Forms.Button bPepsi;
        private System.Windows.Forms.Button bCafe;
        private System.Windows.Forms.Button bBurgerBoNuong;
        private System.Windows.Forms.Button bDuiGaRan;
        private System.Windows.Forms.Button bBunBoHue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.bComChienTrung = new System.Windows.Forms.Button();
            this.bBanhMyOpla = new System.Windows.Forms.Button();
            this.bCoca = new System.Windows.Forms.Button();
            this.bLipton = new System.Windows.Forms.Button();
            this.bOcRangMuoi = new System.Windows.Forms.Button();
            this.bKhoaiTayChien = new System.Windows.Forms.Button();
            this.b7up = new System.Windows.Forms.Button();
            this.bCam = new System.Windows.Forms.Button();
            this.bMyXaoHaiSan = new System.Windows.Forms.Button();
            this.bCaVienChien = new System.Windows.Forms.Button();
            this.bPepsi = new System.Windows.Forms.Button();
            this.bCafe = new System.Windows.Forms.Button();
            this.bBurgerBoNuong = new System.Windows.Forms.Button();
            this.bDuiGaRan = new System.Windows.Forms.Button();
            this.bBunBoHue = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.ForestGreen;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // (Bạn có thể gán 1 ảnh burger 64x64 ở thời gian thiết kế nếu muốn)
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(100, 15, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(860, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quán ăn nhanh Hưng Thịnh";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.flpMenu);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 70);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxMenu.Size = new System.Drawing.Size(860, 170);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Danh sách món ăn:";
            // 
            // flpMenu
            // 
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.Location = new System.Drawing.Point(10, 26);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(6);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(6);
            this.flpMenu.Size = new System.Drawing.Size(840, 134);
            this.flpMenu.TabIndex = 0;
            this.flpMenu.WrapContents = true;

            // Style mặc định cho các button món
            System.Drawing.Size itemSize = new System.Drawing.Size(160, 36);

            // 
            // Tạo & thêm các button món
            // 
            this.bComChienTrung.Text = "Cơm chiên trứng"; this.bComChienTrung.Size = itemSize; this.bComChienTrung.Tag = "Cơm chiên trứng";
            this.bBanhMyOpla.Text = "Bánh mì ốp la"; this.bBanhMyOpla.Size = itemSize; this.bBanhMyOpla.Tag = "Bánh mì ốp la";
            this.bCoca.Text = "Coca"; this.bCoca.Size = itemSize; this.bCoca.Tag = "Coca";
            this.bLipton.Text = "Lipton"; this.bLipton.Size = itemSize; this.bLipton.Tag = "Lipton";
            this.bOcRangMuoi.Text = "Ốc rang muối"; this.bOcRangMuoi.Size = itemSize; this.bOcRangMuoi.Tag = "Ốc rang muối";
            this.bKhoaiTayChien.Text = "Khoai tây chiên"; this.bKhoaiTayChien.Size = itemSize; this.bKhoaiTayChien.Tag = "Khoai tây chiên";
            this.b7up.Text = "7 up"; this.b7up.Size = itemSize; this.b7up.Tag = "7 up";
            this.bCam.Text = "Cam"; this.bCam.Size = itemSize; this.bCam.Tag = "Cam";
            this.bMyXaoHaiSan.Text = "Mỳ xào hải sản"; this.bMyXaoHaiSan.Size = itemSize; this.bMyXaoHaiSan.Tag = "Mỳ xào hải sản";
            this.bCaVienChien.Text = "Cá viên chiên"; this.bCaVienChien.Size = itemSize; this.bCaVienChien.Tag = "Cá viên chiên";
            this.bPepsi.Text = "Pepsi"; this.bPepsi.Size = itemSize; this.bPepsi.Tag = "Pepsi";
            this.bCafe.Text = "Cafe"; this.bCafe.Size = itemSize; this.bCafe.Tag = "Cafe";
            this.bBurgerBoNuong.Text = "Burger bò nướng"; this.bBurgerBoNuong.Size = itemSize; this.bBurgerBoNuong.Tag = "Burger bò nướng";
            this.bDuiGaRan.Text = "Đùi gà rán"; this.bDuiGaRan.Size = itemSize; this.bDuiGaRan.Tag = "Đùi gà rán";
            this.bBunBoHue.Text = "Bún bò Huế"; this.bBunBoHue.Size = itemSize; this.bBunBoHue.Tag = "Bún bò Huế";

            this.flpMenu.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.bComChienTrung, this.bBanhMyOpla, this.bCoca, this.bLipton,
                this.bOcRangMuoi, this.bKhoaiTayChien, this.b7up, this.bCam,
                this.bMyXaoHaiSan, this.bCaVienChien, this.bPepsi, this.bCafe,
                this.bBurgerBoNuong, this.bDuiGaRan, this.bBunBoHue
            });

            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblTotalItems);
            this.panelBottom.Controls.Add(this.btnClear);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.cboTable);
            this.panelBottom.Controls.Add(this.btnOrder);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottom.Location = new System.Drawing.Point(0, 240);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.panelBottom.Size = new System.Drawing.Size(860, 46);
            this.panelBottom.TabIndex = 2;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(610, 15);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(83, 21);
            this.lblTotalItems.TabIndex = 4;
            this.lblTotalItems.Text = "Tổng món: 0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn bàn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTable
            // 
            this.cboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(200, 11);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(140, 29);
            this.cboTable.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Location = new System.Drawing.Point(760, 9);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(80, 30);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 286);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(860, 364);
            this.dgvOrder.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 650);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDA Order - Hưng Thịnh";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
