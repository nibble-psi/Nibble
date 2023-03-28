namespace NibbleTools.Interfaces.BitsOperations;

public interface IBitShiftOperations
{
    string ArithmeticLeftShift(int value, int offset);
    string ArithmeticRightShift(int value, int offset);
    string LogicalLeftShift(int value, int offset);
    string LogicalRightShift(int value, int offset);
    string CircularLeftShift(int value, int offset);
    string CircularRightShift(int value, int offset);
}