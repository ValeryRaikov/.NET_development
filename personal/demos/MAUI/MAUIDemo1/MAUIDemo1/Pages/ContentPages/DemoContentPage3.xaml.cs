namespace MAUIDemo1.Pages;

public partial class DemoContentPage3 : ContentPage
{
	public DemoContentPage3()
	{
		InitializeComponent();
	}

    private async void closeBtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}