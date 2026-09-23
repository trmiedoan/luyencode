using System;
using System.IO;

namespace LuyenCodeProject
{
    public class VL04
    {
        public static void Main()
        {


            // Tự động chuyển hướng file khi chạy Local, khi nộp OJ sẽ tự bỏ qua
#if DEBUG
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
                Console.WriteLine("Reading from input.txt");
            }

#endif
            FastScanner scanner = new FastScanner();
            int T = 1;
            // Test hàng loạt (local)
            T = scanner.NextInt(); // Đọc số lượng test cases (commnent dòng này khi nộp lên Online Judge)

            while (T-- > 0)
            {
                Solve(scanner);
            }




        }

        static void Solve(FastScanner scanner)
        {
            // Đọc dữ liệu đầu vào
            int n = scanner.NextInt();


            // Thực hiện xử lý và in kết quả
            // Console.WriteLine($"Read n: {n}");

            double ans = 0.5;
            for (int i = 3; i <= n; i++)
            {
                ans += 1.0 / i;

            }
            Console.WriteLine($"{ans:F4}");
        }

        // Lớp hỗ trợ đọc dữ liệu tốc độ cao (Fast I/O)
        public class FastScanner
        {
            // Đổi từ StreamReader sang TextReader để tương thích hoàn hảo với Console.In
            private readonly TextReader _reader;
            private readonly char[] _buffer = new char[32768];
            private int _head, _tail;

            public FastScanner()
            {
                // Gán thẳng bằng Console.In.
                // Nếu bạn dùng Console.SetIn(file) ở trên, nó sẽ tự động đọc file.
                // Khi nộp lên LeetCode, Console.In chính là luồng nhận dữ liệu của hệ thống chấm bài.
                _reader = Console.In;
            }

            private char ReadChar()
            {
                if (_head >= _tail)
                {
                    _head = 0;
                    _tail = _reader.Read(_buffer, 0, _buffer.Length);
                    if (_tail <= 0) return '\0';
                }
                return _buffer[_head++];
            }

            // 1. Đọc một chuỗi/từ (bỏ qua khoảng trắng)
            public string NextToken()
            {
                char c;
                while ((c = ReadChar()) <= ' ' && c != '\0') ;
                if (c == '\0') return null;

                var sb = new System.Text.StringBuilder();
                do { sb.Append(c); } while ((c = ReadChar()) > ' ');
                return sb.ToString();
            }

            // 2. Đọc số nguyên 32-bit
            public int NextInt()
            {
                char c;
                while ((c = ReadChar()) <= ' ' && c != '\0') ;
                if (c == '\0') return 0;

                bool neg = false;
                if (c == '-') { neg = true; c = ReadChar(); }

                int res = 0;
                do { res = res * 10 + (c - '0'); } while ((c = ReadChar()) > ' ');
                return neg ? -res : res;
            }

            // 3. Đọc số nguyên 64-bit (LONG)
            public long NextLong()
            {
                char c;
                while ((c = ReadChar()) <= ' ' && c != '\0') ;
                if (c == '\0') return 0;

                bool neg = false;
                if (c == '-') { neg = true; c = ReadChar(); }

                long res = 0;
                do { res = res * 10 + (c - '0'); } while ((c = ReadChar()) > ' ');
                return neg ? -res : res;
            }

            // 4. Đọc số thực (Double) - Dùng ép kiểu từ chuỗi
            public double NextDouble()
            {
                string token = NextToken();
                return token == null ? 0 : double.Parse(token, System.Globalization.CultureInfo.InvariantCulture);
            }
        }
    }
}