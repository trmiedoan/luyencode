///-----------------------------------------
// Copyright (c-sharp) 2026 - To run this file use the command: 'dotnet run -p:StartupObject=<namespace>.<the-class-name-has-Main-fuction(not the file name)>' in the terminal
//Eg. dotnet run -p:StartupObject=Practice.HocEvent

//-----------------------------------------
/*
    Problem: https://luyencode.net/problem/thpttd_114
 Hướng giải: tính giá tiền của 1 lít rượu, sau đó nhân với số lít rượu cần mua. (tham lam)
    Input: 5 số nguyên q, h, s, d, n (1 ≤ q, h, s, d ≤ 10^9; 1 ≤ n ≤ 10^9)
    Output: In ra giá tiền ít nhất để mua n lít rượu. (tính theo chai 2 lít , 1 lít, 0.5 lít, 0.25 lít)
*/


using System;
using System.IO;

namespace LuyenCodeProject
{
    public class THPTTD_114
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

            // Đọc dữ liệu cực nhanh và an toàn



        }
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