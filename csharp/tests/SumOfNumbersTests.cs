using NUnit.Framework;

using Shouldly;

namespace codewars;

public class SumOfNumbersTests
{
    [TestCase(1, 0, 1)]
    [TestCase(1, 2, 3)]
    [TestCase(0, 1, 1)]
    [TestCase(1, 1, 1)]
    [TestCase(-1, 0, -1)]
    [TestCase(-1, 2, 2)]
    [TestCase(10, 10, 10)]
    public void CanSum(int a, int b, int expected)
    {
        var s = new SumOfNumbers();
        s.GetSum(a, b).ShouldBe(expected);
    }
}
