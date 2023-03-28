using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels.BitsManipulation;

namespace NibbleTools.Views;

public sealed partial class BitwisePage : Page
{
    public BitwisePage()
    {
        ViewModel = App.GetService<BitwiseViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public BitwiseViewModel ViewModel
    {
        get;
        set;
    }
}