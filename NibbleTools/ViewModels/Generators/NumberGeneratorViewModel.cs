using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NibbleTools.ViewModels;

public partial class NumberGeneratorViewModel : ObservableRecipient
{
    [ObservableProperty] private int _count = 1;

    [ObservableProperty] private int _maxValue = 1;

    [ObservableProperty] private int _minValue = 1;

    [ObservableProperty] private string _number = string.Empty;

    [RelayCommand]
    public void ButtonClick()
    {
        if (MinValue > MaxValue)
        {
            MinValue = MaxValue - 1;
        }

        Number = string.Join(" ", GenerateNumbersArray());
    }

    public int[] GenerateNumbersArray()
    {
        var rnd = new Random();
        var Numbers = new int[Count];
        for (var i = 0; i < Count; i++)
        {
            //Random rnd = new Random();
            var nr = rnd.Next(MinValue, MaxValue);
            Numbers[i] = nr;
        }

        return Numbers;
    }
}