using codewars.katas;
using NUnit.Framework;
using Shouldly;

namespace codewars.tests;

public class SquareEveryDigitTests
{
    [TestCase(0, 0)]
    [TestCase(9119, 811181)]
    [TestCase(765, 493625)]
    public void SquareDigitsTest(int value, int expected)
    {
        SquareEveryDigit.SquareDigits(value).ShouldBe(expected);
    }
}
