using NibbleTools.ViewModels;

namespace NibbleTools.Tests.MSTest.TextManipulation;

[TestClass]
public class TextSplitViewModelTests
{
    private TextSplitViewModel viewModel;

    [TestInitialize]
    public void Initialize()
    {
        viewModel = new TextSplitViewModel();
    }

    [TestMethod]
    public void SplitBySeperator_InputEmpty_OutputEmpty()
    {
        viewModel.Input = string.Empty;
        viewModel.Seperator = " ";
        viewModel.SplitBySeperator();

        Assert.AreEqual(string.Empty, viewModel.Output);
    }

    [TestMethod]
    public void SplitBySeperator_SeperatorEmpty_OutputEmpty()
    {
        viewModel.Input = "Hello World";
        viewModel.Seperator = string.Empty;
        viewModel.SplitBySeperator();

        Assert.AreEqual(string.Empty, viewModel.Output);
    }

    [TestMethod]
    public void SplitBySeperator_NoMatch_OutputSameAsInput()
    {
        viewModel.Input = "Hello World";
        viewModel.Seperator = ",";
        viewModel.SplitBySeperator();

        Assert.AreEqual("Hello World\n", viewModel.Output);
    }

    [TestMethod]
    public void SplitBySeperator_Match_OutputChunksSeparatedBySeperator()
    {
        viewModel.Input = "Hello,World";
        viewModel.Seperator = ",";
        viewModel.SplitBySeperator();

        Assert.AreEqual("Hello\nWorld\n", viewModel.Output);
    }

    [TestMethod]
    public void SplitByLength_InputEmpty_OutputEmpty()
    {
        viewModel.Input = string.Empty;
        viewModel.ButtonClick();

        Assert.AreEqual(string.Empty, viewModel.Output);
    }

    [TestMethod]
    public void SplitByLength_ChunkSizeLessThanInputLength_OutputSameAsInput()
    {
        viewModel.Input = "Hello World";
        viewModel.Seperator = " ";
        viewModel.ButtonClick();

        Assert.AreEqual("Hello\nWorld\n", viewModel.Output);
    }

    [TestMethod]
    public void SplitByLength_ChunkSizeGreaterThanInputLength_OutputSameAsInput()
    {
        viewModel.Input = "Hello World";
        viewModel.Seperator = " ";
        viewModel.ButtonClick();

        Assert.AreEqual("Hello\nWorld\n", viewModel.Output);
    }

    [TestMethod]
    public void SplitByLength_ChunkSizeExactlyInputLength_OutputSameAsInput()
    {
        viewModel.Input = "Hello World";
        viewModel.Seperator = " ";
        viewModel.ButtonClick();

        Assert.AreEqual("Hello\nWorld\n", viewModel.Output);
    }
}