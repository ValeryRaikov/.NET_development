using System;
using System.Windows.Input;

namespace MVVMDemo.Commands
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action DoWork;

        public CommandBase(Action work)
        {
            DoWork = work;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoWork();
        }
    }
}
