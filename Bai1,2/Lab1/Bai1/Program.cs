using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== MENU THỰC HÀNH 1–11 =====");
                Console.WriteLine("1. TH1: Tính chu vi & diện tích HCN");
                Console.WriteLine("2. TH2: Tìm số lớn nhất trong 3 số nguyên");
                Console.WriteLine("3. TH3: Xếp loại điểm");
                Console.WriteLine("4. TH4: Tháng có bao nhiêu ngày?");
                Console.WriteLine("5. TH5: Kiểm tra chẵn/lẻ và âm/không âm");
                Console.WriteLine("6. TH6: Chu vi & diện tích HCN (nhập số dương)");
                Console.WriteLine("7. TH7: Kiểm tra tam giác + chu vi & diện tích");
                Console.WriteLine("8. TH8: Giải phương trình bậc 2");
                Console.WriteLine("9. TH9: Tính tổng các phần tử trong mảng");
                Console.WriteLine("10. TH10: Sắp xếp mảng (Selection Sort, file input_array.txt)");
                Console.WriteLine("11. TH11: Chèn số vào mảng tăng dần");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": TH1(); break;
                    case "2": TH2(); break;
                    case "3": TH3(); break;
                    case "4": TH4(); break;
                    case "5": TH5(); break;
                    case "6": TH6(); break;
                    case "7": TH7(); break;
                    case "8": TH8(); break;
                    case "9": TH9(); break;
                    case "10": TH10(); break;
                    case "11": TH11(); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
        }

        // TH1: Chu vi & diện tích HCN
        static void TH1()
        {
            Console.Write("Nhập chiều dài: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double P = (a + b) * 2;
            double S = a * b;

            Console.WriteLine($"Chu vi: {P}, Diện tích: {S}");
        }

        // TH2: Tìm max 3 số nguyên
        static void TH2()
        {
            Console.Write("Nhập a: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập c: "); int c = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine("Số lớn nhất là: " + max);
        }

        // TH3: Xếp loại điểm
        static void TH3()
        {
            Console.Write("Nhập điểm (0–10): ");
            double diem = Convert.ToDouble(Console.ReadLine());

            if (diem > 10 || diem < 0)
                Console.WriteLine("Điểm không hợp lệ!");
            else if (diem >= 9) Console.WriteLine("Xuất sắc!");
            else if (diem >= 8) Console.WriteLine("Giỏi!");
            else if (diem >= 6.5) Console.WriteLine("Khá!");
            else if (diem >= 5) Console.WriteLine("Trung bình!");
            else if (diem >= 3.5) Console.WriteLine("Yếu!");
            else Console.WriteLine("Kém!");
        }

        // TH4: Tháng có bao nhiêu ngày
        static void TH4()
        {
            Console.Write("Nhập năm: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            int thang = Convert.ToInt32(Console.ReadLine());

            int soNgay = DateTime.DaysInMonth(nam, thang);
            Console.WriteLine($"Tháng {thang}/{nam} có {soNgay} ngày.");
        }

        // TH5: chẵn/lẻ và âm/không âm
        static void TH5()
        {
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n % 2 == 0 ? "n là số chẵn" : "n là số lẻ");
            Console.WriteLine(n < 0 ? "n là số âm" : "n là số không âm");
        }

        // TH6: HCN với kiểm tra dương
        static void TH6()
        {
            Console.Write("Nhập chiều dài: ");
            double dai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            double rong = Convert.ToDouble(Console.ReadLine());

            if (dai <= 0 || rong <= 0)
            {
                Console.WriteLine("Cạnh phải > 0!");
                return;
            }

            Console.WriteLine($"Chu vi: {(dai + rong) * 2}, Diện tích: {dai * rong}");
        }

        // TH7: Tam giác
        static void TH7()
        {
            Console.Write("Nhập a: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập b: "); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập c: "); double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double P = a + b + c;
                double p = P / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Chu vi: {P}, Diện tích: {S:F2}");
            }
            else
            {
                Console.WriteLine("Không phải tam giác!");
            }
        }

        // TH8: PT bậc 2
        static void TH8()
        {
            Console.Write("Nhập a: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập b: "); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập c: "); double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Vô số nghiệm" : "Vô nghiệm");
                else
                    Console.WriteLine($"Nghiệm: x = {-c / b}");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0) Console.WriteLine("Vô nghiệm");
                else if (delta == 0) Console.WriteLine($"Nghiệm kép: x = {-b / (2 * a)}");
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                }
            }
        }

        // TH9: Tính tổng mảng
        static void TH9()
        {
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                tong += arr[i];
            }
            Console.WriteLine("Tổng = " + tong);
        }

        // TH10: Selection Sort từ file
        static void TH10()
        {
            string filePath = "input_array.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Không tìm thấy file input_array.txt!");
                return;
            }

            string content = File.ReadAllText(filePath);
            int[] arr = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[minIndex]) minIndex = j;

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(" ", arr));
        }

        // TH11: Chèn số vào mảng tăng dần
        static void TH11()
        {
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Mảng ban đầu: " + string.Join(" ", arr));

            Console.Write("Nhập số cần chèn: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int pos = 0;
            while (pos < arr.Length && arr[pos] < x) pos++;

            List<int> list = arr.ToList();
            list.Insert(pos, x);

            Console.WriteLine("Mảng sau khi chèn: " + string.Join(" ", list));
        }
    }

}