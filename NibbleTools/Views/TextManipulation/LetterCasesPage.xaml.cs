// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
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
        string inputString = Input.Text.ToString();

        if (selectedItem != null)
        {
            var itemContent = selectedItem.Content as string;

            switch (itemContent)
            {
                case "lower case":
                    Output.Text = LetterCasesViewModel.ConvertToLowerCase(inputString);
                    break;

                case "UPPER CASE":
                    Output.Text = LetterCasesViewModel.ConvertToUpperCase(inputString);
                    break;

                case "Capitalized Case":
                    Output.Text = LetterCasesViewModel.ConvertToCapitalizedCase(inputString);
                    break;
            }
        }
    }
}