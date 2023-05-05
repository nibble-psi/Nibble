using NibbleTools.ViewModels.TextManipulation;

namespace NibbleTools.Tests.MSTest.TextManipulation;

[TestClass]
public class SymbolsReplaceViewModelTests
{
    [TestMethod]
    public void ReplaceCharactersNull()
    {
        // Arrange
        var viewModel = new SymbolsReplaceViewModel
        {
            ReplaceFrom = "a",
            ReplaceTo = "b",
            Input = null
        };

        // Act
        viewModel.Replace();

        // Assert
        Assert.AreEqual("", viewModel.Output);
    }

    [TestMethod]
    public void ReplaceCharacters()
    {
        // Arrange
        var viewModel = new SymbolsReplaceViewModel
        {
            ReplaceFrom = "a",
            ReplaceTo = "b",
            Input = "abc"
        };

        // Act
        viewModel.Replace();

        // Assert
        Assert.AreEqual("bbc", viewModel.Output);
    }
}