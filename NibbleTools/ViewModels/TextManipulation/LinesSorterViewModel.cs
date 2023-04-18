using CommunityToolkit.Mvvm.ComponentModel;

namespace NibbleTools.ViewModels;

public class LinesSorterViewModel : ObservableRecipient
{
    public static string SortLinesInAlphabeticalOrder(string inputString)
    {
        var lines = inputString.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);
        
        Array.Sort(lines);
        
        var outputString = string.Join(Environment.NewLine, lines);

        return outputString;
    }

    public static string SortLinesInReverseOrder(string inputString)
    {
        var lines = inputString.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);
        
        Array.Sort(lines);
        
        Array.Reverse(lines);
        
        var outputString = string.Join(Environment.NewLine, lines);

        return outputString;
    }


    public static string SortLinesInRandomOrder(string inputString)
    {
        var random = new Random();
        
        var lines = inputString.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);
        var n = lines.Length;
        
        for (var i = n - 1; i > 0; i--)
        {
            var j = random.Next(0, i + 1);
            
            (lines[i], lines[j]) = (lines[j], lines[i]);
        }
        
        var outputString = string.Join(Environment.NewLine, lines);

        return outputString;
    }
}