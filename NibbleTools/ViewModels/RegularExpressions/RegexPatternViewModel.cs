using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NibbleTools.ViewModels;

public class RegexPatternViewModel : ObservableRecipient
{
    public static bool IsMatch(string text, string regex)
    {
        Regex pattern = new Regex(regex);

        bool isMatch = pattern.IsMatch(text);

        return isMatch;
    }
}