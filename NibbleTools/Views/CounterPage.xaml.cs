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


namespace NibbleTools.Views;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class CounterPage : Page
{

    public CounterViewModel ViewModel
    {
        get;
        set;
    }

    public CounterPage()
    {
        ViewModel = App.GetService<CounterViewModel>();
        DataContext = ViewModel;
        this.InitializeComponent();
    }
}
