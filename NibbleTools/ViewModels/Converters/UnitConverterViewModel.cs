using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NibbleTools.ViewModels;

public partial class UnitConverterViewModel : ObservableRecipient
{
    [ObservableProperty] private string _from = "m";

    [ObservableProperty] private string _to = "cm";

    [ObservableProperty] private double _input = 1;

    [ObservableProperty] private double _result = 0;

    private readonly Dictionary<(string, string), double> factors = new()
    {
        {("m", "km"), 0.001},
        {("m", "cm"), 100},
        {("km", "m"), 1000},
        {("km", "cm"), 100000},
        {("cm", "m"), 0.01},
        {("cm", "km"), 0.00001}
    };

    public void Convert()
    {
        if (!string.IsNullOrEmpty(From) && !string.IsNullOrEmpty(To) && factors.ContainsKey((From, To)))
        {
            var factor = factors[(From, To)];
            Result = (Input * factor);
        }
        else
        {
            Result = Input;
        }
    }

    [RelayCommand]
    public void ButtonClick()
    {
        Convert();
    }

}