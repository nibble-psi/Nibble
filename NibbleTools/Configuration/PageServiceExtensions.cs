﻿using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.Interfaces.Services;
using NibbleTools.Pages;
using NibbleTools.Services;
using NibbleTools.ViewModels;
using NibbleTools.Views;

namespace NibbleTools.Configuration;

public static class PageServiceExtensions
{
    public static void ConfigurePages(this IPageService pageService)
    {
        pageService.Configure<MainViewModel, MainPage>();
        pageService.Configure<BitwiseViewModel, BitwisePage>();
        pageService.Configure<SettingsViewModel, SettingsPage>();
    }
}
