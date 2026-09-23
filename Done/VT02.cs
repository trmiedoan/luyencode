using System;
using System.IO;
using System.Linq;

public class Solution
{
    // Hàm xử lý chính: Nhận vào luồng đọc và luồng ghi
    public void Solve(TextReader reader, TextWriter writer)
    {
        // Đọc dữ liệu đầu vào
        int n = int.Parse(reader.ReadLine());

        string input = reader.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        long[] arr = Array.ConvertAll(input.Split(' '), long.Parse);

        long max = arr.Max(); // Tìm giá trị lớn nhất trong mảng → do phuc tap O(n)
        long max2 = long.MinValue; // Khởi tạo giá trị lớn thứ hai là giá trị nhỏ nhất có thể

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < max && arr[i] > max2)
            {
                max2 = arr[i]; // Cập nhật giá trị lớn thứ hai nếu tìm thấy
            }
        }

        if (max2 == long.MinValue)
        {
            writer.Write("NOT FOUND");
        }
        else
        {
            writer.Write(max2);
        }

        // do phuc tap tong the la O(n) + O(n) = O(n)
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