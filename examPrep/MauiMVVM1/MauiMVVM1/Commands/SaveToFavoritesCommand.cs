using MauiMVVM1.ViewModels;

namespace MauiMVVM1.Commands
{
    public class SaveToFavoritesCommand : BaseCommand
    {
        private readonly ColorPaletteViewModel _viewModel;

        public SaveToFavoritesCommand(ColorPaletteViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            if (_viewModel.CurrentPalette != null)
            {
                _viewModel.FavoritesInternal.Add(_viewModel.CurrentPalette);
                _viewModel.OnPropertyChanged(nameof(ColorPaletteViewModel.Favorites));
            }
        }
    }
}
