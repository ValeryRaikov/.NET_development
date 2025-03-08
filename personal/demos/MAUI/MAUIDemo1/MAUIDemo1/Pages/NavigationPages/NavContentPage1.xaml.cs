namespace MAUIDemo1.Pages.NavigationPages;

public partial class NavContentPage1 : ContentPage
{
	public NavContentPage1()
	{
		InitializeComponent();
	}

    private async void navContentPage2Btn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NavContentPage2());
    }
}