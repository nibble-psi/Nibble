﻿using Microsoft.UI.Xaml.Controls;

using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
