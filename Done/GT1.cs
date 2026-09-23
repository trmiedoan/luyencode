using System;
using System.IO;

public class Solution
{
    // Hàm xử lý chính: Nhận vào luồng đọc và luồng ghi
    public void Solve(TextReader reader, TextWriter writer)
    {
        // Đọc dữ liệu đầu vào
        int n = int.Parse(reader.ReadLine());

        // Xử lý logic bài toán và ghi kết quả ra luồng writer
        if (n == 0) writer.Write("1"); // Nếu n = 0, in ra 1
        else
        {
            long ans = 1;
            for (int i = 1; i <= n; i++)
            {
                ans *= i; // Tính giai thừa
            }
            writer.Write(ans);
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