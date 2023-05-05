using NibbleTools.Helpers;

namespace NibbleTools;

public sealed partial class MainWindow : WindowEx
{
    public MainWindow()
    {
        InitializeComponent();

        AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
        Content = null;
        Title = "AppDisplayName".GetLocalized();

        // TODO Set the minimum size of the window
        /*MinHeight = 426;
        MinWidth = 800;*/

        // TODO Set the default size of the window
        /*Height = 600;
        Width = 800;*/
    }
}