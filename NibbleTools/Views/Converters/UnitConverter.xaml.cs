// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
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
}