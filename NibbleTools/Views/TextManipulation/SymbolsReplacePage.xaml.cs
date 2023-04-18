using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels.TextManipulation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views.TextManipulation;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class SymbolsReplacePage : Page
{
    public SymbolsReplacePage()
    {
        ViewModel = App.GetService<SymbolsReplaceViewModel>();
        InitializeComponent();
    }

    public SymbolsReplaceViewModel ViewModel
    {
        get;
        set;
    }
}