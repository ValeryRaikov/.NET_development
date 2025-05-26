using FootballApp.Commands;
using FootballApp.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace FootballApp.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private Match _match;
        private string _homeTeam;
        private string _foreignTeam;
        private DateTime _start;
        private int _scoreHome;
        private int _scoreForeign;

        public Match Match
        {
            get => _match;
            set
            {
                _match = value;
                OnPropertyChanged(nameof(Match));
            }
        }

        public string HomeTeam
        {
            get => _homeTeam;
            set
            {
                _homeTeam = value;
                OnPropertyChanged(nameof(HomeTeam));
            }
        }
        public string ForeignTeam
        {
            get => _foreignTeam;
            set
            {
                _foreignTeam = value;
                OnPropertyChanged(nameof(ForeignTeam));
            }
        }
        public DateTime Start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(Start));
            }
        }
        public int ScoreHome
        {
            get => _scoreHome;
            set
            {
                _scoreHome = value;
                OnPropertyChanged(nameof(ScoreHome));
            }
        }
        public int ScoreForeign
        {
            get => _scoreForeign;
            set
            {
                _scoreForeign = value;
                OnPropertyChanged(nameof(ScoreForeign));
            }
        }

        public ICommand StoreCommand { get; }
        public ICommand ShowMatchesCommand { get; }

        public MainWindowVM()
        {
            Match = new Match
            {
                Start = DateTime.Now,
            };

            StoreCommand = new StoreResult(this);
            ShowMatchesCommand = new ShowMatches();
        }

        public string Winner
        {
            get
            {
                if (ScoreHome > ScoreForeign)
                    return HomeTeam;
                else if (ScoreHome < ScoreForeign)
                    return ForeignTeam;
                else
                    return "Draw";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
