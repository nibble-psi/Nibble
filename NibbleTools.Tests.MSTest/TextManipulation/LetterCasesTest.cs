using NibbleTools.ViewModels;

namespace NibbleTools.Tests.MSTest.TextManipulation;

[TestClass]
public class LetterCasesViewModelTests
{
    [TestMethod]
    public void TestConvertToLowerCase()
    {
        // Arrange
        var input = "HeLLo WORld";
        var expectedOutput = "hello world";

        // Act
        var output = LetterCasesViewModel.ConvertToLowerCase(input);

        // Assert
        Assert.AreEqual(expectedOutput, output);
    }

    [TestMethod]
    public void TestConvertToUpperCase()
    {
        // Arrange
        var input = "HeLLo WORld";
        var expectedOutput = "HELLO WORLD";

        // Act
        var output = LetterCasesViewModel.ConvertToUpperCase(input);

        // Assert
        Assert.AreEqual(expectedOutput, output);
    }

    [TestMethod]
    public void TestConvertToCapitalizedCase()
    {
        // Arrange
        var input = "the quick brown fox jumps over the lazy dog.";
        var expectedOutput = "The Quick Brown Fox Jumps Over The Lazy Dog.";

        // Act
        var output = LetterCasesViewModel.ConvertToCapitalizedCase(input);

        // Assert
        Assert.AreEqual(expectedOutput, output);
    }
}