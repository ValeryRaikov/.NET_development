using System.Collections.Generic;
using System.ComponentModel;
using MVVMDemo.Models;
using MVVMDemo.Commands;
using System;
using System.Collections.ObjectModel;

namespace MVVMDemo.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Employee> _employeesList;
        private Employee _currentEmployee;
        private CommandBase _saveCommand;
        private CommandBase _searchCommand;
        private CommandBase _updateCommand;
        private CommandBase _deleteCommand;
        private string _message;

        public EmployeeService EmployeeService { get; }

        public ObservableCollection<Employee> EmployeesList
        {
            get { return _employeesList; }
            set 
            { 
                _employeesList = value;
                OnPropertyChanged("EmployeesList");
            }
        }

        public Employee CurrentEmployee
        {
            get { return _currentEmployee; }
            set
            {
                _currentEmployee = value;
                OnPropertyChanged("CurrentEmployee");
            }
        }

        public CommandBase SaveCommand
        {
            get { return _saveCommand; }
        }

        public CommandBase SearchCommand
        {
            get { return _searchCommand; }
        }

        public CommandBase UpdateCommand
        {
            get { return _updateCommand; }
        }

        public CommandBase DeleteCommand
        {
            get { return _deleteCommand; }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }

        public EmployeeViewModel()
        {
            EmployeeService = new EmployeeService();
            LoadData();
            CurrentEmployee = new Employee();
            _saveCommand = new CommandBase(Save);
            _searchCommand = new CommandBase(Search);
            _updateCommand = new CommandBase(Update);
            _deleteCommand = new CommandBase(Delete);
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadData()
        {
            EmployeesList = new ObservableCollection<Employee>(EmployeeService.GetAllEmployees());
        }

        public void Save()
        {
            try
            {
                var isSaved = EmployeeService.AddEmployee(CurrentEmployee);
                LoadData();

                if (isSaved)
                    Message = "Employee saved.";
                else
                    Message = "Save operation failed!";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        public void Search()
        {
            try
            {
                var employee = EmployeeService.SearchEmployee(CurrentEmployee.Id);

                if (employee != null)
                {
                    CurrentEmployee.Name = employee.Name;
                    CurrentEmployee.Age = employee.Age;
                    Message = "Employee found.";
                }
                else
                    Message = "Employee not found!";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        public void Update()
        {
            try
            {
                var isUpdated = EmployeeService.UpdateEmployee(CurrentEmployee);
                
                if (isUpdated)
                {
                    Message = "Employee updated.";
                    LoadData();
                }
                else
                {
                    Message = "Update operation failed!";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        public void Delete()
        {
            try
            {
                var isDelete = EmployeeService.DeleteEmployee(CurrentEmployee.Id);

                if (isDelete)
                {
                    Message = "Employee deleted.";
                    LoadData();
                }
                else
                {
                    Message = "Delete operation failed!";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}
