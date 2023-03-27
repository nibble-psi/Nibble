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

public partial class CounterViewModel : ObservableRecipient
{
    [ObservableProperty]
    private int _symbols = 0;

    [ObservableProperty]
    private int _words = 0;

    [ObservableProperty]
    private int _lines = 0;

    [ObservableProperty]
    private string _input = string.Empty;

    [RelayCommand]
    public void ButtonClick()
    {
        CountSymbols();
        CountWords();
        CountLines();
    }

    public void CountLines() { Lines = Input.Split(new[] { '\n', '\r' }).Length; }

    public void CountSymbols() {  Symbols = Input.Length; }
 
    public void CountWords()
    {
        Words = 0;
        int index = 0;

        // skip whitespace until first word
        while (index < Input.Length && char.IsWhiteSpace(Input[index]))
            index++;

        while (index < Input.Length)
        {
            // check if current char is part of a word
            while (index < Input.Length && !char.IsWhiteSpace(Input[index]))
                index++;

            Words++;

            // skip whitespace until next word
            while (index < Input.Length && char.IsWhiteSpace(Input[index]))
                index++;
        }
    }
}