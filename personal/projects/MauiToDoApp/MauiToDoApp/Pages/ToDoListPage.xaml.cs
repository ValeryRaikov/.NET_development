using MauiToDoApp.Data;
using MauiToDoApp.Models;
using System.Threading.Tasks;

namespace MauiToDoApp.Pages;

public partial class ToDoListPage : ContentPage
{
	public ToDoListPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ToDoItemDatabase database = await ToDoItemDatabase.Instance;
        ListView.ItemsSource = await database.GetItemsAsync();
    }

    private async void OnItemAdded(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ToDoItemPage
        {
            BindingContext = new ToDoItem(),
        });
    }

    private async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ToDoItemPage
            {
                BindingContext = e.SelectedItem as ToDoItem,
            });
        }
    }
}