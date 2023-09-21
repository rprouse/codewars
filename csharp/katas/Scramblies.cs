using System.Linq;

namespace codewars;

public class Scramblies
{
    public static bool Scramble(string str1, string str2) =>
        str2.Distinct()
            .All(c => str1.Count(c1 => c1 == c) >= str2.Count(c2 => c2 == c));
}
