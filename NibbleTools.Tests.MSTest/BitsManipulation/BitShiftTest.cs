using FluentAssertions;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Tests.MSTest;

[TestClass]
public class BitShiftTest
{
    private readonly IBitShiftOperations _bitShiftOperations = new BitShiftOperations();

    [TestMethod]
    public void ArithmeticLeftShiftTest()
    {
        var result = _bitShiftOperations.ArithmeticLeftShift(1, 1);
        result.Should().Be(2.ToString());
    }

    [TestMethod]
    public void ArithmeticRightShiftTest()
    {
        var result = _bitShiftOperations.ArithmeticRightShift(2, 1);
        result.Should().Be(1.ToString());
    }

    [TestMethod]
    public void LogicalLeftShiftTest()
    {
        var result = _bitShiftOperations.LogicalLeftShift(10, 2);
        result.Should().Be(40.ToString());
    }

    [TestMethod]
    public void LogicalRightShiftTest()
    {
        var result = _bitShiftOperations.LogicalRightShift(10, 1);
        result.Should().Be(5.ToString());
    }

    [TestMethod]
    public void CircularLeftShiftTest()
    {
        var result = _bitShiftOperations.CircularLeftShift(1, 1);
        result.Should().Be(2.ToString());
    }

    [TestMethod]
    public void CircularRightShiftTest()
    {
        var result = _bitShiftOperations.CircularRightShift(2, 1);
        result.Should().Be(1.ToString());
    }
}