using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SolutionTests
{
    [TestMethod]
    public void Test1()
    {
        // Arrange: Giả lập dữ liệu nhập từ bàn phím
        var input = new StringReader("2 4");
        var output = new StringWriter();
        var solver = new Solution();

        // Act: Chạy hàm giải thuật
        solver.Solve(input, output);

        // Assert: Kiểm tra kết quả in ra màn hình có đúng như kỳ vọng không
        string expected = "6";
        string actual = output.ToString().Trim(); // Trim để bỏ khoảng trắng thừa ở cuối nếu có

        Assert.AreEqual(expected, actual, "Kết quả in ra bị sai!");
    }

    [TestMethod]
    public void Test2()
    {
        var input = new StringReader("-1 4");
        var output = new StringWriter();
        var solver = new Solution();

        solver.Solve(input, output);

        Assert.AreEqual("6", output.ToString().Trim());
    }
    [TestMethod]
    public void Test3()
    {
        var input = new StringReader("-2 4");
        var output = new StringWriter();
        var solver = new Solution();

        solver.Solve(input, output);

        Assert.AreEqual("4", output.ToString().Trim());
    }
}
