using FootballApp.Commands;
using FootballApp.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace FootballApp.ViewModels
{
    public class SavedMatchesVM : INotifyPropertyChanged
    {
        public ObservableCollection<Match> Matches { get; set; } = new();
        private Match? _selectedMatch;
        public Match? SelectedMatch
        {
            get => _selectedMatch;
            set
            {
                _selectedMatch = value;
                OnPropertyChanged(nameof(SelectedMatch));
            }
        }

        public ICommand LoadCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand GoBackCommand { get; }

        public SavedMatchesVM()
        {
            LoadCommand = new LoadMatches(this);
            DeleteCommand = new DeleteMatch(this);
            UpdateCommand = new UpdateMatch(this);

            LoadCommand.Execute(null);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
