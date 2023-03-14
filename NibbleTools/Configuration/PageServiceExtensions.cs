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
        pageService.Configure<BitShiftViewModel, BitShiftPage>();
        pageService.Configure<XORViewModel, XORPage>();
        pageService.Configure<ORViewModel, ORPage>();
        pageService.Configure<SettingsViewModel, SettingsPage>();
        pageService.Configure<NotOperationViewModel, NotOperationPage>();
        pageService.Configure<AndNandViewModel, AndNandPage>();
    }
}
