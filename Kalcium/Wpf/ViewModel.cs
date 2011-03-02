using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Kalcium.Wpf
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(params string[] properties)
        {
            foreach (var property in properties)
                PropertyChanged.Raise(property, this);
        }
    }
}
