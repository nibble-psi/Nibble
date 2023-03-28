using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class NumberGeneratorPage : Page
{
    public NumberGeneratorPage()
    {
        ViewModel = App.GetService<NumberGeneratorViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public NumberGeneratorViewModel ViewModel
    {
        get;
        set;
    }
}