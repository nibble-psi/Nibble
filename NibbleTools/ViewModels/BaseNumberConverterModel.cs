using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json.Linq;
using NibbleTools.Helpers;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace NibbleTools.ViewModels;
public partial class BaseNumberConverterModel : ObservableRecipient
{
    [ObservableProperty]
    private string _binaryValue = "";

    [ObservableProperty]
    private string _decimalValue = "";

    [ObservableProperty]
    private string _octaValue = "";

    [ObservableProperty]
    private string _hexaValue = "";


    public BaseNumberConverterModel()
    {

    }


    partial void OnBinaryValueChanged(string value)
    {
        if (!IsValidBinary(value))
        {
            BinaryValue = "";
            return;
        }

        BinaryValue = value;
        DecimalValue = BinaryToDecimal(value.ToString());
        OctaValue = BinaryToOcta(value.ToString());
        HexaValue = BinaryToHexa(value.ToString());
    }

    partial void OnDecimalValueChanged(string value)
    {
        if (!IsValidDecimal(value))
        {
            DecimalValue = "";
            return;
        }

        BinaryValue = DecimalToBinary(value.ToString());
        DecimalValue = value;
        OctaValue = DecimalToOctal(value.ToString());
        HexaValue = DecimalToHexa(value.ToString());
    }

    partial void OnOctaValueChanged(string value)
    {
        if (!IsValidOcta(value))
        {
            OctaValue = "";
            return;
        }

        BinaryValue = OctalToBinary(value.ToString());
        DecimalValue = OctalToDecimal(value.ToString());
        OctaValue = value;
        HexaValue = OctalToHexa(value.ToString());
    }

    partial void OnHexaValueChanged(string value)
    {
        if (!IsValidHexa(value))
        {
            HexaValue = "";
            return;
        }

        BinaryValue = HexaToBinary(value.ToString());
        DecimalValue = HexaToDecimal(value.ToString());
        OctaValue = HexaToOcta(value.ToString());
        HexaValue = value;
    }


    // BINARY TO ...

    public string BinaryToDecimal(string binaryValue)
    {
        var decimalValue = 0;
        // initializing base1 value to 1, i.e 2^0 
        var base1 = 1;
        int binary = Convert.ToInt32(binaryValue);

        while (binary > 0)
        {
            var reminder = binary % 10;
            binary /= 10;
            decimalValue += reminder * base1;
            base1 *= 2;
        }
        return decimalValue.ToString();
    }

    public string BinaryToOcta(string binaryValue)
    {
        int convertnumber = Convert.ToInt32(binaryValue, 2);
        return (Convert.ToString(convertnumber, 8));
    }

    static IDictionary<string, char>
    createMap(IDictionary<string, char> um)
    {
        um.Add("0000", '0');
        um.Add("0001", '1');
        um.Add("0010", '2');
        um.Add("0011", '3');
        um.Add("0100", '4');
        um.Add("0101", '5');
        um.Add("0110", '6');
        um.Add("0111", '7');
        um.Add("1000", '8');
        um.Add("1001", '9');
        um.Add("1010", 'A');
        um.Add("1011", 'B');
        um.Add("1100", 'C');
        um.Add("1101", 'D');
        um.Add("1110", 'E');
        um.Add("1111", 'F');
        return um;
    }

    public string BinaryToHexa(string binaryValue)
    {
        int i;
        var l = binaryValue.Length;
        var t = binaryValue.IndexOf('.');

        // Length of string before '.'
        var len_left = t != -1 ? t : l;

        // Add min 0's in the beginning to make
        // left substring length divisible by 4
        for (i = 1; i <= (4 - len_left % 4) % 4; i++)
            binaryValue = '0' + binaryValue;

        // If decimal point exists
        if (t != -1)
        {

            // Length of string after '.'
            int len_right = l - len_left - 1;

            // Add min 0's in the end to make right
            // substring length divisible by 4
            for (i = 1; i <= (4 - len_right % 4) % 4; i++)
                binaryValue = binaryValue + '0';
        }

        // Create map between binary and its
        // equivalent hex code
        IDictionary<string, char> bin_hex_map
            = new Dictionary<string, char>();

        bin_hex_map = createMap(bin_hex_map);

        i = 0;
        var hex = "";

        while (true)
        {

            // One by one extract from left, substring
            // of size 4 and add its hex code

            hex += bin_hex_map[binaryValue.Substring(i, 4)];
            i += 4;

            if (i == binaryValue.Length)
                break;

            // If '.' is encountered add it
            // to result
            if (binaryValue[i] == '.')
            {
                hex += '.';
                i++;
            }
        }

        // Required hexadecimal number
        return hex;
    }



    // DECIMAL TO ...

    public string DecimalToBinary(string decimalValue)
    {
        var num = Convert.ToInt32(decimalValue);
        var result = "";
        while (num > 1)
        {
            var remainder = num % 2;
            result = Convert.ToString(remainder) + result;
            num /= 2;
        }
        return Convert.ToString(num) + result;
    }

    public string DecimalToOctal(string decimalValue)
    {
        int decVal, quot, i = 1, j;
        int[] octalVal = new int[80];
        decVal = int.Parse(decimalValue);
        quot = decVal;
        
        while (quot != 0)
        {
            octalVal[i++] = quot % 8;
            quot = quot / 8;
        }

        string result = "";
        for (j = i - 1; j > 0; j--)
            result += octalVal[j];
        
        return result;
    }


    public string DecimalToHexa(string decimalValue)
    {
        StringBuilder builder = new StringBuilder();
        int remainder;
        int d = Convert.ToInt32(decimalValue);
        while (d != 0)
        {
            remainder = d % 16;
            d /= 16;
            builder.Insert(0, ToHexadecimalChar(remainder));
        }

        return builder.ToString();
    }

    static string ToHexadecimalChar(int d)
    {
        switch (d)
        {
            case 0:
                return "0";
            case 1:
                return "1";
            case 2:
                return "2";
            case 3:
                return "3";
            case 4:
                return "4";
            case 5:
                return "5";
            case 6:
                return "6";
            case 7:
                return "7";
            case 8:
                return "8";
            case 9:
                return "9";
            case 10:
                return "A";
            case 11:
                return "B";
            case 12:
                return "C";
            case 13:
                return "D";
            case 14:
                return "E";
            case 15:
                return "F";
            default:
                return "";
        }
    }



    //  OCTAL TO ...

    public string OctalToBinary(string octalValue)
    {
        int i = 0;
        string binary = "";
        while (i < octalValue.Length)
        {
            char c = octalValue[i];
            switch (c)
            {
                case '0':
                    binary += "000";
                    break;
                case '1':
                    binary += "001";
                    break;
                case '2':
                    binary += "010";
                    break;
                case '3':
                    binary += "011";
                    break;
                case '4':
                    binary += "100";
                    break;
                case '5':
                    binary += "101";
                    break;
                case '6':
                    binary += "110";
                    break;
                case '7':
                    binary += "111";
                    break;
                default:
                    break;
            }
            i++;
        }
        return binary;
    }

    public string OctalToDecimal(string octalValue)
    {
        int Decimal_Number = 0;
        int BASE = 1;
        int temp = Convert.ToInt32(octalValue);
        while (temp > 0)
        {
            int last_digit = temp % 10;
            temp /= 10;
            Decimal_Number += last_digit * BASE;
            BASE *= 8;
        }
        return Decimal_Number.ToString();
    }

    public string OctalToHexa(string octalValue)
    {
        int dec = int.Parse(OctalToDecimal(octalValue));
        return DecimalToHexa(dec.ToString());
    }


    // HEXAL TO ...

    public string HexaToBinary(string hexValue)
    {
        // Convert the hex string to decimal integer
        int decimalValue = Convert.ToInt32(hexValue, 16);

        // Convert the decimal value to binary string
        string result = Convert.ToString(decimalValue, 2);

        return result;
    }

    public string HexaToDecimal(string hexValue)
    {
        return int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber).ToString();
    }

    public string HexaToOcta(string hexValue)
    {
        int dec = 0;

        // taking 1AC as an example
        // of hexadecimal Number.
        int c = hexValue.Length - 1;

        // Finding the decimal
        // equivalent of the
        // hexa decimal number
        for (int i = 0; i < hexValue.Length; i++)
        {
            // Extracting each character
            // from the string.
            char ch = hexValue[i];
            switch (ch)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    dec = dec + Int32.Parse(ch.ToString()) *
                                           (int)Math.Pow(16, c);
                    c--;
                    break;
                case 'a':
                case 'A':
                    dec = dec + 10 * (int)Math.Pow(16, c);
                    c--;
                    break;
                case 'b':
                case 'B':
                    dec = dec + 11 * (int)Math.Pow(16, c);
                    c--;
                    break;
                case 'c':
                case 'C':
                    dec = dec + 12 * (int)Math.Pow(16, c);
                    c--;
                    break;
                case 'd':
                case 'D':
                    dec = dec + 13 * (int)Math.Pow(16, c);
                    c--;
                    break;
                case 'e':
                case 'E':
                    dec = dec + 14 * (int)Math.Pow(16, c);
                    c--;
                    break;
                case 'f':
                case 'F':
                    dec = dec + 15 * (int)Math.Pow(16, c);
                    c--;
                    break;
                default:
                    break;
            }
        }

        // String oct to store the octal
        // equivalent of a hexadecimal number.
        string oct = "";

        // converting decimal
        // to octal number.
        while (dec > 0)
        {
            oct = dec % 8 + oct;
            dec = dec / 8;
        }

        return oct;
    }


    // VALIDATIONS

    private bool IsValidBinary(string value)
    {
        bool status = false;
        if (value.Length > 10)
            return status;

        foreach (char c in value)
            if (c == '0' || c == '1')
                status = true;
            else 
                return false;

        return status;
    }

    private bool IsValidDecimal(string value)
    {
        bool status = int.TryParse(value, out int intValue);
        return status;
    }

    private bool IsValidOcta(string value)
    {
        return Regex.IsMatch(value, "^[0-7]+$");
    }

    private bool IsValidHexa(string value)
    {
        bool status = true;
        foreach (char c in value)
        {
            if (c == '0' || c == '1' || c == '2' || c == '3'
             || c == '4' || c == '5' || c == '6' || c == '7'
             || c == '8' || c == '9' || c == 'A' || c == 'B'
             || c == 'C' || c == 'D' || c == 'E' || c == 'F')
            {
                status = true;
            }
            else
            {
                return false;
            }
        }
        return status;
    }

}
