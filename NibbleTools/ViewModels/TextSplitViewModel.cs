using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json.Linq;
using NibbleTools.Helpers;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NibbleTools.ViewModels;

public partial class TextSplitViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string _input = string.Empty;

    [ObservableProperty]
    private string _output = string.Empty;

    [ObservableProperty]
    private string _seperator = string.Empty;

    [RelayCommand]
    public void ButtonClick()
    {
        var isNumeric = int.TryParse(Seperator, out int ChunkSize);

        if (isNumeric)
        {
            SplitByLength(ChunkSize);
        }
        else
        {
            SplitBySeperator();
        }
    }

    public void SplitBySeperator()
    {
        Output = string.Empty;
        if (Seperator != string.Empty && Input != string.Empty)
        {
            string[] chunks = Input.Split(Seperator);

            foreach (var chunk in chunks)
            {
                Output += chunk + "\n";
            }
        }
    }

    public void SplitByLength(int chunkSize)
    {
        Output = string.Empty;

        if (chunkSize >= 1 && Input != string.Empty)
        {
            for (int i = 0; i < Input.Length; i += chunkSize)
            {
                if ((i + chunkSize) < Input.Length)
                    Output += Input.Substring(i, chunkSize) + "\n";
                else
                    Output += Input.Substring(i);
            }
        }
    }
}