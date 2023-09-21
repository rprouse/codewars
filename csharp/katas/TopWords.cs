using System.Text.RegularExpressions;

namespace codewars;

public class TopWords
{
    static readonly Regex regex = new Regex(
      "([a-zA-Z']+)", RegexOptions.CultureInvariant | RegexOptions.Compiled
    );

    public static List<string> Top3(string s) =>
        regex.Matches(s.ToLowerInvariant())
            .Select(match => match.Value)
            .Where(str => !str.All(ch => ch == '\''))
            .GroupBy(word => word)
            .OrderByDescending(group => group.Count())
            .Select(group => group.Key)
            .Take(3)
            .ToList();
}