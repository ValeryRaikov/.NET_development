using FootballApp.Context;
using FootballApp.ViewModels;
using System.Windows;

namespace FootballApp.Commands
{
    public class LoadMatches : BaseCommand
    {
        private SavedMatchesVM _viewModel;

        public LoadMatches(SavedMatchesVM vm)
        {
            _viewModel = vm;
        }

        public override void Execute(object? parameter)
        {
            _viewModel.Matches.Clear();

            try
            {
                using (var db = new MatchContext())
                {
                    db.Database.EnsureCreated();
                    foreach (var match in db.Matches)
                    {
                        _viewModel.Matches.Add(match);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading data:\n{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
