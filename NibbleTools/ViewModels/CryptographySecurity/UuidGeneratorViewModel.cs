using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NibbleTools.Helpers;

namespace NibbleTools.ViewModels.CryptographySecurity;

public partial class UuidGeneratorViewModel : ObservableRecipient
{
    [ObservableProperty] private string _uuid = string.Empty;

    [ObservableProperty] private int _count = 1;

    [RelayCommand]
    public void GenerateUuid()
    {
        var uuids = new string[Count];

        for (var i = 0; i < Count; i++)
        {
            uuids[i] = Guid.NewGuid().ToString();
        }

        Uuid = string.Join(StringExtensions.NewLine, uuids);
    }
}