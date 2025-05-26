using FootballApp.Views;
using System.Windows.Input;

namespace FootballApp.Commands
{
    public class ShowMatches : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            var window = new SavedMatchesWindow();
            window.Show();
        }
    }
}
