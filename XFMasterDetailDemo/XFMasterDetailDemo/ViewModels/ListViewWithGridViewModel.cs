using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XFMasterDetailDemo.ViewModels
{
    public class ListViewWithGridViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> _myObservableCollection;

        public ListViewWithGridViewModel()
        {
            MyObservableCollection = new ObservableCollection<string>(new List<string> { "abc", "xyz", "pqr", "aaa", "abc", "xyz", "pqr", "aaa", "abc", "xyz", "pqr", "aaa" });
        }

        public ObservableCollection<string> MyObservableCollection
        {
            get { return _myObservableCollection; }
            set
            {
                _myObservableCollection = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}