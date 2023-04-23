using System.Reflection;
using Windows.ApplicationModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.Services;
using AppInstance = Microsoft.Windows.AppLifecycle.AppInstance;

namespace NibbleTools.ViewModels;

public partial class SettingsViewModel : ObservableRecipient
{
    private readonly IThemeSelectorService _themeSelectorService;
    private readonly ILocalizationSelectorService _localizationSelectorService;

    private ElementTheme _currentTheme;
    private int _themeIndex;

    [ObservableProperty] private string _versionDescription = string.Empty;

    [ObservableProperty] private IReadOnlyList<string> _languages = new List<string>();
    
    [ObservableProperty] private string _selectedLanguage = string.Empty;


    public SettingsViewModel(IThemeSelectorService themeSelectorService, ILocalizationSelectorService localizationSelectorService)
    {
        _themeSelectorService = themeSelectorService;
        _localizationSelectorService = localizationSelectorService;

        VersionDescription = GetVersionDescription();
        Languages = _localizationSelectorService.ManifestLanguages;
        SelectedLanguage = _localizationSelectorService.PrimaryLanguage;
        
        ThemeIndex = (int)_themeSelectorService.Theme;
    }

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

    /*partial void OnSelectedLanguageChanged(string value)
    { 
        SwitchLanguageCommand.Execute(value);
    }*/

    
    [RelayCommand]
    private async Task SwitchLanguage(string language)
    {
        if (_localizationSelectorService.PrimaryLanguage == language)
        {
            return;
        }

        await _localizationSelectorService.SetLocalizationAsync(language);
    }

    private static string GetVersionDescription()
    {
        Version version;

        if (RuntimeHelper.IsMSIX)
        {
            var packageVersion = Package.Current.Id.Version;

            version = new Version(packageVersion.Major, packageVersion.Minor, packageVersion.Build,
                packageVersion.Revision);
        }
        else
        {
            version = Assembly.GetExecutingAssembly().GetName().Version!;
        }

        return
            $"{"AppDisplayName".GetLocalized()} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
    }
}