using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NibbleTools.Helpers;

namespace NibbleTools.ViewModels;

public partial class NotOperationViewModel : ObservableObject
{
    [ObservableProperty]
    private uint _firstValue = 0;

    [ObservableProperty]
    private string _result = string.Empty;


    public NotOperationViewModel()
    {

    }

    partial void OnFirstValueChanged(uint value)
    {
        Result = Not(value).ToBinaryString();
    }


    public uint Not(uint number)
    {
        return ~number;
    }
}
