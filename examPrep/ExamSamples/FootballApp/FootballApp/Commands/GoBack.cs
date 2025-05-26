using FootballApp.ViewModels;
using System.Windows;

namespace FootballApp.Commands
{
    public class GoBack : BaseCommand
    {
        private SavedMatchesVM _viewModel;

        public GoBack(SavedMatchesVM vm)
        {
            _viewModel = vm;
        }

        public override void Execute(object? parameter)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == _viewModel)
                {
                    window.Close();
                    break;
                }
            }

            var mainVM = new MainWindowVM();

            var mainWindow = new MainWindow
            {
                DataContext = mainVM
            };

            mainWindow.Show();
        }
    }
}
