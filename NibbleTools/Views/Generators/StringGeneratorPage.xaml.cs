// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

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

        if (selectedItem != null)
        {
            var itemContent = selectedItem.Content as string;

            switch (itemContent)
            {
                case "Word":
                    var randomWord = StringGeneratorViewModel.GenerateRandomWord(7);
                    TextBox1.Text = randomWord;
                    break;

                case "Sentence":
                    var randomSentence = StringGeneratorViewModel.GenerateRandomSentence();
                    TextBox1.Text = randomSentence;
                    break;

                case "Paragraph":
                    var randomParagraph = StringGeneratorViewModel.GenerateRandomParagraph();
                    TextBox1.Text = randomParagraph;
                    break;
            }
        }
    }
}