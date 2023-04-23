namespace NibbleTools.Interfaces.Services;

public interface ILocalizationSelectorService
{
    string PrimaryLanguage
    {
        get;
    }

    IReadOnlyList<string> ManifestLanguages
    {
        get;
    }

    Task InitializeAsync();

    Task SetLocalizationAsync(string language);

    Task SetRequestedLocalizationAsync();
}