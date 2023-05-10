// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using NibbleTools.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class RegexPatternPage : Page
{
    public RegexPatternPage()
    {
        ViewModel = App.GetService<RegexPatternViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public RegexPatternViewModel ViewModel
    {
        get;
        set;
    }

    private void RegexPattern_Click(object sender, RoutedEventArgs e)
    {
        var inputText = Input_String.Text;
        var inputRegexp = Input_Regular_Expression.Text;

        if (inputText != null && inputRegexp != null && inputText != String.Empty && inputRegexp != String.Empty)
        {
            if (RegexPatternViewModel.IsMatch(inputText, inputRegexp)) { Output.Background = new SolidColorBrush(Colors.Green); }
            else { Output.Background = new SolidColorBrush(Colors.Red); }
        }
        else { Output.Background = new SolidColorBrush(Colors.White); }
    }
}