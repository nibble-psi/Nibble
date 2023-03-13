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

namespace NibbleTools.Views
{
    public sealed partial class XORPage : Page
    {
        public XORViewModel ViewModel
        {
            get;
            set;
        }

        public XORPage()
        {
            ViewModel = App.GetService<XORViewModel>();
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
