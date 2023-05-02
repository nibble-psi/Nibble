using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class PrimeNumberGeneratorPage : Page
{
    public PrimeNumberGeneratorPage()
    {
        ViewModel = App.GetService<PrimeNumberGeneratorViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public PrimeNumberGeneratorViewModel ViewModel
    {
        get;
        set;
    }
}