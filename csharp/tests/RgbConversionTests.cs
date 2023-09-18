using NUnit.Framework;

using Shouldly;

namespace codewars;

public class RgbConversionTests
{
    [TestCase(255, 255, 255, "FFFFFF")]
    [TestCase(255, 255, 300, "FFFFFF")]
    [TestCase(0, 0, 0, "000000")]
    [TestCase(148, 0, 211, "9400D3")]
    [TestCase(148, -10, 211, "9400D3")]
    public void CanConvertToRgb(int r, int g, int b, string expected)
    {
        RgbConversion.Rgb(r, g, b).ShouldBe(expected);
    }
}

