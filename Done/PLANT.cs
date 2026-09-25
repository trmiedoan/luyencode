using System;
using System.IO;

public class Solution
{
    // Hàm xử lý chính: Nhận vào luồng đọc và luồng ghi
    public void Solve(TextReader reader, TextWriter writer)
    {
        int[] arr = new int[61];
        arr[0] = 1;
        for (int i = 1; i <= 60; i++)
        {
            if (i % 2 != 0)
            {
                arr[i] = arr[i - 1] * 2;
            }
            else
            {
                arr[i] = arr[i - 1] + 1;
            }
        }
        // Đọc dữ liệu đầu vào
        int t = int.Parse(reader.ReadLine());
        for (int i = 0; i < t; i++)
        {
            long n = long.Parse(reader.ReadLine());

            writer.WriteLine($"{arr[n]}");
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