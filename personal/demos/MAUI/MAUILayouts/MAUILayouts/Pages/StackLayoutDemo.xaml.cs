namespace MAUILayouts.Pages;

public partial class StackLayoutDemo : ContentPage
{
	public StackLayoutDemo()
	{
		InitializeComponent();
	}

    private void verticalStackLayoutBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new VerticalStackLayoutDemo());
    }

    private void horizontalStackLayoutBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalStackLayoutDemo());
    }

    private void gridLayoutBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridDemo());
    }

    private void absoluteLayoutBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutDemo());
    }

    private void flexLayoutBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayoutDemo());
    }
}