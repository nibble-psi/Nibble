using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels.CryptographySecurity;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views.CryptographySecurity;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class UuidGeneratorPage : Page
{
    public UuidGeneratorPage()
    {
        ViewModel = App.GetService<UuidGeneratorViewModel>();
        InitializeComponent();
    }

    public UuidGeneratorViewModel ViewModel
    {
        get;
        set;
    }
}