using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using NibbleTools.Interfaces.Services;
using NibbleTools.Helpers;
using Windows.ApplicationModel;

namespace NibbleTools.ViewModels;

public partial class SettingsViewModel : ObservableRecipient
{
    private readonly IThemeSelectorService _themeSelectorService;
    private int _themeIndex;
    private ElementTheme _currentTheme;

    [ObservableProperty] private string _versionDescription = string.Empty;

    public string AppDescription => "AppDescription".GetLocalized();



    public int ThemeIndex
    {
        get => _themeIndex;
        set
        {
            if (_themeIndex == value)
            {
                return;
            }

            _themeIndex = value;
            SwitchThemeCommand.Execute((ElementTheme)value);
            OnPropertyChanged();
        }
    }


    public SettingsViewModel(IThemeSelectorService themeSelectorService)
    {
        _themeSelectorService = themeSelectorService;
        VersionDescription = GetVersionDescription();
        ThemeIndex = (int)_themeSelectorService.Theme;
    }

    [RelayCommand]
    private async Task SwitchTheme(ElementTheme theme)
    {
        if (_currentTheme == theme)
        {
            return;
        }

        _currentTheme = theme;
        await _themeSelectorService.SetThemeAsync(theme);
    }

    private static string GetVersionDescription()
    {
        Version version;

        if (RuntimeHelper.IsMSIX)
        {
            var packageVersion = Package.Current.Id.Version;

            version = new(packageVersion.Major, packageVersion.Minor, packageVersion.Build, packageVersion.Revision);
        }
        else
        {
            version = Assembly.GetExecutingAssembly().GetName().Version!;
        }

        return
            $"{"AppDisplayName".GetLocalized()} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
    }
}