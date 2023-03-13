using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;

public class BitShiftOperations : IBitShiftOperations
{
    public uint ArithmeticLeftShift(uint value, int offset) => value << offset;

    public uint ArithmeticRightShift(uint value, int offset) => value >> offset;

    public uint LogicalLeftShift(uint value, int offset) => value << offset;

    public uint LogicalRightShift(uint value, int offset) => value >>> offset;

    public uint CircularLeftShift(uint value, int offset) => (value << offset) | (value >> (32 - offset));

    public uint CircularRightShift(uint value, int offset) => (value >> offset) | (value << (32 - offset));
}
