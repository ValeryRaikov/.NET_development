using MauiMVVM2.ViewModels;

namespace MauiMVVM2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new UserViewModel(this);
        }
    }
}
