using FootballApp.Context;
using FootballApp.ViewModels;
using System.Windows;

namespace FootballApp.Commands
{
    public class StoreResult : BaseCommand
    {
        private MainWindowVM _viewModel;

        public StoreResult(MainWindowVM vm)
        {
            _viewModel = vm;
        }

        public override void Execute(object? parameter)
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
                using (var db = new DatabaseContext())
                {
                    db.Database.EnsureCreated();

                    if (_viewModel.MatchId.HasValue)
                    {
                        var existing = db.Matches.Find(_viewModel.MatchId.Value);

                        if (existing != null)
                        {
                            existing.HomeTeam = _viewModel.HomeTeam;
                            existing.ForeignTeam = _viewModel.ForeignTeam;
                            existing.ScoreHome = _viewModel.ScoreHome;
                            existing.ScoreForeign = _viewModel.ScoreForeign;
                            existing.Start = _viewModel.Start;

                            db.SaveChanges();
                            MessageBox.Show("Match updated successfully.");
                            return;
                        }
                    }

                    db.Matches.Add(_viewModel.Match);
                    db.SaveChanges();
                    MessageBox.Show("Result saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving data:\n{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
