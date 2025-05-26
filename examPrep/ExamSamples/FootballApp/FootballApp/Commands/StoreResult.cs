using FootballApp.Context;
using FootballApp.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace FootballApp.Commands
{
    public class StoreResult : ICommand
    {
        private MainWindowVM _viewModel;

        public StoreResult(MainWindowVM vm)
        {
            _viewModel = vm;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (_viewModel.Match == null ||
                string.IsNullOrWhiteSpace(_viewModel.Match.HomeTeam) ||
                string.IsNullOrWhiteSpace(_viewModel.Match.ForeignTeam))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (var db = new MatchContext())
                {
                    db.Database.EnsureCreated();
                    db.Matches.Add(_viewModel.Match);
                    db.SaveChanges();
                }

                MessageBox.Show("Result saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving data:\n{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
