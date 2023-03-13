using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NibbleTools.ViewModels;

public partial class NotOperationViewModel : ObservableObject
{
    //[ObservableProperty]
    //private int number = 0x00000000;


    //public NotOperationViewModel()
    //{

    //}

    //[RelayCommand]
    //private void IncreseNumber()
    //{
    //    Number++;
    //}


    //public int Not(int number)
    //{
    //    return ~number;
    //}

    [ObservableProperty]
    private uint _firstValue = 0;

    [ObservableProperty]
    private uint _result = 0;


    public NotOperationViewModel()
    {

    }

    partial void OnFirstValueChanged(uint value)
    {
        Result = Not(value);
    }


    public uint Not(uint number)
    {
        return ~number;
    }
}
