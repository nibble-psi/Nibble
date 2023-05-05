// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.Helpers;
using NibbleTools.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class LetterCasesPage : Page
{
    public LetterCasesPage()
    {
        ViewModel = App.GetService<LetterCasesViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public LetterCasesViewModel ViewModel
    {
        get;
        set;
    }

    private void LetterCases_Click(object sender, RoutedEventArgs e)
    {
        var selectedItem = DDL.SelectedItem as ComboBoxItem;
        var inputString = Input.Text;

        if (selectedItem == null)
        {
            return;
        }
        
        var selectedIndex = DDL.SelectedIndex;

        Output.Text = selectedIndex switch
        {
            0 => LetterCasesViewModel.ConvertToLowerCase(inputString),
            1 => LetterCasesViewModel.ConvertToUpperCase(inputString),
            2 => LetterCasesViewModel.ConvertToCapitalizedCase(inputString),
            _ => Output.Text
        };
    }
}