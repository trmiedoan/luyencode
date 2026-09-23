# Introduce this folder

- Folder này chuyên để chứa các bài để chạy trên các online judge như leetcode, luyencode,...

# How it works?

## Nếu dùng Unit test

- Viết bài giải cho các bài như `Bai1.cs` = cách copy `templete.cs` (nhớ là class trong file không cần trùng tên file nên cứ để nguyên là class Solution thôi nhé)
- viết các test case vào file `SolutionTest.cs` và chạy file test này (chứ không phải chạy file solution nhé)
  - Chú ý ở file test là mình có phân biệt định dạng đầu ra là chuỗi nên trong lời giải khi in thì phải in ra chuỗi nhé.

## Nếu không dùng unit test mà dùng file input để nhập các test thì

- Input để test thì bỏ vào file input.
- Bài nào đang làm, đang test thì sẽ ở trong folder này (chứa file `./LuyenCodeProject.csproj`). (folder này chỉ nên chứa 1 hàm main duy nhất). Khi nào chạy thì chạy lệnh dotnet run là oke
- Các bài khác thì phân chia vào các folder khác như `../Done` hoặc `../Thinking`

Khi nộp lên các online judge:

- Chỉ nộp file bài làm như kiêu `Bai1.cs` (không cần nộp thêm các file khác)
  Khi chạy test thì nên để theo dạng

```txt
4 <số lượng test case>
1 2 3 4
2 5 6 7
3 8 9 10
4 11 12 13
```
