﻿using System;
using System.Windows.Input;

namespace WpfExample
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var nameList = parameter as NamesList;
            var newName = string.Format("{0} {1}", nameList.FirstName, nameList.LastName);

            nameList.Names.Add(newName);
            nameList.FirstName = nameList.LastName = "";
        }
    }
}
