using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NibbleTools.ViewModels;

public class LetterCasesViewModel : ObservableRecipient
{
    public static string ConvertToLowerCase(string inputString)
    {
        var lowerCase = inputString.ToLower();
        
        return lowerCase;
    }

    public static string ConvertToUpperCase(string inputString)
    {
        var upperCase = inputString.ToUpper();
        
        return upperCase;
    }

    public static string ConvertToCapitalizedCase(string inputString)
    {
        var textInfo = new CultureInfo("en-US", false).TextInfo;
        var capitalizedCase = textInfo.ToTitleCase(inputString);
        
        return capitalizedCase;
    }
}