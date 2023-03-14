using CommunityToolkit.Mvvm.ComponentModel;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using NibbleTools.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NibbleTools.ViewModels;
public partial class AndNandViewModel : ObservableRecipient
{
    [ObservableProperty]
    private int _firstValue = 0;

    [ObservableProperty]
    private int _secondValue = 0;

    [ObservableProperty]
    private string _resultAND = string.Empty;

    [ObservableProperty]
    private string _resultNAND = string.Empty;

    public AndNandViewModel()
    {

    }

    partial void OnFirstValueChanged(int value)
    {
        ResultAND = AND(FirstValue, SecondValue).ToBinaryString();
        ResultNAND = NAND(FirstValue, SecondValue).ToBinaryString();
    }

    partial void OnSecondValueChanged(int value)
    {
        ResultAND = AND(FirstValue, SecondValue).ToBinaryString();
        ResultNAND = NAND(FirstValue, SecondValue).ToBinaryString();
    }

    public int AND(int firstValue, int secondValue)
    {
        return firstValue & secondValue;
    }

    public int NAND(int firstValue, int secondValue)
    {
        return ~(firstValue & secondValue) & 0xf;
    }
}