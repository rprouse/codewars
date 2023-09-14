using NUnit.Framework;

using Shouldly;

namespace codewars;

public class BinaryAddtionTests
{
    [TestCase(1, 2, "11")]
    [TestCase(5, 9, "1110")]
    [TestCase(10, 10, "10100")]
    [TestCase(0, 0, "0")]
    [TestCase(0, 1, "1")]
    [TestCase(1, 0, "1")]
    public void AddBinary(int a, int b, string expected)
    {
        BinaryAddtion.AddBinary(a, b).ShouldBe(expected);
    }
}
