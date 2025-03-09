namespace MAUIControls.Pages;

public partial class IndicatorControls : ContentPage
{
	public IndicatorControls()
	{
		InitializeComponent();
	}

    private void activityIndicatorBtn_Clicked(object sender, EventArgs e)
    {
		activityIndicatorControl.IsRunning = !activityIndicatorControl.IsRunning;
    }
}