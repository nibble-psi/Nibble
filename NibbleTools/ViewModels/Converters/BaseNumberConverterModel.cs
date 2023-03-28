using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NibbleTools.ViewModels;

public partial class BaseNumberConverterModel : ObservableRecipient
{
    [ObservableProperty] private string _binaryValue = "";

    [ObservableProperty] private string _decimalValue = "";

    [ObservableProperty] private string _hexaValue = "";

    [ObservableProperty] private string _octaValue = "";


    partial void OnBinaryValueChanged(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !IsValidBinary(value))
        {
            ClearInputs();
            return;
        }

        BinaryValue = value;
        DecimalValue = BinaryToDecimal(value);
        OctaValue = BinaryToOcta(value);
        HexaValue = BinaryToHexa(value);
    }

    partial void OnDecimalValueChanged(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !IsValidDecimal(value))
        {
            ClearInputs();
            return;
        }

        BinaryValue = DecimalToBinary(value);
        DecimalValue = value;
        OctaValue = DecimalToOctal(value);
        HexaValue = DecimalToHexa(value);
    }

    partial void OnOctaValueChanged(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !IsValidOcta(value))
        {
            ClearInputs();
            return;
        }

        BinaryValue = OctalToBinary(value);
        DecimalValue = OctalToDecimal(value);
        OctaValue = value;
        HexaValue = OctalToHexa(value);
    }

    partial void OnHexaValueChanged(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !IsValidHex(value))
        {
            ClearInputs();
            return;
        }

        BinaryValue = HexaToBinary(value);
        DecimalValue = HexaToDecimal(value);
        OctaValue = HexaToOcta(value);
        HexaValue = value;
    }

    private void ClearInputs()
    {
        BinaryValue = "";
        DecimalValue = "";
        OctaValue = "";
        HexaValue = "";
    }


    public string BinaryToDecimal(string binaryValue) => Convert.ToInt32(binaryValue, 2).ToString();

    public string BinaryToOcta(string binaryValue)
    {
        var value = Convert.ToInt32(binaryValue, 2);
        return Convert.ToString(value, 8);
    }

    public string BinaryToHexa(string binaryValue)
    {
        var value = Convert.ToInt32(binaryValue, 2);
        return Convert.ToString(value, 16).ToUpper();
    }


    public string DecimalToBinary(string decimalValue)
    {
        var value = Convert.ToInt32(decimalValue, 10);
        return Convert.ToString(value, 2);
    }

    public string DecimalToOctal(string decimalValue)
    {
        var value = Convert.ToInt32(decimalValue, 10);
        return Convert.ToString(value, 8);
    }


    public string DecimalToHexa(string decimalValue)
    {
        var value = Convert.ToInt32(decimalValue, 10);
        return Convert.ToString(value, 16).ToUpper();
    }

    public string OctalToBinary(string octalValue)
    {
        var value = Convert.ToInt32(octalValue, 8);
        return Convert.ToString(value, 2);
    }

    public string OctalToDecimal(string octalValue)
    {
        var value = Convert.ToInt32(octalValue, 8);
        return Convert.ToString(value, 10);
    }

    public string OctalToHexa(string octalValue)
    {
        var value = Convert.ToInt32(octalValue, 8);
        return Convert.ToString(value, 16).ToUpper();
    }

    public string HexaToBinary(string hexValue)
    {
        var value = Convert.ToInt32(hexValue, 16);
        return Convert.ToString(value, 2);
    }

    public string HexaToDecimal(string hexValue)
    {
        var value = Convert.ToInt32(hexValue, 16);
        return Convert.ToString(value, 10);
    }

    public string HexaToOcta(string hexValue)
    {
        var value = Convert.ToInt32(hexValue, 16);
        return Convert.ToString(value, 8);
    }

    private bool IsValidBinary(string value) =>
        value.Length <= 31 && value.All(c => c is '0' or '1');

    private bool IsValidDecimal(string value) =>
        int.TryParse(value, out _);

    private bool IsValidOcta(string value) =>
        value.Length <= 9 &&
        Regex.IsMatch(value, "^[0-7]+$");

    private bool IsValidHex(string value) =>
        value.Length <= 7 &&
        value.ToUpper().All(ch => ch is >= '0' and <= '9' or >= 'A' and <= 'F');
}