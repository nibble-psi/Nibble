using Microsoft.UI.Xaml.Controls;

using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class NumberGeneratorPage : Page
{
    public NumberGeneratorViewModel ViewModel
    {
        get;
        set;
    }

    public NumberGeneratorPage()
    {
        ViewModel = App.GetService<NumberGeneratorViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }
}
