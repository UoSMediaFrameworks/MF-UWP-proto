using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF_UWP_proto.Helpers
{
/*This is written so we can have specific values being observed for changes*/
    public class ObservableProp<T> : INotifyPropertyChanged
    {
        private T _value;
        public T Value
        {
            get => _value;
            set { _value = value; NotifyPropertyChanged("Value"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            Debug.Write("Changed");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
