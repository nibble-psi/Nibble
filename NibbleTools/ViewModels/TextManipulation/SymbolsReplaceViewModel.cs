using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NibbleTools.ViewModels.TextManipulation;

public partial class SymbolsReplaceViewModel : ObservableObject
{
    [ObservableProperty] private string _input = string.Empty;
    
    [ObservableProperty] private string _output = string.Empty;
    
    [ObservableProperty] private string _replaceFrom = string.Empty;
    
    [ObservableProperty] private string _replaceTo = string.Empty;

    [RelayCommand]
    public void Replace()
    {
        if (string.IsNullOrEmpty(Input) || string.IsNullOrEmpty(ReplaceFrom) || string.IsNullOrEmpty(ReplaceTo))
        {
            return;
        }

        Output = Input.Replace(ReplaceFrom, ReplaceTo);
    }

    [RelayCommand]
    public void Clear()
    {
        Input = string.Empty;
        Output = string.Empty;
        ReplaceFrom = string.Empty;
        ReplaceTo = string.Empty;
    }
}