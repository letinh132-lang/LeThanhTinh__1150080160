using System;
using System.Linq;
using System.Windows.Forms;

namespace ApDung4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện nút
            btnRight.Click += btnRight_Click;
            btnRightAll.Click += btnRightAll_Click;
            btnLeft.Click += btnLeft_Click;
            btnLeftAll.Click += btnLeftAll_Click;

            // Cho phép double-click để chuyển nhanh
            lstNguon.DoubleClick += (s, e) => btnRight.PerformClick();
            lstDaChon.DoubleClick += (s, e) => btnLeft.PerformClick();
        }

        // Chuyển các mục đang chọn từ source sang target
        private void MoveSelected(ListBox source, ListBox target)
        {
            if (source.SelectedItems.Count == 0) return;

            // Lấy danh sách item được chọn (copy vì SelectedItems là view)
            var items = source.SelectedItems.Cast<object>().ToList();
            foreach (var it in items) target.Items.Add(it);

            // Xóa ở source theo thứ tự ngược để không lệch index
            for (int i = source.SelectedIndices.Count - 1; i >= 0; i--)
            {
                source.Items.RemoveAt(source.SelectedIndices[i]);
            }
        }

        // Chuyển tất cả từ source sang target
        private void MoveAll(ListBox source, ListBox target)
        {
            if (source.Items.Count == 0) return;
            target.Items.AddRange(source.Items.Cast<object>().ToArray());
            source.Items.Clear();
        }

        private void btnRight_Click(object sender, EventArgs e) => MoveSelected(lstNguon, lstDaChon);
        private void btnRightAll_Click(object sender, EventArgs e) => MoveAll(lstNguon, lstDaChon);
        private void btnLeft_Click(object sender, EventArgs e) => MoveSelected(lstDaChon, lstNguon);
        private void btnLeftAll_Click(object sender, EventArgs e) => MoveAll(lstDaChon, lstNguon);
    }
}
