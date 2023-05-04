// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using NibbleTools.ViewModels;
using NibbleTools.ViewModels.Markdown;
using CommunityToolkit.WinUI.UI.Controls;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI;
using Windows.Media.Protection.PlayReady;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views.Markdown;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MarkdownPreviewPage : Page
{
    public MarkdownPreviewPage()
    {
        ViewModel = App.GetService<MarkdownPreviewViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public MarkdownPreviewViewModel ViewModel
    {
        get;
        set;
    }

    public void MarkdownText_CodeBlockResolving(object sender, CodeBlockResolvingEventArgs e)
    {
        if (e.CodeLanguage == "CUSTOM")
        {
            e.Handled = true;
            e.InlineCollection.Add(new Run { Foreground = new SolidColorBrush(Colors.Red), Text = e.Text, FontWeight = FontWeights.Bold });
        }
    }

}
