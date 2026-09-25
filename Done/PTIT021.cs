using System;
using System.IO;

public class Solution
{
    // Hàm xử lý chính: Nhận vào luồng đọc và luồng ghi
    public void Solve(TextReader reader, TextWriter writer)
    {
        // Đọc dữ liệu đầu vào
        int n = int.Parse(reader.ReadLine());
        string input = reader.ReadLine();
        if (string.IsNullOrEmpty(input)) return;
        int min = int.MaxValue;
        int max = int.MinValue;

        int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }


        // Xử lý logic bài toán và ghi kết quả ra luồng writer
        writer.Write($"{max - min + 1 - n}"); // phần tử max - min + 1 - n = số lượng phần tử còn thiếu

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