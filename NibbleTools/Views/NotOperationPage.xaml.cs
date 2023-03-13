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


namespace NibbleTools.Pages;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class NotOperationPage : Page
{
    public NotOperationViewModel ViewModel
    {
        get;
        set;
    }

    public NotOperationPage()
    {
        ViewModel = App.GetService<NotOperationViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }
}
