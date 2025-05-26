using FootballApp.Context;
using FootballApp.Models;
using FootballApp.ViewModels;
using System.Windows;

namespace FootballApp.Commands
{
    public class UpdateMatch : BaseCommand
    {
        private SavedMatchesVM _viewModel;

        public UpdateMatch(SavedMatchesVM vm)
        {
            _viewModel = vm;
        }

        public override void Execute(object? parameter)
        {
            if (_viewModel.SelectedMatch == null)
            {
                MessageBox.Show("Please select a match to update.");
                return;
            }

            try
            {
                var vm = new MainWindowVM
                {
                    MatchId = _viewModel.SelectedMatch.Id,
                    Match = new Match
                    {
                        Id = _viewModel.SelectedMatch.Id,
                        HomeTeam = _viewModel.SelectedMatch.HomeTeam,
                        ForeignTeam = _viewModel.SelectedMatch.ForeignTeam,
                        Start = _viewModel.SelectedMatch.Start,
                        ScoreHome = _viewModel.SelectedMatch.ScoreHome,
                        ScoreForeign = _viewModel.SelectedMatch.ScoreForeign
                    }
                };

                var window = new MainWindow
                {
                    DataContext = vm
                };

                window.ShowDialog();

                _viewModel.LoadCommand.Execute(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating data:\n{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
