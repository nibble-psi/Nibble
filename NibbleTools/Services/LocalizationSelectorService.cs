using Windows.Globalization;
using NibbleTools.Interfaces.Services;

namespace NibbleTools.Services;

public class LocalizationSelectorService : ILocalizationSelectorService
{
    private const string SettingsKey = "AppLocalizationRequestedLanguage";


    private readonly ILocalSettingsService _localSettingsService;


    public LocalizationSelectorService(ILocalSettingsService localSettingsService)
    {
        _localSettingsService = localSettingsService;
    }


    public string PrimaryLanguage
    {
        get;
        private set;
    } = ApplicationLanguages.PrimaryLanguageOverride;


    public IReadOnlyList<string> ManifestLanguages => ApplicationLanguages.ManifestLanguages;


    public async Task InitializeAsync()
    {
        PrimaryLanguage = _localSettingsService.ReadSettingAsync<string>(SettingsKey).Result ?? PrimaryLanguage;
        await Task.CompletedTask;
    }

    public async Task SetLocalizationAsync(string language)
    {
        PrimaryLanguage = language;

        await SetRequestedLocalizationAsync();
        await SaveLocalizationInSettingsAsync(PrimaryLanguage);

        await Task.CompletedTask;
    }

    public async Task SetRequestedLocalizationAsync()
    {
        ApplicationLanguages.PrimaryLanguageOverride = PrimaryLanguage;

        await Task.CompletedTask;
    }

    private async Task SaveLocalizationInSettingsAsync(string language) =>
        await _localSettingsService.SaveSettingAsync(SettingsKey, language);
}