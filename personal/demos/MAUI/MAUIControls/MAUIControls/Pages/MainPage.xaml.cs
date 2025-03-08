namespace MAUIControls.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void commonControlsBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CommonControls());
    }
}