using System.Collections.ObjectModel;
using Livet;

namespace ListboxSandboxApp.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private ObservableCollection<ListBoxItemSampleViewModel> _listBoxItemSamples;

        public void Initialize()
        {
            ListBoxItemSamples =
                new ObservableCollection<ListBoxItemSampleViewModel>
                    {
                        new ListBoxItemSampleViewModel(
                            Properties.Resources.Win8.GetHbitmap().ToBitmapSource())
                            {Description = "Windows 8"},
                        new ListBoxItemSampleViewModel(
                            Properties.Resources.Win7.GetHbitmap().ToBitmapSource())
                            {Description = "Windows 7"},
                        new ListBoxItemSampleViewModel(
                            Properties.Resources.WinVista.GetHbitmap().ToBitmapSource())
                            {Description = "Windows Vista"},
                        new ListBoxItemSampleViewModel(
                            Properties.Resources.WinXP.GetHbitmap().ToBitmapSource())
                            {Description = "Windows XP"},
                            new ListBoxItemSampleViewModel(
                                Properties.Resources.Win98.GetHbitmap().ToBitmapSource())
                            {Description = "Windows 98"},
                        new ListBoxItemSampleViewModel(
                            Properties.Resources.Win95.GetHbitmap().ToBitmapSource())
                            {Description = "Windows 95"},
                        new ListBoxItemSampleViewModel(
                            Properties.Resources.WinNT.GetHbitmap().ToBitmapSource())
                            {Description = "Windows NT"},
                    };
        }

        public ObservableCollection<ListBoxItemSampleViewModel> ListBoxItemSamples
        {
            get { return _listBoxItemSamples; }
            set
            {
                if (Equals(value, _listBoxItemSamples)) return;
                _listBoxItemSamples = value;
                RaisePropertyChanged("ListBoxItemSamples");
            }
        }
    }
}

