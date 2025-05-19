using MauiMVVM2.ViewModels;

namespace MauiMVVM2.Views
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();

            BindingContext = new UserViewModel(this);
        }
    }
}
