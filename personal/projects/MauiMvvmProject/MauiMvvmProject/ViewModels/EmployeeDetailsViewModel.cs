using System.ComponentModel;

namespace MauiMvvmProject.ViewModels
{
    public class EmployeeDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _id;
        private string _name;
        private string _email;
        private bool _isPartTimer;

        public string EmployeeId
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(EmployeeId));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public bool IsPartTimer
        {
            get { return _isPartTimer; }
            set
            {
                _isPartTimer = value;
                OnPropertyChanged(nameof(IsPartTimer));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
