using NUnit.Framework;

using Shouldly;

namespace codewars;

public class SumOfOddNumbersTests
{
    [TestCase(1, 1)]
    [TestCase(2, 8)]
    [TestCase(3, 27)]
    [TestCase(4, 64)]
    [TestCase(5, 125)]
    [TestCase(42, 74088)]
    public void CanSum(int n, long expected)
    {
        SumOfOddNumbers.RowSumOddNumbers(n).ShouldBe(expected);
    }
}
