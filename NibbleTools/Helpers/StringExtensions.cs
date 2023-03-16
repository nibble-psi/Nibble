namespace NibbleTools.Helpers;
public static class StringExtensions
{
    public static string TakeLast(this string value, int count)
    {
        if (value.Length - count <= 0) return value;
        
        return value[^(count+1)..];
    }
}
