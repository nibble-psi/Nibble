using CommunityToolkit.Mvvm.ComponentModel;

namespace NibbleTools.ViewModels;

public partial class UnitConverterViewModel : ObservableRecipient
{
    [ObservableProperty] private string _convertFrom = string.Empty;

    [ObservableProperty] private string _convertTo = string.Empty;

    [ObservableProperty] private double _result;

    [ObservableProperty] private double _value;
}