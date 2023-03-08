namespace NibbleTools.Interfaces.BitsOperations;

public interface IBitShiftOperations
{
    uint ArithmeticLeftShift(uint value, int offset);
    uint ArithmeticRightShift(uint value, int offset);
    uint LogicalLeftShift(uint value, int offset);
    uint LogicalRightShift(uint value, int offset);
    uint CircularLeftShift(uint value, int offset);
    uint CircularRightShift(uint value, int offset);
}
