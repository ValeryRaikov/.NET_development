using MauiMVVM1.Models;
using MauiMVVM1.ViewModels;

namespace MauiMVVM1.Commands
{
    public class GeneratePaletteCommand : BaseCommand
    {
        private readonly ColorPaletteViewModel _viewModel;

        public GeneratePaletteCommand(ColorPaletteViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            var random = new Random();
            var colors = Enumerable.Range(0, 5)
                .Select(_ => $"#{random.Next(0x1000000):X6}")
                .ToList();

            _viewModel.CurrentPalette = new ColorPalette
            {
                Name = $"Palette {_viewModel.Favorites.Count + 1}",
                Colors = colors
            };
        }
    }
}
