using MauiMVVM1.Views;

namespace MauiMVVM1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColorPaletteGenerator();
        }
    }
}