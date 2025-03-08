using MAUILayouts.Pages;

namespace MAUILayouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navigationPage = new NavigationPage(new StackLayoutDemo());
            return new Window(navigationPage);
        }
    }
}