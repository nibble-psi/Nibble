using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;
public class BitwiseOperations : IBitwiseOperations
{
    public string And(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (value1 & value2).ToBinaryString().TakeLast(numBits);
    }

    public string Nand(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (~(value1 & value2)).ToBinaryString().TakeLast(numBits);
    }

    public string Nor(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (~(value1 | value2)).ToBinaryString().TakeLast(numBits);
    }

    public string Not(int value)
    {
        return (~value).ToBinaryString().TakeLast(value.NumBits());
    }

    public string Or(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (value1 | value2).ToBinaryString().TakeLast(numBits);
    }

    public string Xor(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (value1 ^ value2).ToBinaryString().TakeLast(numBits);
    }
}
