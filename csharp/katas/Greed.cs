using System.Linq;

namespace codewars;

public class Greed
{
    public readonly static int[] Scores = new int[] { 0, 1000, 200, 300, 400, 500, 600 };

    public static int Score(int[] dice)
    {
        int score = Enumerable.Range(1, 6).Sum(i => dice.Count(die => die == i) >= 3 ? Scores[i] : 0);
        if (dice.Count(dice => dice == 1) >= 3)
        {
            dice = dice.OrderByDescending(die => die != 1).Take(2).ToArray();
        }
        if (dice.Count(dice => dice == 5) >= 3)
        {
            dice = dice.OrderByDescending(die => die != 5).Take(2).ToArray();
        }
        score += dice.Where(dice => dice == 1).Count() * 100;
        score += dice.Where(dice => dice == 5).Count() * 50;
        return score;
    }
}