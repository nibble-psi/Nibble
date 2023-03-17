using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.ViewModels.BitsManipulation;
public partial class BitShiftViewModel : ObservableRecipient
{
    [ObservableProperty]
    private int _number = 1;

    [ObservableProperty]
    private int bitsToShift = 1;

    [ObservableProperty]
    private string bitsToShiftBinaryString = string.Empty;

    [ObservableProperty]
    private string numberBinaryString = string.Empty;

    [ObservableProperty]
    private string arithmeticLeftShiftBinaryString = string.Empty;

    [ObservableProperty]
    private string arithmeticRightShiftBinaryString = string.Empty;

    [ObservableProperty]
    private string logicalLeftShiftBinaryString = string.Empty;

    [ObservableProperty]
    private string logicalRightShiftBinaryString = string.Empty;

    [ObservableProperty]
    private string circularLeftShiftBinaryString = string.Empty;

    [ObservableProperty]
    private string circularRightShiftBinaryString = string.Empty;

    private readonly IBitShiftOperations _bitShiftOperations;

    public BitShiftViewModel()
    {
        NumberBinaryString = Number.ToBinaryString();
        BitsToShiftBinaryString = BitsToShift.ToBinaryString();
        _bitShiftOperations = new BitShiftOperations();
    }

    public void ShiftNumber()
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
        ShiftNumber();
    }

    partial void OnNumberChanged(int value)
    {
        ShiftNumber();
    }

}
