// power2
/*
a^n = ?
a is Long, n is Int
devide and conquer

Nếu n chẵn a^n = (a^{n/2})^2
Nếu n lẻ a^n = a.a^{n-1}


Nhưng mà nên triển khai theo vòng lặp để tránh dùng đệ quy. 


Baseknowledge:
- dấu n & 1 == 1  là đúng → n là lẻ
- dấu n>>=1  

*/

//-----------------------------------------
// Copyright (c-sharp) 2026
//-----------------------------------------
using System;

namespace Luyencode
{
    public class Power2
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] part = input.Split(' ');





        }

        long CalculatePower(long a, int n)
        {
            if (n == 0) return 1;

            long res = 1;

            return 0;

        }
    }
}