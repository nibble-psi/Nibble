using CommunityToolkit.Mvvm.ComponentModel;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.ViewModels.BitsManipulation;

public partial class BitwiseViewModel : ObservableRecipient
{
    private readonly IBitwiseOperations<int, string> _bitwiseOperations;

    [ObservableProperty] private int _firstValue = 1;

    [ObservableProperty] private string _firstValueBinary = string.Empty;

    [ObservableProperty] private int _secondValue = 1;

    [ObservableProperty] private string _secondValueBinary = string.Empty;

    [ObservableProperty] private string _resultAnd = string.Empty;

    [ObservableProperty] private string _resultNand = string.Empty;

    [ObservableProperty] private string _resultNor = string.Empty;

    [ObservableProperty] private string _resultNotFirstValue = string.Empty;

    [ObservableProperty] private string _resultNotSecondValue = string.Empty;

    [ObservableProperty] private string _resultOr = string.Empty;

    [ObservableProperty] private string resultXor = string.Empty;


    public BitwiseViewModel()
    {
        _bitwiseOperations = new StringBitwiseOperations();

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

    private void RecalculateResults()
    {
        FirstValueBinary = FirstValue.ToBinaryString();
        SecondValueBinary = SecondValue.ToBinaryString();

        ResultAnd = _bitwiseOperations.And(FirstValue, SecondValue);

        ResultOr = _bitwiseOperations.Or(FirstValue, SecondValue);
        ResultXor = _bitwiseOperations.Xor(FirstValue, SecondValue);

        ResultNotFirstValue = _bitwiseOperations.Not(FirstValue);
        ResultNotSecondValue = _bitwiseOperations.Not(SecondValue);

        ResultNand = _bitwiseOperations.Nand(FirstValue, SecondValue);
        ResultNor = _bitwiseOperations.Nor(FirstValue, SecondValue);
    }
}