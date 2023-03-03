using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;

public class BitShiftOperations : IBitShiftOperations
{
    public int ArithmeticLeftShift(int number, int shift)
    {
        return number << shift;
    }
    public int ArithmeticRightShift(int number, int shift)
    {
        return number >> shift;
    }
    public int LogicalLeftShift(int number, int shift)
    {
        return (int)((uint)number << shift);
    }

    public int LogicalRightShift(int number, int shift)
    {
        return number >>> shift;
    }
    public int CircularLeftShift(int number, int shift)
    {
        return (number << shift) | (number >> (32 - shift));
    }
    public int CircularRightShift(int number, int shift)
    {
        return (number >> shift) | (number << (32 - shift));
    }
}
