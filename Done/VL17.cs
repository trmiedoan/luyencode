using System;
using System.IO;

/// <summary>
/// dem so UOC DUONG cua mot so nguyen a khac 0
/// gioi han input: |a| < 1000, a!= 0
/// </summary>


public class Solution
{
    // Hàm xử lý chính: Nhận vào luồng đọc và luồng ghi
    public void Solve(TextReader reader, TextWriter writer)
    {
        // Đọc dữ liệu đầu vào
        int n = int.Parse(reader.ReadLine());

        // Xử lý logic bài toán và ghi kết quả ra luồng writer
        int count = 0;
        for (int i = 1; i <= Math.Abs(n); i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        writer.Write(count);
        // Complexity: O(sqrt(n)) or O(n) depending on the implementation. In this case, it's O(n) since we are iterating from 1 to |n|.
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