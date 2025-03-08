using MAUIDemo1.Pages;
using MAUIDemo1.Pages.FlyoutPages;
using MAUIDemo1.Pages.NavigationPages;
using MAUIDemo1.Pages.TabbedPages;

namespace MAUIDemo1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // return new Window(new DemoContentPage1());

            // var navigationPage = new NavigationPage(new NavContentPage1());
            // navigationPage.BackgroundColor = Colors.Firebrick;
            // navigationPage.BarTextColor = Colors.Black;
            // 
            // return new Window(navigationPage);

            // return new Window(new DemoFlyoutPage());

            return new Window(new DemoTabbedPage());
        }
    }
}