using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;

public class StringBitwiseOperations : IStringBitwiseOperations<int>
{
    public string And(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (value1 & value2).ToBinaryString().TakeLastOrDefault(numBits);
    }

    public string Nand(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (~(value1 & value2)).ToBinaryString().TakeLastOrDefault(numBits);
    }

    public string Nor(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (~(value1 | value2)).ToBinaryString().TakeLastOrDefault(numBits);
    }

    public string Not(int value) => (~value).ToBinaryString().TakeLastOrDefault(value.NumBits());

    public string Or(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (value1 | value2).ToBinaryString().TakeLastOrDefault(numBits);
    }

    public string Xor(int value1, int value2)
    {
        var numBits = Math.Max(value1.NumBits(), value2.NumBits());
        return (value1 ^ value2).ToBinaryString().TakeLastOrDefault(numBits);
    }
}