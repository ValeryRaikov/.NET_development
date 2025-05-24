using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Input;

public class MainVM : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    private MusicalToy _mtoy;
    public MusicalToy MToy
    {
        get => _mtoy;
        set { _mtoy = value; OnPropertyChanged(nameof(MToy)); }
    }

    public string SearchText { get; set; }
    private List<MusicalToy> allToys;

    public ICommand GetNextCommand { get; }

    public MainVM()
    {
        using var db = new ToysContext();
        SeedDatabase(db);
        allToys = db.MusicalToys.Include(t => t.Melodies).ToList();
        MToy = allToys.FirstOrDefault(t => t.MelodyNames.Contains(SearchText));

        GetNextCommand = new RelayCommand(_ => GetNext());
    }

    private void SeedDatabase(ToysContext db)
    {
        if (!db.MusicalToys.Any())
        {
            db.MusicalToys.Add(new MusicalToy
            {
                Caption = "Teddy Piano",
                Manufacturer = "ToyWorks",
                AgeInMonths = 12,
                Melodies = new List<ToyMelody>
                {
                    new ToyMelody { Name = "Twinkle", Composer = "Mozart" },
                    new ToyMelody { Name = "ABC Song", Composer = "Traditional" }
                }
            });

            db.MusicalToys.Add(new MusicalToy
            {
                Caption = "Bear Guitar",
                Manufacturer = "KidsPlay",
                AgeInMonths = 18,
                Melodies = new List<ToyMelody>
                {
                    new ToyMelody { Name = "Twinkle", Composer = "Mozart" }
                }
            });

            db.SaveChanges();
        }
    }

    private void GetNext()
    {
        if (string.IsNullOrWhiteSpace(SearchText) || MToy == null) return;

        int currentIndex = allToys.IndexOf(MToy);

        for (int i = currentIndex + 1; i < allToys.Count; i++)
        {
            if (allToys[i].MelodyNames.Contains(SearchText))
            {
                MToy = allToys[i];
                return;
            }
        }

        for (int i = 0; i <= currentIndex; i++)
        {
            if (allToys[i].MelodyNames.Contains(SearchText))
            {
                MToy = allToys[i];
                return;
            }
        }
    }
}