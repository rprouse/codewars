using System;

using NUnit.Framework;

using Shouldly;

namespace codewars;

public class HumanReadableTimeTests
{
    [TestCase(0, "00:00:00")]
    [TestCase(5, "00:00:05")]
    [TestCase(60, "00:01:00")]
    [TestCase(86399, "23:59:59")]
    [TestCase(359999, "99:59:59")]
    public void ShouldFormatCorrectly(int seconds, string expected)
    {
        HumanReadableTime.GetReadableTime(seconds).ShouldBe(expected);
    }

    [TestCase(-1)]
    [TestCase(360000)]
    public void ShouldThrowException(int seconds)
    {
        Should.Throw<ArgumentOutOfRangeException>(() => HumanReadableTime.GetReadableTime(seconds));
    }
}
