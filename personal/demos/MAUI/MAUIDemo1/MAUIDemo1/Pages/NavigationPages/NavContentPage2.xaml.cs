namespace MAUIDemo1.Pages.NavigationPages;

public partial class NavContentPage2 : ContentPage
{
	public NavContentPage2()
	{
		InitializeComponent();
	}

    private async void navContentPage3Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavContentPage3());
    }

    private async void closeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    } 
}