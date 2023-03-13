using FluentAssertions;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.NotOperation;

namespace NibbleTools.Tests.MSTest;

[TestClass]
public class NotOperationTest
{
    private readonly INotOperation notOperation = new NotOperation();

    [TestMethod]
    public void NotTest()
    {
        var result = notOperation.Not(9);
        Assert.AreEqual(-10, result);
    }
}
