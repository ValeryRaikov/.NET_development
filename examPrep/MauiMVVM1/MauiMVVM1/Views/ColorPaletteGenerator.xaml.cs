namespace MauiMVVM1.Views;

public partial class ColorPaletteGenerator : ContentPage
{
	public ColorPaletteGenerator()
	{
		InitializeComponent();
        this.BindingContext = new ViewModels.ColorPaletteViewModel();
    }
}