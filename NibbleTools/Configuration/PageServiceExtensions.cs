using NibbleTools.Interfaces.Services;
using NibbleTools.Pages;
using NibbleTools.ViewModels;
using NibbleTools.ViewModels.BitsManipulation;
using NibbleTools.ViewModels.CryptographySecurity;
using NibbleTools.Views;
using NibbleTools.Views.CryptographySecurity;

namespace NibbleTools.Configuration;

public static class PageServiceExtensions
{
    public static void ConfigurePages(this IPageService pageService)
    {
        // Main Pages
        pageService.Configure<MainViewModel, MainPage>();
        pageService.Configure<SettingsViewModel, SettingsPage>();

        // BitsManipulation pages
        pageService.Configure<BitShiftViewModel, BitShiftPage>();
        pageService.Configure<BitwiseViewModel, BitwisePage>();

        // Converters
        pageService.Configure<BaseNumberConverterModel, BaseNumberConverterPage>();

        // Sequences generator pages
        pageService.Configure<NumberGeneratorViewModel, NumberGeneratorPage>();
        pageService.Configure<StringGeneratorViewModel, StringGeneratorPage>();


        // Text manipulation pages
        pageService.Configure<CounterViewModel, CounterPage>();
        pageService.Configure<TextSplitViewModel, TextSplitPage>();

        // Cryptography and security pages
        pageService.Configure<UuidGeneratorViewModel, UuidGeneratorPage>();
    }
}