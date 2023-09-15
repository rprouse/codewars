namespace codewars;

public class HumanReadableTime
{
    public static string GetReadableTime(int seconds)
    {
        if (seconds < 0 || seconds > 359999)
            throw new ArgumentOutOfRangeException(nameof(seconds), "Must be between 0 and 359999");

        var hrs  = seconds / 3600;
        var mins = (seconds % 3600) / 60;
        var secs = seconds % 60;
        return $"{hrs:00}:{mins:00}:{secs:00}";
    }
}