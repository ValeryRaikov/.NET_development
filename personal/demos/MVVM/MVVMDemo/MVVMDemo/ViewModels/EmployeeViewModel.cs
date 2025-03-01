using System.Collections.Generic;
using System.ComponentModel;
using MVVMDemo.Models;

namespace MVVMDemo.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Employee> _employeesList;

        public EmployeeService EmployeeService { get; }

        public List<Employee> EmployeesList
        {
            get { return _employeesList; }
            set 
            { 
                _employeesList = value;
                OnPropertyChanged("EmployeesList");
            }
        }

        public EmployeeViewModel()
        {
            EmployeeService = new EmployeeService();
            LoadData();
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadData()
        {
            EmployeesList = EmployeeService.GetAllEmployees();
        }
    }
}
