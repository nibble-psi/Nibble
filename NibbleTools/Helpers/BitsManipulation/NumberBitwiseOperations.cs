using System.Numerics;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;

public class NumberBitwiseOperations<T> : INumberBitwiseOperations<T> where T : INumber<T>, IBinaryNumber<T>
{
    public T And(T value1, T value2)
    {
        return value1 & value2;
    }

    public T Nand(T value1, T value2)
    {
        return ~(value1 & value2);
    }

    public T Nor(T value1, T value2)
    {
        return ~(value1 | value2);
    }

    public T Not(T value)
    {
        return ~value;
    }

    public T Or(T value1, T value2)
    {
        return value1 | value2;
    }

    public T Xor(T value1, T value2)
    {
        return value1 ^ value2;
    }
}