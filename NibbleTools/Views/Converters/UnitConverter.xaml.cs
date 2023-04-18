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
using Newtonsoft.Json.Linq;
using NibbleTools.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class UnitConverterPage : Page
{
    public UnitConverterPage()
    {
        ViewModel = App.GetService<UnitConverterViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public UnitConverterViewModel ViewModel
    {
        get;
        set;
    }

    public void Convert_Click(object sender, RoutedEventArgs e)
    {
        var selectedOne = itemOne.SelectedItem as ComboBoxItem;
        var selectedTwo = itemTwo.SelectedItem as ComboBoxItem;
        var value = Value.Value;

        string? from = null;
        string? to = null;

        if (selectedOne != null)
        {
            from = selectedOne.Content as string;
        }

        if (selectedTwo != null)
        {
            to = selectedTwo.Content as string;
        }

        var factors = new Dictionary<(string, string), double>
        {
            { ("m", "km"), 0.001 },
            { ("m", "cm"), 100 },
            { ("km", "m"), 1000 },
            { ("km", "cm"), 100000 },
            { ("cm", "m"), 0.01 },
            { ("cm", "km"), 0.00001 }
        };

        if (from != null && to != null && factors.ContainsKey((from, to)))
        {
            var factor = factors[(from, to)];
            var x = Convert.ToString(value * factor);

            TextBox1.Text = x;
        }
        else
        {
            TextBox1.Text = Convert.ToString(value);
        }
    }
}
