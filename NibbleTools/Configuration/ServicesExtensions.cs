using System.Diagnostics.CodeAnalysis;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.Activation;
using NibbleTools.Core.Services;
using NibbleTools.Interfaces.Services;
using NibbleTools.Models;
using NibbleTools.Pages;
using NibbleTools.Services;
using NibbleTools.ViewModels;
using NibbleTools.Views;

namespace NibbleTools.Configuration;
public static class ServicesExtensions
{
    public static IHostBuilder ConfigureServices(this IHostBuilder builder)
    {
        return builder.ConfigureServices((context, services) =>
        {
            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Services
            services.AddSingleton<ILocalSettingsService, LocalSettingsService>();
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddTransient<INavigationViewService, NavigationViewService>();
            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Core Services
            services.AddSingleton<IFileService, FileService>();

            // Configuration
            services.Configure<LocalSettingsOptions>(context.Configuration.GetSection(nameof(LocalSettingsOptions)));

            // Views and ViewModels
            services.AddTransient<ShellPage,  ShellViewModel>();
            services.AddTransient<BitwisePage, BitwiseViewModel>();
            services.AddTransient<NotOperationPage, NotOperationViewModel>();
            services.AddTransient<XORPage, XORViewModel>();
            services.AddTransient<ORPage, ORViewModel>();
            services.AddTransient<SettingsPage, SettingsViewModel>();
            services.AddTransient<MainPage, MainViewModel>();

        });

    }

    public static IServiceCollection AddTransient<TPage, TViewModel>(this IServiceCollection services)
            where TPage : Page
            where TViewModel : ObservableObject
    {
        return services.AddTransient(typeof(TViewModel))
            .AddTransient(typeof(TPage));
    }
}
