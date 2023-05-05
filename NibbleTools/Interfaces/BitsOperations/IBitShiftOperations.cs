using System.Numerics;

namespace NibbleTools.Interfaces.BitsOperations;

public interface IBitShiftOperations<TSelf, TResult>
{
    TResult ArithmeticLeftShift(TSelf value, TSelf offset);
    TResult ArithmeticRightShift(TSelf value, TSelf offset);
    TResult LogicalLeftShift(TSelf value, TSelf offset);
    TResult LogicalRightShift(TSelf value, TSelf offset);
    TResult CircularLeftShift(TSelf value, TSelf offset);
    TResult CircularRightShift(TSelf value, TSelf offset);
}

public interface INumberBitShiftOperations<TSelf> : IBitShiftOperations<TSelf, TSelf>
    where TSelf : INumber<TSelf>, IBinaryNumber<TSelf>
{
}

public interface IStringBitShiftOperations<TSelf> : IBitShiftOperations<TSelf, string>
    where TSelf : INumber<TSelf>, IBinaryNumber<TSelf>
{
}