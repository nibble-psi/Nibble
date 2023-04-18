using System.Security.Cryptography;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NibbleTools.ViewModels;

public partial class HashCodeGeneratorViewModel : ObservableRecipient
{
    private static string _valueToConvert = string.Empty;

    [ObservableProperty] private string _primaryValue = string.Empty;

    partial void OnPrimaryValueChanged(string value)
    {
        PrimaryValue = value;
        _valueToConvert = value;
    }

    public static string ConvertToMd5()
    {
        return BitConverter.ToString(MD5.HashData(Encoding.UTF8.GetBytes(_valueToConvert))).Replace("-", "");
    }

    public static string ConvertToSha1()
    {
        var data = Encoding.ASCII.GetBytes(_valueToConvert);
        var hashData = SHA1.HashData(data);

        return hashData.Aggregate(string.Empty, (current, b) => current + b.ToString("X2"));
    }

    public static string ConvertToSha256()
    {
        var hash = string.Empty;
        var hashValue = SHA256.HashData(Encoding.UTF8.GetBytes(_valueToConvert));

        return hashValue.Aggregate(hash, (current, b) => current + $"{b:X2}");
    }
}