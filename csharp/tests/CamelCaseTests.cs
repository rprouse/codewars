using NUnit.Framework;

using Shouldly;

namespace codewars;

public class CamelCaseTests
{
    [TestCase("the_stealth_warrior", "theStealthWarrior")]
    [TestCase("The-Stealth_Warrior", "TheStealthWarrior")]
    [TestCase("The-Stealth-Warrior", "TheStealthWarrior")]
    public void ConvertToCamelCase(string input, string expected)
    {
        CamelCase.ToCamelCase(input).ShouldBe(expected);
    }
}
