public class MusicalToy
{
    public int Id { get; set; }
    public string Caption { get; set; }
    public string Manufacturer { get; set; }
    public int AgeInMonths { get; set; }
    public List<ToyMelody> Melodies { get; set; } = new List<ToyMelody>();

    public List<string> MelodyNames => Melodies?.ConvertAll(m => m.Name);
}