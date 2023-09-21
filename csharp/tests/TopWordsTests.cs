using NUnit.Framework;

using Shouldly;

namespace codewars;

public class TopWordsTests
{
    [TestCaseSource(nameof(TestCases))]
    public void SampleTests(List<string> expected, string words)
    {
        TopWords.Top3(words).ShouldBe(expected);
    }

    public static IEnumerable<TestCaseData> TestCases => new[]
    {
        new TestCaseData(new List<string> { "e", "d", "a" }, "a a a  b  c c  d d d d  e e e e e"),
        new TestCaseData(new List<string> { "e", "ddd", "aa" }, "e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"),
        new TestCaseData(new List<string> { "won't", "wont" }, "  //wont won't won't "),
        new TestCaseData(new List<string> { "e" }, "  , e   .. "),
        new TestCaseData(new List<string> { }, "  ...  "),
        new TestCaseData(new List<string> { }, "  '  "),
        new TestCaseData(new List<string> { }, "  '''  "),
        new TestCaseData(new List<string> { "a", "of", "on" }, 
            string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                  "mind, there lived not long since one of those gentlemen that keep a lance",
                  "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                  "coursing. An olla of rather more beef than mutton, a salad on most",
                  "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                  "on Sundays, made away with three-quarters of his income." }))
    };
}