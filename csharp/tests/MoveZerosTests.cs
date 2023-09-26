using NUnit.Framework;

using Shouldly;

namespace codewars;

public class MoveZerosTests
{
    [Test]
    public void CanMoveZeroes()
    {
        MoveZeros.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 })
            .ShouldBe(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 });
    }
}
