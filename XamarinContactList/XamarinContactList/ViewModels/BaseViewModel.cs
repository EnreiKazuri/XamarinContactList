using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinContactList.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
