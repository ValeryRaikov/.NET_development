using MauiMVVM2.ViewModels;

namespace MauiMVVM2.Views;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();

		BindingContext = new ProductViewModel();
	}
}