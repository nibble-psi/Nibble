using System.Numerics;

namespace NibbleTools.Interfaces.BitsOperations;

public interface IBitwiseOperations<TSelf, TResult>
{
    TResult Not(TSelf value);
    TResult Xor(TSelf value1, TSelf value2);
    TResult And(TSelf value1, TSelf value2);
    TResult Nand(TSelf value1, TSelf value2);
    TResult Or(TSelf value1, TSelf value2);
    TResult Nor(TSelf value1, TSelf value2);
}

public interface INumberBitwiseOperations<TSelf> : IBitwiseOperations<TSelf, TSelf>
    where TSelf : INumber<TSelf>, IBinaryNumber<TSelf>
{
}

public interface IStringBitwiseOperations<TSelf> : IBitwiseOperations<TSelf, string>
    where TSelf : INumber<TSelf>, IBinaryNumber<TSelf>
{
}