using CommunityToolkit.Mvvm.ComponentModel;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.ViewModels.BitsManipulation;

public partial class BitShiftViewModel : ObservableRecipient
{
    private readonly IStringBitShiftOperations<int> _bitShiftOperations;

    [ObservableProperty] private int _number = 1;

    [ObservableProperty] private string _arithmeticLeftShiftBinaryString = string.Empty;

    [ObservableProperty] private string _arithmeticRightShiftBinaryString = string.Empty;

    [ObservableProperty] private int _bitsToShift = 1;

    [ObservableProperty] private string _bitsToShiftBinaryString = string.Empty;

    [ObservableProperty] private string _circularLeftShiftBinaryString = string.Empty;

    [ObservableProperty] private string _circularRightShiftBinaryString = string.Empty;

    [ObservableProperty] private string _logicalLeftShiftBinaryString = string.Empty;

    [ObservableProperty] private string _logicalRightShiftBinaryString = string.Empty;

    [ObservableProperty] private string _numberBinaryString = string.Empty;

    public BitShiftViewModel()
    {
        NumberBinaryString = Number.ToBinaryString();
        BitsToShiftBinaryString = BitsToShift.ToBinaryString();
        _bitShiftOperations = new StringBitShiftOperations();
    }

    private void ShiftNumber()
    {
        NumberBinaryString = Number.ToBinaryString();
        BitsToShiftBinaryString = BitsToShift.ToBinaryString();

        ArithmeticLeftShiftBinaryString = _bitShiftOperations.ArithmeticLeftShift(Number, BitsToShift);
        ArithmeticRightShiftBinaryString = _bitShiftOperations.ArithmeticRightShift(Number, BitsToShift);

        LogicalLeftShiftBinaryString = _bitShiftOperations.LogicalLeftShift(Number, BitsToShift);
        LogicalRightShiftBinaryString = _bitShiftOperations.LogicalRightShift(Number, BitsToShift);

        CircularLeftShiftBinaryString = _bitShiftOperations.CircularLeftShift(Number, BitsToShift);
        CircularRightShiftBinaryString = _bitShiftOperations.CircularRightShift(Number, BitsToShift);
    }

    partial void OnBitsToShiftChanged(int value)
    {
        if (value < 0)
        {
            BitsToShift = 1;
        }

        ShiftNumber();
    }

    partial void OnNumberChanged(int value)
    {
        if (value < 0)
        {
            Number = 1;
        }

        ShiftNumber();
    }
}