using CommunityToolkit.Mvvm.ComponentModel;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.ViewModels.BitsManipulation;
public partial class BitwiseViewModel : ObservableRecipient
{
    private readonly IBitwiseOperations bitwiseOperations;

    [ObservableProperty]
    private int _firstValue = 0;

    [ObservableProperty]
    private int _secondValue = 0;

    [ObservableProperty]
    private string _resultAnd = string.Empty;

    [ObservableProperty]
    private string _resultOr = string.Empty;

    [ObservableProperty]
    private string _resultXor = string.Empty;

    [ObservableProperty]
    private string _resultNotFirstValue = string.Empty;

    [ObservableProperty]
    private string _resultNotSecondValue = string.Empty;

    [ObservableProperty]
    private string _resultNand = string.Empty;

    [ObservableProperty]
    private string _resultNor = string.Empty;


    public BitwiseViewModel()
    {
        bitwiseOperations = new BitwiseOperations();
    }


    partial void OnFirstValueChanged(int value)
    {
        RecalculateResults();
    }

    partial void OnSecondValueChanged(int value)
    {
        RecalculateResults();
    }

    private void RecalculateResults()
    {
        ResultAnd = bitwiseOperations.And(FirstValue, SecondValue).ToBinaryString();
        ResultOr = bitwiseOperations.Or(FirstValue, SecondValue).ToBinaryString();
        ResultXor = bitwiseOperations.Xor(FirstValue, SecondValue).ToBinaryString();

        ResultNotFirstValue = bitwiseOperations.Not(FirstValue).ToBinaryString();
        ResultNotSecondValue = bitwiseOperations.Not(SecondValue).ToBinaryString();

        ResultNand = bitwiseOperations.Nand(FirstValue, SecondValue).ToBinaryString();
        ResultNor = bitwiseOperations.Nor(FirstValue, SecondValue).ToBinaryString();
    }
}
