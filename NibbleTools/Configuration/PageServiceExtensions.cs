using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.Interfaces.Services;
using NibbleTools.Pages;
using NibbleTools.Services;
using NibbleTools.ViewModels;
using NibbleTools.ViewModels.BitsManipulation;
using NibbleTools.Views;

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

        pageService.Configure<StringGeneratorViewModel, StringGeneratorPage>();
    }
}
