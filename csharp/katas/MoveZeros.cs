using System.Linq;

namespace codewars;

public class MoveZeros
{
    public static int[] MoveZeroes(int[] arr)
    {
        int zeros = arr.Count(x => x == 0);
        return arr.Where(x => x != 0)
            .Concat(Enumerable.Repeat(0, zeros))
            .ToArray();
    }
}
