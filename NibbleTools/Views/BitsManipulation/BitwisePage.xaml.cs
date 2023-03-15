using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels.BitsManipulation;
using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class BitwisePage : Page
{
    public BitwiseViewModel ViewModel
    {
        get;
        set;
    }


    public BitwisePage()
    {
        ViewModel = App.GetService<BitwiseViewModel>();
        InitializeComponent();
    }
}
