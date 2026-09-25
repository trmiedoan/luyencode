using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SolutionTests
{
    [TestMethod]
    public void Test1()
    {
        // Arrange: Giả lập dữ liệu nhập từ bàn phím
        var input = @"4
10 13 12 8";
        string expected = @"2";
        var output = new StringWriter();
        var solver = new Solution();

        // Act: Chạy hàm giải thuật
        solver.Solve(new StringReader(input), output);

        // Assert: Kiểm tra kết quả in ra màn hình có đúng như kỳ vọng không
        // string expected = "1";
        string actual = output.ToString().Trim(); // Trim để bỏ khoảng trắng thừa ở cuối nếu có

        Assert.AreEqual(expected, actual, "Kết quả in ra bị sai!");
    }

    [TestMethod]
    public void Test2()
    {
        var input = @"3 5";
        string expected = "10";
        var output = new StringWriter();
        var solver = new Solution();

        solver.Solve(new StringReader(input), output);

        Assert.AreEqual(expected, output.ToString().Trim(), "Kết quả in ra bị sai!");
    }

    [TestMethod]
    public void Test3()
    {
        var input = @"4
-2 -2 -3 2";
        string expected = "-2";
        var output = new StringWriter();
        var solver = new Solution();

        solver.Solve(new StringReader(input), output);

        Assert.AreEqual(expected, output.ToString().Trim(), "Kết quả in ra bị sai!");
    }

}
