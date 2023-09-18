namespace codewars;

public static class RgbConversion
{
    public static string Rgb(int r, int g, int b) => 
        $"{ToHex(r)}{ToHex(g)}{ToHex(b)}";

    private static string ToHex(int value) =>
        value switch
        {
            < 0 => "00",
            > 255 => "FF",
            _ => value.ToString("X2")
        };
}