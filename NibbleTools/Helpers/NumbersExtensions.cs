namespace NibbleTools.Helpers;

public static class NumbersExtensions
{
    public static string ToBinaryString(this int value)
    {
        return Convert.ToString(value, 2);
    }

    public static string ToBinaryString(this uint value)
    {
        return Convert.ToString(value, 2);
    }

}
