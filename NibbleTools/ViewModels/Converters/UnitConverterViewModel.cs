using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NibbleTools.ViewModels;
public partial class UnitConverterViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string _convertFrom = string.Empty;

    [ObservableProperty]
    private string _convertTo = string.Empty;

    [ObservableProperty]
    private double _value = 0;

    [ObservableProperty]
    private double _result = 0;
}
