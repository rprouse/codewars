namespace codewars;

public class SumDigPower
{
    public static long[] SumDigPow(long a, long b)
    {
        var result = new List<long>();
        for (var i = a; i <= b; i++)
        {
            if (IsSumDigPow(i))
            {
                result.Add(i);
            }
        }
        return result.ToArray();
    }

    private static bool IsSumDigPow(long i)
    {
        var digits = i.ToString().Select(c => char.GetNumericValue(c)).ToArray();
        var sum = 0;
        for (var j = 0; j < digits.Length; j++)
        {
            sum += (int)Math.Pow(digits[j], j + 1);
        }
        return sum == i;
    }
}