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
    private uint _number;

    [ObservableProperty]
    private int bitsToShift;

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
        _bitShiftOperations = new BitShiftOperations();
    }

    public void ShiftNumber()
    {
        NumberBinaryString = Number.ToBinaryString();

        ArithmeticLeftShiftBinaryString = _bitShiftOperations.ArithmeticLeftShift(Number, BitsToShift).ToBinaryString();
        ArithmeticRightShiftBinaryString = _bitShiftOperations.ArithmeticRightShift(Number, BitsToShift).ToBinaryString();

        LogicalLeftShiftBinaryString = _bitShiftOperations.LogicalLeftShift(Number, BitsToShift).ToBinaryString();
        LogicalRightShiftBinaryString = _bitShiftOperations.LogicalRightShift(Number, BitsToShift).ToBinaryString();

        CircularLeftShiftBinaryString = _bitShiftOperations.CircularLeftShift(Number, BitsToShift).ToBinaryString();
        CircularRightShiftBinaryString = _bitShiftOperations.CircularRightShift(Number, BitsToShift).ToBinaryString();
    }

    partial void OnBitsToShiftChanged(int value)
    {
        ShiftNumber();
    }

    partial void OnNumberChanged(uint value)
    {
        ShiftNumber();
    }

}
