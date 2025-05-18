using MauiMVVM1.Commands;
using MauiMVVM1.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiMVVM1.ViewModels
{
    public class ColorPaletteViewModel : INotifyPropertyChanged
    {
        private ColorPalette? _currentPalette;
        internal readonly List<ColorPalette> FavoritesInternal = new();

        public ColorPalette? CurrentPalette
        {
            get => _currentPalette;
            set
            {
                _currentPalette = value;
                OnPropertyChanged(nameof(CurrentPalette));
            }
        }

        public IReadOnlyList<ColorPalette> Favorites => FavoritesInternal.AsReadOnly();

        public ICommand GenerateNewPaletteCommand { get; }
        public ICommand SaveToFavoritesCommand { get; }
        public ICommand CopyColorCommand { get; }

        public ColorPaletteViewModel()
        {
            GenerateNewPaletteCommand = new GeneratePaletteCommand(this);
            SaveToFavoritesCommand = new SaveToFavoritesCommand(this);
            CopyColorCommand = new CopyColorCommand();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
