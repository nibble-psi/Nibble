using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NibbleTools.Interfaces.BitsOperations;

public interface IBitShiftOperations
{
    int ArithmeticLeftShift(int number, int shift);
    int ArithmeticRightShift(int number, int shift);
    int LogicalLeftShift(int number, int shift);
    int LogicalRightShift(int number, int shift);
    int CircularLeftShift(int number, int shift);
    int CircularRightShift(int number, int shift);
}
