using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

namespace NibbleTools.Views;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class CounterPage : Page
{
    public CounterPage()
    {
        ViewModel = App.GetService<CounterViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public CounterViewModel ViewModel
    {
        get;
        set;
    }
}