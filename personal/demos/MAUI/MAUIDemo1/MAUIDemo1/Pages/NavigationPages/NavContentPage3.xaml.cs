namespace MAUIDemo1.Pages.NavigationPages;

public partial class NavContentPage3 : ContentPage
{
	public NavContentPage3()
	{
		InitializeComponent();
	}

    private async void closeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}