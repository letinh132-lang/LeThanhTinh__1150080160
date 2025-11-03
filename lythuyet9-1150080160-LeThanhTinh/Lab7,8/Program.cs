using System;
using System.Windows.Forms;
using QuanLyBanSachLab7; // đổi theo namespace bạn chọn

namespace QuanLyBanSachLab7
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
