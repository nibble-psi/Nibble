using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NibbleTools.Helpers;

namespace NibbleTools.ViewModels.CryptographySecurity;

public partial class UuidGeneratorViewModel : ObservableRecipient
{
    [ObservableProperty] private int _count = 1;

    [ObservableProperty] private bool _isUpperCase;

    [ObservableProperty] private string _separator = string.Empty;
    
    [ObservableProperty] private string _uuid = string.Empty;

    [RelayCommand]
    public void GenerateUuid()
    {
        var uuids = new string[Count];

        for (var i = 0; i < Count; i++)
        {
            var value = Guid.NewGuid().ToString();

            if (IsUpperCase)
            {
                value = value.ToUpper();
            }

            uuids[i] = value;
        }

        Uuid = string.Join(Separator + StringExtensions.NewLine, uuids);
    }
}