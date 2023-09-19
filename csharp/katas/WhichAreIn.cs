namespace codewars;

class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2) =>
        array1.Distinct()
            .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
            .OrderBy(s => s)
            .ToArray();
}
