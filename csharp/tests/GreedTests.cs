using System.Collections.Generic;

using NUnit.Framework;

using Shouldly;

namespace codewars;

public class GreedTests
{
    [TestCaseSource(nameof(GreedScores))]
    public void CanScore(int[] dice, int score)
    {
        Greed.Score(dice).ShouldBe(score);
    }

    public static IEnumerable<TestCaseData> GreedScores => new [] 
    {
        new TestCaseData(new int[] { 2, 3, 4, 6, 2 }, 0),
        new TestCaseData(new int[] { 4, 4, 4, 3, 3 }, 400),
        new TestCaseData(new int[] { 2, 4, 4, 5, 4 }, 450),
        new TestCaseData(new int[] { 5, 1, 3, 4, 1 }, 250),
        new TestCaseData(new int[] { 1, 1, 1, 3, 1 }, 1100),
        new TestCaseData(new int[] { 1, 1, 1, 1, 1 }, 1200),
        new TestCaseData(new int[] { 5, 5, 5, 5, 4 }, 550),
        new TestCaseData(new int[] { 5, 5, 5, 5, 5 }, 600),
    };
}