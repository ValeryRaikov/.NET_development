using FootballApp.Context;
using FootballApp.ViewModels;
using System.Windows;

namespace FootballApp.Commands
{
    internal class DeleteMatch : BaseCommand
    {
        private SavedMatchesVM _viewModel;

        public DeleteMatch(SavedMatchesVM vm)
        {
            _viewModel = vm;
        }

        public override void Execute(object? parameter)
        {
            if (_viewModel.SelectedMatch == null)
            {
                MessageBox.Show("Please select a match to delete.");
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete match {_viewModel.SelectedMatch.HomeTeam} vs " +
                $"{_viewModel.SelectedMatch.ForeignTeam}?", "Confirm Delete", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    using (var db = new DatabaseContext())
                    {
                        db.Matches.Remove(_viewModel.SelectedMatch);
                        db.SaveChanges();
                    }

                    _viewModel.Matches.Remove(_viewModel.SelectedMatch);
                    _viewModel.SelectedMatch = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while deleting data:\n{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
