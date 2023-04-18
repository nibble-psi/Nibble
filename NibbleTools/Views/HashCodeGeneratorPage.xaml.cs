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
public sealed partial class HashCodeGeneratorPage : Page
{
    public HashCodeGeneratorPage()
    {
        ViewModel = App.GetService<HashCodeGeneratorViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public HashCodeGeneratorViewModel ViewModel
    {
        get;
        set;
    }

    private void GenerateHashCode_Click(object sender, RoutedEventArgs e)
    {
        var selectedItem = DDL.SelectedItem as ComboBoxItem;

        if (selectedItem != null)
        {
            var itemContent = selectedItem.Content as string;

            switch (itemContent)
            {
                case "MD5":
                    var md5hash = HashCodeGeneratorViewModel.ConvertToMd5();
                    TextBox1.Text = md5hash;
                    break;

                case "SHA1":
                    var sha1hash = HashCodeGeneratorViewModel.ConvertToSha1();
                    TextBox1.Text = sha1hash;
                    break;

                case "SHA-256":
                    var sha256hash = HashCodeGeneratorViewModel.ConvertToSha256();
                    TextBox1.Text = sha256hash;
                    break;
            }
        }
    }
}