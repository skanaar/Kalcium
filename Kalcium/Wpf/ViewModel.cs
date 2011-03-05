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

        public void SetProperty<T>(string propertyName, ref T field, T value)
        {
            if (object.Equals(field, value)) return;

            field = value;
            RaisePropertyChanged(propertyName);
        }
    }
}
