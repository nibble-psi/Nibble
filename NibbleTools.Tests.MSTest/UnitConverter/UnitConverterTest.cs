using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;
using NibbleTools.Views;

namespace NibbleTools.Tests.MSTest.UnitConverter;

[TestClass]
public class UnitConverterTest
{

    [TestMethod]
    public void TestConvert_MetersToKilometers_ConvertsCorrectly()
    {
        var viewModel = new UnitConverterViewModel();
        viewModel.From = "m";
        viewModel.To = "km";
        viewModel.Input = 1000;

        viewModel.Convert();

        Assert.AreEqual(1, viewModel.Result);
    }

    [TestMethod]
    public void TestConvert_KilometersToMeters_ConvertsCorrectly()
    {
        var viewModel = new UnitConverterViewModel();
        viewModel.From = "km";
        viewModel.To = "m";
        viewModel.Input = 1;

        viewModel.Convert();

        Assert.AreEqual(1000, viewModel.Result);
    }

    [TestMethod]
    public void TestConvert_MetersToCentimeters_ConvertsCorrectly()
    {
        var viewModel = new UnitConverterViewModel();
        viewModel.From = "m";
        viewModel.To = "cm";
        viewModel.Input = 1;

        viewModel.Convert();

        Assert.AreEqual(100, viewModel.Result);
    }

    [TestMethod]
    public void TestConvert_CentimetersToMeters_ConvertsCorrectly()
    {
        var viewModel = new UnitConverterViewModel();
        viewModel.From = "cm";
        viewModel.To = "m";
        viewModel.Input = 100;

        viewModel.Convert();

        Assert.AreEqual(1, viewModel.Result);
    }

    [TestMethod]
    public void TestConvert_CentimetersToKilometers_ConvertsCorrectly()
    {
        var viewModel = new UnitConverterViewModel();
        viewModel.From = "cm";
        viewModel.To = "km";
        viewModel.Input = 1000;

        viewModel.Convert();

        Assert.AreEqual(0.01, viewModel.Result);
    }

    [TestMethod]
    public void TestConvert_KilometersToCentimeters_ConvertsCorrectly()
    {
        var viewModel = new UnitConverterViewModel();
        viewModel.From = "km";
        viewModel.To = "cm";
        viewModel.Input = 0.01;

        viewModel.Convert();

        Assert.AreEqual(1000, viewModel.Result);
    }

}
