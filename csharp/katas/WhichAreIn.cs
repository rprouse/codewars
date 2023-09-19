namespace codewars;

class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2) =>
        array1.Where(a1 => array2.Any(a2 => a2.Contains(a1)))
            .OrderBy(a => a)
            .ToArray();
}