using System.Diagnostics;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using NibbleTools.Configuration;
using NibbleTools.Interfaces.Services;
using UnhandledExceptionEventArgs = Microsoft.UI.Xaml.UnhandledExceptionEventArgs;

namespace NibbleTools;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        Host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
                        .UseContentRoot(AppContext.BaseDirectory)
                        .ConfigureServices()
                        .Build();

        UnhandledException += App_UnhandledException;
    }

    public IHost Host
    {
        get;
    }

    public static WindowEx MainWindow
    {
        get;
    } = new MainWindow();

    public static T GetService<T>()
        where T : class
    {
        if ((Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
        {
            throw new ArgumentException(
                $"{typeof(T)} needs to be registered in ConfigureServices within ConfigureServicesExtensions.cs.");
        }

        return service;
    }

    private void App_UnhandledException(object sender, UnhandledExceptionEventArgs e) => Debug.WriteLine(e.Exception);

    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);
        await GetService<IActivationService>().ActivateAsync(args);
    }
}