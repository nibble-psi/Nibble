using FluentAssertions;
using NibbleTools.ViewModels;

namespace NibbleTools.Tests.MSTest;

[TestClass]
public class BaseConvertersTest
{
    private readonly BaseNumberConverterModel _baseNumberConverter = new();

    // Binary conversion tests
    [TestMethod]
    public void BinaryToDecimalTest()
    {
        var result = _baseNumberConverter.BinaryToDecimal(101.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.BinaryToDecimal(10101010.ToString());
        result1.Should().Be(170.ToString());
    }

    [TestMethod]
    public void BinaryToOctaTest()
    {
        var result = _baseNumberConverter.BinaryToOcta(101.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.BinaryToOcta(10101010.ToString());
        result1.Should().Be(252.ToString());
    }

    [TestMethod]
    public void BinaryToHexaTest()
    {
        var result = _baseNumberConverter.BinaryToHexa(101.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.BinaryToHexa(10101010.ToString());
        result1.Should().Be("AA");
    }


    // Decimal conversion tests
    [TestMethod]
    public void DecimalToBinaryTest()
    {
        var result = _baseNumberConverter.DecimalToBinary(5.ToString());
        result.Should().Be(101.ToString());

        var result1 = _baseNumberConverter.DecimalToBinary(1000.ToString());
        result1.Should().Be(1111101000.ToString());
    }

    [TestMethod]
    public void DecimalToOctalTest()
    {
        var result = _baseNumberConverter.DecimalToOctal(5.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.DecimalToOctal(1000.ToString());
        result1.Should().Be(1750.ToString());
    }

    [TestMethod]
    public void DecimalToHexaTest()
    {
        var result = _baseNumberConverter.DecimalToHexa(5.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.DecimalToHexa(1000.ToString());
        result1.Should().Be("3E8");
    }


    // Hexadecimal conversion tests
    [TestMethod]
    public void HexaToDecimalTest()
    {
        var result = _baseNumberConverter.HexaToDecimal(5.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.HexaToDecimal("3E8");
        result1.Should().Be(1000.ToString());
    }

    [TestMethod]
    public void HexaToBinaryTest()
    {
        var result = _baseNumberConverter.HexaToBinary(5.ToString());
        result.Should().Be(101.ToString());

        var result1 = _baseNumberConverter.HexaToBinary("3E8");
        result1.Should().Be(1111101000.ToString());
    }

    [TestMethod]
    public void HexaToOctalTest()
    {
        var result = _baseNumberConverter.HexaToOcta(5.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.HexaToOcta("3E8");
        result1.Should().Be(1750.ToString());
    }


    // Octal conversion tests
    [TestMethod]
    public void OctalToBinaryTest()
    {
        var result = _baseNumberConverter.OctalToBinary(5.ToString());
        result.Should().Be(101.ToString());

        var result1 = _baseNumberConverter.OctalToBinary(1000.ToString());
        result1.Should().Be(1000000000.ToString());
    }

    [TestMethod]
    public void OctalToDecimalTest()
    {
        var result = _baseNumberConverter.OctalToDecimal(5.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.OctalToDecimal(1000.ToString());
        result1.Should().Be(512.ToString());
    }

    [TestMethod]
    public void OctalToHexaTest()
    {
        var result = _baseNumberConverter.OctalToHexa(5.ToString());
        result.Should().Be(5.ToString());

        var result1 = _baseNumberConverter.OctalToHexa(7000.ToString());
        result1.Should().Be("E00");
    }
}