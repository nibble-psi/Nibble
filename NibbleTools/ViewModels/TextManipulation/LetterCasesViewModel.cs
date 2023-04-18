using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using NibbleTools.Views;
using System.Globalization;

namespace NibbleTools.ViewModels;

public partial class LetterCasesViewModel : ObservableRecipient
{
    public static string ConvertToLowerCase(string inputString)
    {
        string lowerCase = inputString.ToLower();
        return lowerCase;
    }

    public static string ConvertToUpperCase(string inputString)
    {
        string upperCase = inputString.ToUpper();
        return upperCase;
    }

    public static string ConvertToCapitalizedCase(string inputString)
    {
        // Using the TextInfo class to convert input to capitalized case
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string capitalizedCase = textInfo.ToTitleCase(inputString);
        return capitalizedCase;
    }
}