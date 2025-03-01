using System.ComponentModel;

namespace MVVMDemo.Models
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        private string _name;
        private int _age;

        public int Id
        {
            get { return _id; }
            set 
            { 
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return _age; }
            set 
            { 
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
