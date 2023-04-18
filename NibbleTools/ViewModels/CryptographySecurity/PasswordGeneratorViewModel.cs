using System;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NibbleTools.Helpers;

namespace NibbleTools.ViewModels.CryptographySecurity;

public partial class PasswordGeneratorViewModel : ObservableRecipient
{
    [ObservableProperty] private string _pw = string.Empty;

    [ObservableProperty] private bool _isUpperCase;

    [ObservableProperty] private int _length;

    [ObservableProperty] private bool _isNumber;

    [RelayCommand]
    public void CreatePassword()
    {
        const string valid = "abcdefghijklmnopqrstuvwxyz";
        const string valid1 = "abcdefghijklmnopqrstuvwxyz1234567890";
        const string validA = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string valid1A = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        StringBuilder res = new StringBuilder();
        Random rnd = new Random();
        int count = Length;
        while (0 < count--)
        {
            if (IsNumber && IsUpperCase)
            {
                res.Append(valid1A[rnd.Next(valid1A.Length)]);
            }
            if (IsNumber && !IsUpperCase)
            {
                res.Append(valid1[rnd.Next(valid1.Length)]);
            }
            if (IsUpperCase && !IsNumber)
            {
                res.Append(validA[rnd.Next(validA.Length)]);
            }
            if (!IsUpperCase && !IsNumber)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
        }
        Pw = res.ToString();
    }

    //[RelayCommand]
    //public void GenerateUuid()
    //{
    //    var uuids = new string[Count];

    //    for (var i = 0; i < Count; i++)
    //    {
    //        var value = Guid.NewGuid().ToString();

    //        if (IsUpperCase)
    //            value = value.ToUpper();

    //        uuids[i] = value;
    //    }

    //    Uuid = string.Join(Separator + StringExtensions.NewLine, uuids);
    //}
}