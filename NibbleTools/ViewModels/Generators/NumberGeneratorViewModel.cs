using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json.Linq;
using NibbleTools.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NibbleTools.ViewModels;

public partial class NumberGeneratorViewModel : ObservableRecipient
{
    [ObservableProperty]
    private int _minValue = 1;

    [ObservableProperty]
    private int _maxValue = 1;

    [ObservableProperty]
    private int _count = 1;

    [ObservableProperty]
    private string _number = string.Empty;

    [RelayCommand]
    public void ButtonClick()
    {
        if (MinValue > MaxValue)
            MinValue = MaxValue - 1;

        Number = string.Join(" ", GenerateNumbersArray());
    }

    public int[] GenerateNumbersArray()
    {
        Random rnd = new Random();
        int[] Numbers = new int[Count];
        for (int i = 0; i < Count; i++)
        {
            //Random rnd = new Random();
            int nr = rnd.Next(MinValue, MaxValue);
            Numbers[i] = nr;
        }
        return Numbers;
    }
}
