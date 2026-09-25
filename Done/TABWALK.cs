using System;
using System.IO;

public class Solution
{
    // Hàm xử lý chính: Nhận vào luồng đọc và luồng ghi
    public void Solve(TextReader reader, TextWriter writer)
    {
        // Đọc dữ liệu đầu vào
        long n = long.Parse(reader.ReadLine());
        if (n <= 1)
        {
            writer.Write("0");
            return;
        }

        // tim cap uoc co tong nho nhat cua mot so n
        for (long i = (long)Math.Sqrt(n); i >= 1; i--)
        {
            if (n % i == 0)
            {
                long a = i;
                long b = n / i;
                writer.Write($"{a + b - 2}");
                return;
            }
        }

    }

    // Hàm Main này CHỈ chạy trên Online Judge (Chế độ Release)
#if !DEBUG
    public static void Main(string[] args)
    {
        Solution solver = new Solution();
        // Khi nộp lên OJ, truyền Console.In (bàn phím) và Console.Out (màn hình) vào
        solver.Solve(Console.In, Console.Out);
    }
#endif
}