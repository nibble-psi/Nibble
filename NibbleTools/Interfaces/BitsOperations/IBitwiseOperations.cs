namespace NibbleTools.Interfaces.BitsOperations;
public interface IBitwiseOperations
{
    int Not(int value);
    int Xor(int value1, int value2);
    int And(int value1, int value2);
    int Nand(int value1, int value2);
    int Or(int value1, int value2);
    int Nor(int value1, int value2);
}
