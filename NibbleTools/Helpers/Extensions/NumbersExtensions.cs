namespace NibbleTools.Helpers;

public static class NumbersExtensions
{
    public static string ToBinaryString(this int value) => Convert.ToString(value, 2);

    public static int NumBits(this int value) => (int)Math.Log(Math.Abs(value), 2) + 1;

    public static int NumBits(this uint value) => (int)Math.Log(Math.Abs(value), 2) + 1;

    public static string ToBinaryString(this uint value) => Convert.ToString(value, 2);
}