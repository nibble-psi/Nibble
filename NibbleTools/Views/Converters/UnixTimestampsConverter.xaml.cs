using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class UnixTimestampsConverterPage : Page
{
    public UnixTimestampsConverterPage()
    {
        ViewModel = App.GetService<UnixTimestampsConverterViewModel>();
        DataContext = ViewModel;

        InitializeComponent();
    }

    public UnixTimestampsConverterViewModel ViewModel
    {
        get;
        set;
    }

    public void ConvertUNIX_Click(object sender, RoutedEventArgs e)
    {
        if (!long.TryParse(UnixTimestampTextBox.Text, out var seconds))
        {
            return;
        }

        var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(seconds);

        YearTextBlock.Text = dateTimeOffset.Year.ToString();
        MonthTextBlock.Text = dateTimeOffset.Month.ToString();
        DayTextBlock.Text = dateTimeOffset.Day.ToString();
        HourTextBlock.Text = dateTimeOffset.Hour.ToString();
        MinuteTextBlock.Text = dateTimeOffset.Minute.ToString();
        SecondTextBlock.Text = dateTimeOffset.Second.ToString();
    }
}