using System.Text.RegularExpressions;
using FluentAssertions;
using NibbleTools.ViewModels.CryptographySecurity;

namespace NibbleTools.Tests.MSTest;

[TestClass]
public class PasswordGeneratorTest
{
    //Tests for password with only lowercase letters
    [TestMethod]
    public void TestCreatePassword_LowerCaseOnly()
    {
        var viewModel = new PasswordGeneratorViewModel();

        viewModel.Length = 20;
        viewModel.IsNumber = false;
        viewModel.IsUpperCase = false;

        viewModel.CreatePassword();

        var password = viewModel.Pw;

        Assert.AreEqual(20, password.Length);

        bool hasUppercase = false;
        bool hasNumber = false;

        foreach (char c in password)
        {
            if (Char.IsUpper(c))
            {
                hasUppercase = true;
            }

            if (Char.IsNumber(c))
            {
                hasNumber = true;
            }
        }

        Assert.IsFalse(hasUppercase);
        Assert.IsFalse(hasNumber);
    }

    //Tests for password with lowercase letters and numbers
    [TestMethod]
    public void TestCreatePassword_NumberLowerCase()
    {
        var viewModel = new PasswordGeneratorViewModel();

        viewModel.Length = 20;
        viewModel.IsNumber = true;
        viewModel.IsUpperCase = false;

        viewModel.CreatePassword();

        var password = viewModel.Pw;

        Assert.AreEqual(20, password.Length);

        bool hasUppercase = false;
        bool hasNumber = false;

        foreach (char c in password)
        {
            if (Char.IsUpper(c))
            {
                hasUppercase = true;
            }

            if (Char.IsNumber(c))
            {
                hasNumber = true;
            }
        }

        Assert.IsFalse(hasUppercase);
        Assert.IsTrue(hasNumber);
    }

    //Tests for password with lowercase letters and uppercase letters
    [TestMethod]
    public void TestCreatePassword_LowerUpperCase()
    {
        var viewModel = new PasswordGeneratorViewModel();

        viewModel.Length = 20;
        viewModel.IsNumber = false;
        viewModel.IsUpperCase = true;

        viewModel.CreatePassword();

        var password = viewModel.Pw;

        Assert.AreEqual(20, password.Length);

        bool hasUppercase = false;
        bool hasNumber = false;

        foreach (char c in password)
        {
            if (Char.IsUpper(c))
            {
                hasUppercase = true;
            }

            if (Char.IsNumber(c))
            {
                hasNumber = true;
            }
        }

        Assert.IsTrue(hasUppercase);
        Assert.IsFalse(hasNumber);
    }

    //Tests for password with lowercase, uppercase letters and numbers
    [TestMethod]
    public void TestCreatePassword_LowerUpperCaseNumber()
    {
        var viewModel = new PasswordGeneratorViewModel();

        viewModel.Length = 20;
        viewModel.IsNumber = true;
        viewModel.IsUpperCase = true;

        viewModel.CreatePassword();

        var password = viewModel.Pw;

        Assert.AreEqual(20, password.Length);

        bool hasUppercase = false;
        bool hasNumber = false;

        foreach (char c in password)
        {
            if (Char.IsUpper(c))
            {
                hasUppercase = true;
            }

            if (Char.IsNumber(c))
            {
                hasNumber = true;
            }
        }

        Assert.IsTrue(hasUppercase);
        Assert.IsTrue(hasNumber);
    }
}
