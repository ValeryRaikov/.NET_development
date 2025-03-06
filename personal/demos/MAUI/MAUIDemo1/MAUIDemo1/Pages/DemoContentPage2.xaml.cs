namespace MAUIDemo1.Pages;

public partial class DemoContentPage2 : ContentPage
{
	public DemoContentPage2()
	{
		InitializeComponent();
	}

    private async void closeBtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }

    private async void contentPage3Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DemoContentPage3());
    }
}