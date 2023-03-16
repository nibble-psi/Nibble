namespace NibbleTools.Interfaces.BitsOperations;
public interface IBitwiseOperations
{
    string Not(int value);
    string Xor(int value1, int value2);
    string And(int value1, int value2);
    string Nand(int value1, int value2);
    string Or(int value1, int value2);
    string Nor(int value1, int value2);
}
