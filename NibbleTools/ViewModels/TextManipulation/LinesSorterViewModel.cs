using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using NibbleTools.Views;

namespace NibbleTools.ViewModels;

public partial class LinesSorterViewModel : ObservableRecipient
{
    public static string SortLinesInAlphabeticalOrder(string inputString)
    {
        // Split the input string into lines
        var lines = inputString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

        // Sort the lines in alphabetical order
        Array.Sort(lines);

        // Join the sorted lines back into a single string
        var outputString = string.Join(Environment.NewLine, lines);

        return outputString;
    }

    public static string SortLinesInReverseOrder(string inputString)
    {
        // Split the input string into lines
        var lines = inputString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

        // Sort the lines in reverse order
        Array.Sort(lines);
        Array.Reverse(lines);

        // Join the sorted lines back into a single string
        var outputString = string.Join(Environment.NewLine, lines);

        return outputString;
    }


    public static string SortLinesInRandomOrder(string inputString)
    {
        // Split the input string into lines
        var lines = inputString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

        // Shuffle the lines randomly
        Random random = new Random();
        int n = lines.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            string temp = lines[i];
            lines[i] = lines[j];
            lines[j] = temp;
        }

        // Join the shuffled lines back into a single string
        var outputString = string.Join(Environment.NewLine, lines);

        return outputString;
    }
}