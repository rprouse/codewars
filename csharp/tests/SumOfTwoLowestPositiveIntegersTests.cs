using NUnit.Framework;
using Shouldly;

namespace codewars;

public class SumOfTwoLowestPositiveIntegersTests
{
    [Test]
    public void Test1()
    {
        int[] numbers = { 5, 8, 12, 19, 22 };
        SumOfTwoLowestPositiveIntegers.sumTwoSmallestNumbers(numbers).ShouldBe(13);
    }
    [Test]
    public void Test2()
    {
        int[] numbers = { 19, 5, 42, 2, 77 };
        SumOfTwoLowestPositiveIntegers.sumTwoSmallestNumbers(numbers).ShouldBe(7);
    }

    [Test]
    public void Test3()
    {
        int[] numbers = { 10, 343445353, 3453445, 2147483647 };
        SumOfTwoLowestPositiveIntegers.sumTwoSmallestNumbers(numbers).ShouldBe(3453455);
    }
}
