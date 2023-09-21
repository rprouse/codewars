using System.Collections.Generic;

using NUnit.Framework;

using Shouldly;

namespace codewars;

public class SumDigPowerTests
{
    [TestCaseSource(nameof(SumDigPowerTestData))]
    public void CanFindSumDigPowers(long a, long b, long[] res)
    {
        SumDigPower.SumDigPow(a, b).ShouldBe(res);
    }

    public static IEnumerable<TestCaseData> SumDigPowerTestData => new[]
    {
        new TestCaseData(1, 10, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
        new TestCaseData(1, 100, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 }),
        new TestCaseData(10, 100, new long[] { 89 }),
        new TestCaseData(90, 100, new long[] { }),
        new TestCaseData(90, 150, new long[] { 135 }),
        new TestCaseData(50, 150, new long[] { 89, 135 }),
        new TestCaseData(10, 150, new long[] { 89, 135 })
    };
}
