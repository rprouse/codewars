namespace codewars;

public class SumOfTwoLowestPositiveIntegers
{
    public static int sumTwoSmallestNumbers(int[] numbers) =>
        numbers.OrderBy(x => x).Take(2).Sum();
}
