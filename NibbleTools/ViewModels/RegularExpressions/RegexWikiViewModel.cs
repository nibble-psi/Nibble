using System;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Windows.ApplicationModel.DataTransfer;

namespace NibbleTools.ViewModels
{
    public class RegexWikiViewModel : ObservableRecipient
    {
        private RelayCommand<string>? _copyCommand;

        public RelayCommand<string> CopyCommand => _copyCommand ??= new RelayCommand<string>(CopyToClipboard);

        public void CopyToClipboard(string pattern)
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(pattern);
            Clipboard.SetContent(dataPackage);

            Console.WriteLine($"Copied pattern: {pattern}");
        }
    }
}
