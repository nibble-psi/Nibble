using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Security.Cryptography;

namespace NibbleTools.ViewModels;
public partial class HashCodeGeneratorViewModel : ObservableRecipient
{

    [ObservableProperty]
    private string _primaryValue = string.Empty;

    public static string valueToConvert = string.Empty;

    partial void OnPrimaryValueChanged(string value)
    {
        PrimaryValue = value;
        valueToConvert = value;
    }

    public static string ConvertToMD5()
    {
        using MD5 md5 = MD5.Create();
        return BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(valueToConvert))).Replace("-", "");
    }

    public static string ConvertToSHA1()
    {
        var data = Encoding.ASCII.GetBytes(valueToConvert);
        var hashData = new SHA1Managed().ComputeHash(data);
        var hash = string.Empty;
        foreach (var b in hashData)
        {
            hash += b.ToString("X2");
        }
        return hash;
    }

    public static string ConvertToSHA256()
    {
        var hash = String.Empty;

        // Initialize a SHA256 hash object
        using (SHA256 sha256 = SHA256.Create())
        {
            // Compute the hash of the given string
            var hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(valueToConvert));

            // Convert the byte array to string format
            foreach (var b in hashValue)
            {
                hash += $"{b:X2}";
            }
        }
        return hash;
    }

}
