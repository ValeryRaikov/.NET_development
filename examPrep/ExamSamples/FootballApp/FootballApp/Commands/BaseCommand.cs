using System.Windows.Input;

namespace FootballApp.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public virtual void Execute(object? parameter) { }
    }
}
