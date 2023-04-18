using NibbleTools.Interfaces.Services;
using NibbleTools.Pages;
using NibbleTools.ViewModels;
using NibbleTools.ViewModels.BitsManipulation;
using NibbleTools.ViewModels.CryptographySecurity;
using NibbleTools.ViewModels.TextManipulation;
using NibbleTools.Views;
using NibbleTools.Views.CryptographySecurity;
using NibbleTools.Views.TextManipulation;

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
        pageService.Configure<UnitConverterViewModel, UnitConverterPage>();

        // Sequences generator pages
        pageService.Configure<NumberGeneratorViewModel, NumberGeneratorPage>();
        pageService.Configure<StringGeneratorViewModel, StringGeneratorPage>();


        // Text manipulation pages
        pageService.Configure<CounterViewModel, CounterPage>();
        pageService.Configure<TextSplitViewModel, TextSplitPage>();
        pageService.Configure<SymbolsReplaceViewModel, SymbolsReplacePage>();
        pageService.Configure<LinesSorterViewModel, LinesSorterPage>();
        pageService.Configure<LetterCasesViewModel, LetterCasesPage>();

        // Cryptography and security pages
        pageService.Configure<UuidGeneratorViewModel, UuidGeneratorPage>();
        pageService.Configure<HashCodeGeneratorViewModel, HashCodeGeneratorPage>();
        pageService.Configure<PasswordGeneratorViewModel, PasswordGeneratorPage>();
    }
}