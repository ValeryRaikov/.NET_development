using MAUIDemo1.Pages;

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
            return new Window(new DemoContentPage1());
        }
    }
}