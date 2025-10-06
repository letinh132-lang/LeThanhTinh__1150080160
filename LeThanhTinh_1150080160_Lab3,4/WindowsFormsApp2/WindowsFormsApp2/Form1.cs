using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantOrderPDA
{
    public partial class Form1 : Form
    {
        // Lưu tạm thời order hiện tại: Tên món -> Số lượng
        private readonly Dictionary<string, int> _currentOrder = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

        public Form1()
        {
            InitializeComponent();
            InitTables();
            WireItemButtons();
            InitGrid();
        }

        private void InitTables()
        {
            // Ví dụ 10 bàn
            cboTable.Items.AddRange(Enumerable.Range(1, 10).Select(i => $"Bàn {i:00}").ToArray());
            cboTable.SelectedIndex = 0;
        }

        private void WireItemButtons()
        {
            // Gắn 1 handler chung cho toàn bộ button món (đã đặt Tag = tên món ở Designer)
            foreach (Control c in flpMenu.Controls)
            {
                if (c is Button btn && btn.Tag is string)
                    btn.Click += BtnItem_Click;
            }
        }

        private void InitGrid()
        {
            dgvOrder.AutoGenerateColumns = false;
            dgvOrder.Columns.Clear();

            var colName = new DataGridViewTextBoxColumn
            {
                HeaderText = "Món",
                DataPropertyName = "Name",
                Name = "colName",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            var colQty = new DataGridViewTextBoxColumn
            {
                HeaderText = "Số lượng",
                DataPropertyName = "Quantity",
                Name = "colQty",
                Width = 90,
                ReadOnly = true
            };

            dgvOrder.Columns.Add(colName);
            dgvOrder.Columns.Add(colQty);

            RefreshGrid();
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is string itemName)
            {
                if (_currentOrder.ContainsKey(itemName))
                    _currentOrder[itemName]++;
                else
                    _currentOrder[itemName] = 1;

                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            var data = _currentOrder
                .OrderBy(kv => kv.Key)
                .Select(kv => new RowItem { Name = kv.Key, Quantity = kv.Value })
                .ToList();

            dgvOrder.DataSource = data;
            lblTotalItems.Text = $"Tổng món: {_currentOrder.Values.Sum()}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _currentOrder.Clear();
            RefreshGrid();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (_currentOrder.Count == 0)
            {
                MessageBox.Show("Chưa có món nào trong danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboTable.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn bàn trước khi Order!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var table = cboTable.SelectedItem.ToString();
            var ts = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var folder = Path.Combine(Application.StartupPath, "Orders");
            Directory.CreateDirectory(folder);

            var filePath = Path.Combine(folder, $"{table}_{ts}.txt");

            using (var sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("=== ORDER QUÁN ĂN NHANH ===");
                sw.WriteLine($"Bàn: {table}");
                sw.WriteLine($"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                sw.WriteLine(new string('-', 32));
                foreach (var kv in _currentOrder.OrderBy(kv => kv.Key))
                {
                    sw.WriteLine($"{kv.Key} - SL: {kv.Value}");
                }
                sw.WriteLine(new string('-', 32));
                sw.WriteLine($"Tổng món: {_currentOrder.Values.Sum()}");
            }

            MessageBox.Show($"Đã ghi Order vào:\n{filePath}", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sau khi gửi xuống “bếp” thì dọn phiếu
            _currentOrder.Clear();
            RefreshGrid();
        }

        // Model hiển thị cho DataGridView
        private class RowItem
        {
            public string Name { get; set; } = "";
            public int Quantity { get; set; }
        }
    }
}
