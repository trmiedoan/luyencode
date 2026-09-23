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

        long[] arr = Array.ConvertAll(input.Split(' '), long.Parse);

        long sum = 0;
        int oddCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            // Kiểm tra số lẻ và tính tổng (lưu ý: số âm cũng có thể là số lẻ nhưng nếu dùng % 2 == 1 sẽ không đúng vì (-3)%2 = -1 , nên dùng Math.Abs(arr[i]) % 2 == 1)
            if (Math.Abs(arr[i]) % 2 == 1)
            {
                sum += arr[i];
                oddCount++;
            }
        }
        writer.WriteLine($"{(sum / (double)oddCount):F4}");
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