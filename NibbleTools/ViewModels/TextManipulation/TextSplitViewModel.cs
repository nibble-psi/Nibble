using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NibbleTools.ViewModels;

public partial class TextSplitViewModel : ObservableRecipient
{
    [ObservableProperty] private string _input = string.Empty;

    [ObservableProperty] private string _output = string.Empty;

    [ObservableProperty] private string _seperator = string.Empty;

    [RelayCommand]
    public void ButtonClick()
    {
        var isNumeric = int.TryParse(Seperator, out var ChunkSize);

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

        if (Seperator == string.Empty || Input == string.Empty)
        {
            return;
        }

        var chunks = Input.Split(Seperator);

        foreach (var chunk in chunks)
        {
            Output += chunk + "\n";
        }
    }

    public void SplitByLength(int chunkSize)
    {
        Output = string.Empty;

        if (chunkSize < 1 || Input == string.Empty)
        {
            return;
        }

        for (var i = 0; i < Input.Length; i += chunkSize)
        {
            if (i + chunkSize < Input.Length)
            {
                Output += string.Concat(Input.AsSpan(i, chunkSize), "\n");
            }
            else
            {
                Output += Input[i..];
            }
        }
    }
}