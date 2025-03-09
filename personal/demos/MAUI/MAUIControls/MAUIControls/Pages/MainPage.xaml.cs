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

    private void actionControlsBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActionControls());
    }

    private void inputControlsBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputControls());
    }

    private void indicatorControlsBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new IndicatorControls());
    }

    private void drawingControlsBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DrawingControls());
    }

    private void carouselViewBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CarouselView());
    }

    private void indicatorViewBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new IndicatorView());
    }

    private void listViewBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListViewDemo());
    }
}