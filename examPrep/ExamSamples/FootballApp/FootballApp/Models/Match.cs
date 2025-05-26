namespace FootballApp.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string HomeTeam { get; set; } = string.Empty;
        public string ForeignTeam { get; set; } = string.Empty;
        public DateTime Start { get; set; }
        public int ScoreHome { get; set; }
        public int ScoreForeign { get; set; }
    }
}
