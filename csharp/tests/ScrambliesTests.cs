using NUnit.Framework;

using Shouldly;

namespace codewars;

public static class ScrambliesTests
{
    [TestCase("rkqodlw", "world", true)]
    [TestCase("cedewaraaossoqqyt", "codewars", true)]
    [TestCase("katas", "steak", false)]
    [TestCase("scriptjavx", "javascript", false)]
    [TestCase("scriptingjava", "javascript", true)]
    [TestCase("scriptsjava", "javascripts", true)]
    [TestCase("javscripts", "javascript", false)]
    [TestCase("aabbcamaomsccdd", "commas", true)]
    [TestCase("commas", "commas", true)]
    [TestCase("sammoc", "commas", true)]
    public static void CanFindScrambledWord(string str1, string str2, bool expected)
    {
        Scramblies.Scramble(str1, str2).ShouldBe(expected);
    }
}
