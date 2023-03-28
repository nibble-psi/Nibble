using CommunityToolkit.Mvvm.ComponentModel;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.ViewModels.BitsManipulation;

public partial class BitwiseViewModel : ObservableRecipient
{
    private readonly IBitwiseOperations bitwiseOperations;

    [ObservableProperty] private int _firstValue = 1;

    [ObservableProperty] private string _firstValueBinary = string.Empty;

    [ObservableProperty] private int _secondValue = 1;

    [ObservableProperty] private string _secondValueBinary = string.Empty;

    [ObservableProperty] private string resultAnd = string.Empty;

    [ObservableProperty] private string resultNand = string.Empty;

    [ObservableProperty] private string resultNor = string.Empty;

    [ObservableProperty] private string resultNotFirstValue = string.Empty;

    [ObservableProperty] private string resultNotSecondValue = string.Empty;

    [ObservableProperty] private string resultOr = string.Empty;

    [ObservableProperty] private string resultXor = string.Empty;


    public BitwiseViewModel()
    {
        bitwiseOperations = new BitwiseOperations();
        FirstValueBinary = FirstValue.ToBinaryString();
        SecondValueBinary = SecondValue.ToBinaryString();
    }

    partial void OnFirstValueChanged(int value)
    {
        if (value < 0)
        {
            FirstValue = 1;
        }

        RecalculateResults();
    }

    partial void OnSecondValueChanged(int value)
    {
        if (value < 0)
        {
            SecondValue = 1;
        }

        RecalculateResults();
    }

    public void RecalculateResults()
    {
        FirstValueBinary = FirstValue.ToBinaryString();
        SecondValueBinary = SecondValue.ToBinaryString();

        ResultAnd = bitwiseOperations.And(FirstValue, SecondValue);

        ResultOr = bitwiseOperations.Or(FirstValue, SecondValue);
        ResultXor = bitwiseOperations.Xor(FirstValue, SecondValue);

        ResultNotFirstValue = bitwiseOperations.Not(FirstValue);
        ResultNotSecondValue = bitwiseOperations.Not(SecondValue);

        ResultNand = bitwiseOperations.Nand(FirstValue, SecondValue);
        ResultNor = bitwiseOperations.Nor(FirstValue, SecondValue);
    }
}