using CommunityToolkit.Mvvm.ComponentModel;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using NibbleTools.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NibbleTools.ViewModels;
public partial class ORNORViewModel : ObservableRecipient
{
    [ObservableProperty]
    private uint _firstValue;

    [ObservableProperty]
    private uint _secondValue;

    [ObservableProperty]
    private string _resultOR = string.Empty;

    [ObservableProperty]
    private string _resultNOR = string.Empty;

    public ORNORViewModel()
    {

    }

    partial void OnFirstValueChanged(uint value)
    {
        ResultOR = OR(FirstValue, SecondValue).ToBinaryString();
        ResultNOR = NOR(FirstValue, SecondValue).ToBinaryString();

    }

    partial void OnSecondValueChanged(uint value)
    {
        ResultOR = OR(FirstValue, SecondValue).ToBinaryString();
        ResultNOR = NOR(FirstValue, SecondValue).ToBinaryString();
    }

    public uint OR(uint firstValue, uint secondValue)
    {
        return firstValue | secondValue;
    }

    public uint NOR(uint firstValue, uint secondValue)
    {
        return ~(firstValue | secondValue);
    }
}
