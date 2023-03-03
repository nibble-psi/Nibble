using FluentAssertions;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Tests.MSTest;

[TestClass]
public class BitShiftTest
{
    private readonly IBitShiftOperations bitShiftOperations = new BitShiftOperations();

    [TestMethod]
    public void ArithmeticLeftShiftTest()
    {
        var result = bitShiftOperations.ArithmeticLeftShift(1, 1);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ArithmeticRightShiftTest()
    {
        var result = bitShiftOperations.ArithmeticRightShift(2, 1);
        result.Should().Be(1);
    }

    [TestMethod]
    public void LogicalLeftShiftTest()
    {
        var result = bitShiftOperations.LogicalLeftShift(10, 2);
        result.Should().Be(40);
    }

    [TestMethod]
    public void LogicalRightShiftTest()
    {
        var result = bitShiftOperations.LogicalRightShift(10, 1);
        result.Should().Be(5);
    }

    [TestMethod]
    public void CircularLeftShiftTest()
    {
        var result = bitShiftOperations.CircularLeftShift(1, 1);
        result.Should().Be(2);
    }

    [TestMethod]
    public void CircularRightShiftTest()
    {
        var result = bitShiftOperations.CircularRightShift(2, 1);
        result.Should().Be(1);
    }

}
