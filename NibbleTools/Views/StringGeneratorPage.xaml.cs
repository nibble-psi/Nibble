// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using NibbleTools.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class StringGeneratorPage : Page
{

    public StringGeneratorViewModel ViewModel
    {
        get;
        set; 
    }

    public StringGeneratorPage()
    {
        ViewModel = App.GetService<StringGeneratorViewModel>();
        DataContext = ViewModel;
        this.InitializeComponent();
    }

    private void GenerateWord_Click(object sender, RoutedEventArgs e)
    {
        ComboBoxItem? selectedItem = DDL.SelectedItem as ComboBoxItem;

        if (selectedItem != null)
        {
            string itemContent = selectedItem.Content as string;

            switch (itemContent)
            {
                case "Word":
                    string randomWord = StringGeneratorViewModel.GenerateRandomWord(7);
                    TextBox1.Text = randomWord;
                    break;

                case "Sentence":
                    string randomSentence = StringGeneratorViewModel.GenerateRandomSentence();
                    TextBox1.Text = randomSentence;
                    break;

                case "Paragraph":
                    string randomParagraph = StringGeneratorViewModel.GenerateRandomParagraph();
                    TextBox1.Text = randomParagraph;
                    break;

                default:
                    break;
            }
        }

    }
}
