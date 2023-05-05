using NibbleTools.ViewModels;

namespace NibbleTools.Tests.MSTest.TextManipulation;

[TestClass]
public class CounterTest
{
    [TestMethod]
    public void TestCountSymbols()
    {
        // Arrange
        var viewModel = new CounterViewModel();
        viewModel.Input = "Hello, world!";

        // Act
        viewModel.CountSymbols();

        // Assert
        Assert.AreEqual(13, viewModel.Symbols);
    }

    [TestMethod]
    public void TestCountWords()
    {
        // Arrange
        var viewModel = new CounterViewModel();
        viewModel.Input = "The quick brown fox jumps over the lazy dog.";

        // Act
        viewModel.CountWords();

        // Assert
        Assert.AreEqual(9, viewModel.Words);
    }

    [TestMethod]
    public void TestCountLines()
    {
        // Arrange
        var viewModel = new CounterViewModel();
        viewModel.Input = "Line 1\nLine 2\nLine 3\n";

        // Act
        viewModel.CountLines();

        // Assert
        Assert.AreEqual(4, viewModel.Lines);
    }
}