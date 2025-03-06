namespace MAUIDemo1.Pages;

public partial class DemoContentPage1 : ContentPage
{
	public DemoContentPage1()
	{
		InitializeComponent();
	}

	private void contentPage2Btn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new DemoContentPage2());
	}
}