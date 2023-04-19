using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace NibbleTools.Interfaces.Services;

public interface IPageService
{
    Dictionary<string, Type> Pages { get; }
    
    Type GetPageType(string key);

    void Configure<VM, V>()
        where VM : ObservableObject
        where V : Page;
}