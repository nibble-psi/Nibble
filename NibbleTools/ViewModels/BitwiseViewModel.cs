using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace NibbleTools.ViewModels;
public partial class BitwiseViewModel : ObservableObject
{
    [ObservableProperty]
    private int number = 0x00000000;
  

    public BitwiseViewModel()
    {

    }

    [RelayCommand]
    private void IncreseNumber()
    {
        Number++;
    }
}
