using NUnit.Framework;

using Shouldly;

namespace codewars;

public class WhichAreInTests
{

    [TestCaseSource(nameof(WhichAreInTestData))]
    public void ReturnsStringsThatAreSubstringsOfSecondArray(string[] a1, string[] a2, string[] r)
    {
        WhichAreIn.inArray(a1, a2).ShouldBe(r);
    }

    public static IEnumerable<TestCaseData> WhichAreInTestData =>
        new[]
        {
            new TestCaseData(
                new string[] { "arp", "live", "strong" }, 
                new string[] { "lively", "alive", "harp", "sharp", "armstrong" }, 
                new string[] { "arp", "live", "strong" }
            ),
            new TestCaseData(
                new string[] { "tarp", "mice", "bull" },
                new string[] { "lively", "alive", "harp", "sharp", "armstrong" },
                new string[] { }
            ),
        };
}