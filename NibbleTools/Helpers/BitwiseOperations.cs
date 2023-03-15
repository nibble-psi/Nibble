using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Helpers;
public class BitwiseOperations : IBitwiseOperations
{
    public int And(int value1, int value2) => value1 & value2;
    public int Nand(int value1, int value2) => ~(value1 & value2);
    public int Nor(int value1, int value2) => ~(value1 | value2);
    public int Not(int value) => ~value;
    public int Or(int value1, int value2) => value1 | value2;
    public int Xor(int value1, int value2) => value1 ^ value2;
}
