namespace MAUIControls.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

    private void demoBtn_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Valery Raikov", "You just clicked the button", "OK");
    }

    private void demoImageBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Valery Raikov", "You just clicked the image button", "OK");
    }

    private void demoSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Valery Raikov", $"You just searched for {demoSearchBar.Text}", "OK");
    }

    private void facebookSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Valery Raikov", "You just clicked the Facebook button", "OK");
    }

    private void instagramSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Valery Raikov", "You just clicked the Instagram button", "OK");
    }

    private void twitterSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Valery Raikov", "You just clicked the Twitter button", "OK");
    }

    private void linkedInSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Valery Raikov", "You just clicked the LinkedIn button", "OK");
    }
}