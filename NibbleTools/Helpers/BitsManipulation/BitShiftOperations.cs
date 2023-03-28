using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;

public class BitShiftOperations : IBitShiftOperations
{
    public string ArithmeticLeftShift(int value, int offset) =>
        (value << offset).ToBinaryString().TakeLastOrDefault(value.NumBits());

    public string ArithmeticRightShift(int value, int offset) =>
        (value >> offset).ToBinaryString().TakeLastOrDefault(value.NumBits());

    public string LogicalLeftShift(int value, int offset) =>
        (value << offset).ToBinaryString().TakeLastOrDefault(value.NumBits());

    public string LogicalRightShift(int value, int offset) =>
        (value >>> offset).ToBinaryString().TakeLastOrDefault(value.NumBits());

    public string CircularLeftShift(int value, int offset) => ((value << offset) | (value >> (32 - offset)))
                                                              .ToBinaryString()
                                                              .TakeLastOrDefault(value.NumBits());

    public string CircularRightShift(int value, int offset) => ((value >> offset) | (value << (32 - offset)))
                                                               .ToBinaryString()
                                                               .TakeLastOrDefault(value.NumBits());
}