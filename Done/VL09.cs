using System;
using System.IO;

public class Solution
{
    // Hàm xử lý chính: Nhận vào luồng đọc và luồng ghi
    public void Solve(TextReader reader, TextWriter writer)
    {
        // Đọc dữ liệu đầu vào
        string input = reader.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        string[] parts = input.Split(' ');
        int x = int.Parse(parts[0]);
        int n = int.Parse(parts[1]);

        long gt = 1;
        double result = 0.0;

        // Xử lý logic bài toán và ghi kết quả ra luồng writer
        for (int i = 1; i <= n; i++)
        {
            gt *= i; // Tính giai thừa
            result += Math.Pow(x, i) / gt;
        }
        writer.WriteLine($"{result:F2}");
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