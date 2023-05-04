using System.Numerics;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;

public class NumberBitShiftOperations : INumberBitShiftOperations<int>
{
    public int ArithmeticLeftShift(int value, int offset) =>
        (value << offset);

    public int ArithmeticRightShift(int value, int offset) =>
        (value >> offset);

    public int LogicalLeftShift(int value, int offset) =>
        (value << offset);

    public int LogicalRightShift(int value, int offset) =>
        (value >>> offset);

    public int CircularLeftShift(int value, int offset) => 
        ((value << offset) | (value >> (32 - offset)));

    public int CircularRightShift(int value, int offset) => 
        ((value >> offset) | (value << (32 - offset)));
}