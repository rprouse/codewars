namespace codewars;

public class SquareEveryDigit
{
    public static int SquareDigits(int n)
    {
        var result = n.ToString()
            .Select(char.GetNumericValue)
            .Select(x => x * x)
            .Aggregate("", (acc, s) => acc + s.ToString());
        return int.Parse(result);
    }
}
