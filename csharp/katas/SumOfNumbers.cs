using System;
using System.Linq;

namespace codewars;

public class SumOfNumbers
{
    public int GetSum(int a, int b)
    {
        var min = Math.Min(a, b);
        var max = Math.Max(a, b);

        return Enumerable.Range(min, max - min + 1).Sum();
    }
}
