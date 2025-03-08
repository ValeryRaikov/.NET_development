using MAUIControls.Pages;

namespace MAUIControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // return new Window(new AppShell());

            // return new Window(new CommonControls());

            var navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackgroundColor = Color.FromRgba("#181C3F");
            return new Window(navigationPage);
        }
    }
}