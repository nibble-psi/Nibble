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
using NibbleTools.ViewModels.BitsManipulation;
using NibbleTools.ViewModels.CryptographySecurity;
using NibbleTools.ViewModels.TextManipulation;
using NibbleTools.Views;
using NibbleTools.Views.CryptographySecurity;
using NibbleTools.Views.TextManipulation;

namespace NibbleTools.Configuration;

public static class ServicesExtensions
{
    public static IHostBuilder ConfigureServices(this IHostBuilder builder) =>
        builder.ConfigureServices((context, services) =>
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
            services.AddTransient<MainPage, MainViewModel>();
            services.AddTransient<ShellPage, ShellViewModel>();
            services.AddTransient<SettingsPage, SettingsViewModel>();

            services.AddTransient<BitShiftPage, BitShiftViewModel>();
            services.AddTransient<BitwisePage, BitwiseViewModel>();

            services.AddTransient<BaseNumberConverterPage, BaseNumberConverterModel>();
            services.AddTransient<UnitConverterPage, UnitConverterViewModel>();

            services.AddTransient<NumberGeneratorPage, NumberGeneratorViewModel>();
            services.AddTransient<StringGeneratorPage, StringGeneratorViewModel>();

            services.AddTransient<CounterPage, CounterViewModel>();
            services.AddTransient<TextSplitPage, TextSplitViewModel>();
            services.AddTransient<SymbolsReplacePage, SymbolsReplaceViewModel>();
            services.AddTransient<LinesSorterPage, LinesSorterViewModel>();
            services.AddTransient<LetterCasesPage, LetterCasesViewModel>();


            services.AddTransient<UuidGeneratorPage, UuidGeneratorViewModel>();
            services.AddTransient<HashCodeGeneratorPage, HashCodeGeneratorViewModel>();
        });

    public static IServiceCollection AddTransient<TPage, TViewModel>(this IServiceCollection services)
        where TPage : Page
        where TViewModel : ObservableObject =>
        services.AddTransient(typeof(TViewModel))
                .AddTransient(typeof(TPage));
}