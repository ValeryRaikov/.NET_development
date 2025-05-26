using FootballApp.Commands;
using FootballApp.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace FootballApp.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private Match _match;

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
            get => Match.HomeTeam;
            set
            {
                Match.HomeTeam = value;
                OnPropertyChanged(nameof(HomeTeam));
            }
        }
        public string ForeignTeam
        {
            get => Match.ForeignTeam;
            set
            {
                Match.ForeignTeam = value;
                OnPropertyChanged(nameof(ForeignTeam));
            }
        }
        public DateTime Start
        {
            get => Match.Start;
            set
            {
                Match.Start = value;
                OnPropertyChanged(nameof(Start));
            }
        }
        public int ScoreHome
        {
            get => Match.ScoreHome;
            set
            {
                Match.ScoreHome = value;
                OnPropertyChanged(nameof(ScoreHome));
            }
        }
        public int ScoreForeign
        {
            get => Match.ScoreForeign;
            set
            {
                Match.ScoreForeign = value;
                OnPropertyChanged(nameof(ScoreForeign));
            }
        }

        public int? MatchId { get; set; }

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

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
