using FootballApp.Views;

namespace FootballApp.Commands
{
    public class ShowMatches : BaseCommand
    {
        public override void Execute(object? parameter)
        {
            var window = new SavedMatchesWindow();
            window.Show();
        }
    }
}
