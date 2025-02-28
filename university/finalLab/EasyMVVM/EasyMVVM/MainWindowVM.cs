using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace EasyMVVM
{
    public class MainWindowVM : DependencyObject, INotifyPropertyChanged
    {
        //This event will be fired to notify any listeners of a change in a property value.
        public event PropertyChangedEventHandler PropertyChanged;

        //set up a private class varialbe that holds the value of the _Backing Property
        private ObservableCollection<string> _BackingProperty;

        //This is the publically viewable Property for this class
        public ObservableCollection<string> BoundProperty
        {
            get { return _BackingProperty; }
            set { _BackingProperty = value; PropChanged("BoundProperty"); }
        }

        public MainWindowVM()
        {
            Model m = new Model();
            BoundProperty = m.GetData();
        }

        //Tell WPF Binding that this property value has changed
        public void PropChanged(string propertyName)
        {
            //Did WPF registerd to listen to this event
            //Tell WPF that this property changed
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
