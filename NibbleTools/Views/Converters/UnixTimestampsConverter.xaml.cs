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
public sealed partial class UnixTimestampsConverterPage : Page
{
    public UnixTimestampsConverterPage()
    {
        ViewModel = App.GetService<UnixTimestampsConverterViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public UnixTimestampsConverterViewModel ViewModel
    {
        get;
        set;
    }

    public void ConvertUNIX_Click(object sender, RoutedEventArgs e)
    {
        if (long.TryParse(UnixTimestampTextBox.Text, out var seconds))
        {
            var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(seconds);

            YearTextBlock.Text = dateTimeOffset.Year.ToString();
            MonthTextBlock.Text = dateTimeOffset.Month.ToString();
            DayTextBlock.Text = dateTimeOffset.Day.ToString();
            HourTextBlock.Text = dateTimeOffset.Hour.ToString();
            MinuteTextBlock.Text = dateTimeOffset.Minute.ToString();
            SecondTextBlock.Text = dateTimeOffset.Second.ToString();
        }
    }
}
