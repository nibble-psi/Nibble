using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NibbleTools.ViewModels;

public partial class CounterViewModel : ObservableRecipient
{
    [ObservableProperty] private string _input = string.Empty;

    [ObservableProperty] private int _lines;

    [ObservableProperty] private int _symbols;

    [ObservableProperty] private int _words;

    [RelayCommand]
    public void ButtonClick()
    {
        CountSymbols();
        CountWords();
        CountLines();
    }

    public void CountLines() => Lines = Input.Split('\n', '\r').Length;

    public void CountSymbols() => Symbols = Input.Length;

    public void CountWords()
    {
        Words = 0;
        var index = 0;
        
        while (index < Input.Length && char.IsWhiteSpace(Input[index]))
        {
            index++;
        }

        while (index < Input.Length)
        {
            while (index < Input.Length && !char.IsWhiteSpace(Input[index]))
            {
                index++;
            }

            Words++;
            
            while (index < Input.Length && char.IsWhiteSpace(Input[index]))
            {
                index++;
            }
        }
    }
}