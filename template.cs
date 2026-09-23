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
        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);

        // Xử lý logic bài toán và ghi kết quả ra luồng writer
        int ans = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0) // Kiểm tra số chẵn
            {
                ans += i;
            }
        }
        writer.Write($"{ans}");
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
