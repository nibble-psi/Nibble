using FluentAssertions;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.BitsOperations;

namespace NibbleTools.Tests.MSTest.BitsManipulation;

[TestClass]
public class BitwiseTest
{
    private readonly INumberBitwiseOperations<long> _bitwiseOperations;

    public BitwiseTest()
    {
        _bitwiseOperations = new NumberBitwiseOperations<long>();
    }

    [TestMethod]
    public void BitwiseAndTest()
    {
        var result = _bitwiseOperations.And(1, 1);
        result.Should().Be(1);
    }

    [TestMethod]
    public void BitwiseOrTest()
    {
        var result = _bitwiseOperations.Or(1, 1);
        result.Should().Be(1);
    }

    [TestMethod]
    public void BitwiseXorTest()
    {
        var result = _bitwiseOperations.Xor(1, 1);
        result.Should().Be(0);
    }

    [TestMethod]
    public void BitwiseNotTest()
    {
        var result = _bitwiseOperations.Not(1);
        result.Should().Be((-2));
    }

    [TestMethod]
    public void BitwiseNandTest()
    {
        var result = _bitwiseOperations.Nand(1, 1);
        result.Should().Be((-2));
    }

    [TestMethod]
    public void BitwiseNorTest()
    {
        var result = _bitwiseOperations.Nor(1, 1);
        result.Should().Be((-2));
    }
}