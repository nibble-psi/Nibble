namespace NibbleTools.Helpers;
public static class StringExtensions
{
    public static string TakeLastOrDefault(this string value, int count, string? defaultValue = default)
    {
        if (count < 0 || count > value.Length)
            return (defaultValue is null) ? value : defaultValue;

        return value[^(count)..];
    }

    public static string TakeLast(this string value, int count)
    {
        if (count < 0 || count > value.Length)
            throw new ArgumentOutOfRangeException(nameof(count), "Out of boundaries");

        return value[^(count)..];
    }
}
