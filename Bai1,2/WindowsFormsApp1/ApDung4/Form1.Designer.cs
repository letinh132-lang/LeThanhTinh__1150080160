using System.Drawing;
using System.Windows.Forms;

namespace ApDung4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstNguon;
        private System.Windows.Forms.ListBox lstDaChon;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstNguon = new System.Windows.Forms.ListBox();
            this.lstDaChon = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(20, 15);
            this.lblLeft.Text = "Danh sách các mặt hàng";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(400, 15);
            this.lblRight.Text = "Các mặt hàng lựa chọn";
            // 
            // lstNguon
            // 
            this.lstNguon.Location = new System.Drawing.Point(20, 40);
            this.lstNguon.Size = new System.Drawing.Size(260, 200);
            this.lstNguon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstNguon.Items.AddRange(new object[] {
                "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN"});
            // 
            // lstDaChon
            // 
            this.lstDaChon.Location = new System.Drawing.Point(360, 40);
            this.lstDaChon.Size = new System.Drawing.Size(260, 200);
            this.lstDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // btnRight
            // 
            this.btnRight.Text = ">";
            this.btnRight.Location = new System.Drawing.Point(300, 70);
            this.btnRight.Size = new System.Drawing.Size(40, 28);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Text = ">>";
            this.btnRightAll.Location = new System.Drawing.Point(300, 110);
            this.btnRightAll.Size = new System.Drawing.Size(40, 28);
            // 
            // btnLeft
            // 
            this.btnLeft.Text = "<";
            this.btnLeft.Location = new System.Drawing.Point(300, 150);
            this.btnLeft.Size = new System.Drawing.Size(40, 28);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.Location = new System.Drawing.Point(300, 190);
            this.btnLeftAll.Size = new System.Drawing.Size(40, 28);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 270);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lstNguon);
            this.Controls.Add(this.lstDaChon);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnLeftAll);
            this.Text = "Bài tập 7";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
