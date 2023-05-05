// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class StringGeneratorPage : Page
{
    public StringGeneratorPage()
    {
        ViewModel = App.GetService<StringGeneratorViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public StringGeneratorViewModel ViewModel
    {
        get;
        set;
    }

    private void GenerateWord_Click(object sender, RoutedEventArgs e)
    {
        var selectedItem = DDL.SelectedItem as ComboBoxItem;

        if (selectedItem == null)
        {
            return;
        }
        
        var selectedIndex = DDL.SelectedIndex;

        switch (selectedIndex)
        {
            case 0:
                TextBox1.Text = StringGeneratorViewModel.GenerateRandomWord(7);
                break;

            case 1:
                TextBox1.Text = StringGeneratorViewModel.GenerateRandomSentence();;
                break;

            case 2:
                TextBox1.Text = StringGeneratorViewModel.GenerateRandomParagraph();
                break;
            
            default:
                TextBox1.Text = "";
                break;
 
        }
    }
}