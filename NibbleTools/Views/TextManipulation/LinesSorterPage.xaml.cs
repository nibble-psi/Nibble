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
public sealed partial class LinesSorterPage : Page
{
    public LinesSorterPage()
    {
        ViewModel = App.GetService<LinesSorterViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public LinesSorterViewModel ViewModel
    {
        get;
        set;
    }

    private void LinesSorter_Click(object sender, RoutedEventArgs e)
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
            0 => LinesSorterViewModel.SortLinesInAlphabeticalOrder(inputString),
            1 => LinesSorterViewModel.SortLinesInReverseOrder(inputString),
            2 => LinesSorterViewModel.SortLinesInRandomOrder(inputString),
            _ => Output.Text
        };
    }
}