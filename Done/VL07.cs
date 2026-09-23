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
        int n = int.Parse(parts[0]);
        int k = int.Parse(parts[1]);

        long ans = 0;
        // neu dung theo cach duoi day thi 25! rat co the bi tran so, nen dung cach tinh toan theo cong thuc toan hoc

        // long ngt = 1;
        // long kgt = 1;
        // long nkgt = 1;
        // for (int i = 1; i <= n; i++)
        // {
        //     ngt *= i;
        //     if (i <= k)
        //     {
        //         kgt *= i;
        //     }
        //     if (i <= n - k)
        //     {
        //         nkgt *= i;
        //     }
        // }
        // ans = ngt / (kgt * nkgt);
        // writer.Write(ans);

        // cach tinh toan theo cong thuc toan hoc
        if (k > n - k) k = n - k; // Tối ưu: C(n, k) = C(n, n-k) ; C(n, k) = n! / (k! * (n-k)!) = n * (n-1) * ... * (n-k+1) / k! ; Eg. C(10, 8) = C(10, 2) = 10!/(2!*8!) =  10 * 9 / 2! = 45
        long numerator = 1; // Tử số
        long denominator = 1; // Mẫu số
        for (int i = 1; i <= k; i++)
        {
            numerator *= (n - i + 1); // Tính tử số: n * (n-1) * ... * (n-k+1)
            denominator *= i; // Tính mẫu số: k!
        }
        ans = numerator / denominator;
        writer.Write(ans);
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