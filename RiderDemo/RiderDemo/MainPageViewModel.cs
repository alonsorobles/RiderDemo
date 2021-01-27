using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RiderDemo.Annotations;
using RiderDemo.Services;
using Xamarin.Forms;

namespace RiderDemo
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private IList<string> _dataList;

        public MainPageViewModel(IDataFetchService dataFetchService)
        {
            FetchCommand = new Command(() =>
            {
                DataList = dataFetchService.GetData("Test");
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command FetchCommand { get; }

        public IList<string> DataList
        {
            get => _dataList;
            set
            {
                if (Equals(value, _dataList)) return;
                _dataList = value;
                OnPropertyChanged();
            }
        }
    }
}