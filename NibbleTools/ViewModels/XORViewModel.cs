using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using NibbleTools.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NibbleTools.ViewModels;
public partial class XORViewModel : ObservableRecipient
{
    [ObservableProperty]
    private uint _firstValue = 0;

    [ObservableProperty]
    private uint _secondValue = 0;

    [ObservableProperty]
    private string _result = string.Empty;


    public XORViewModel()
    {

    }

    partial void OnFirstValueChanged(uint value)
    {
        Result = XOR(FirstValue, SecondValue).ToBinaryString();
    }

    partial void OnSecondValueChanged(uint value)
    {
        Result = XOR(FirstValue, SecondValue).ToBinaryString();
    }

    public uint XOR(uint firstValue, uint secondValue)
    {
        return firstValue ^ secondValue;
    }


}
