using MauiToDoApp.Data;
using MauiToDoApp.Models;

namespace MauiToDoApp.Pages;

public partial class ToDoItemPage : ContentPage
{
	public ToDoItemPage()
	{
		InitializeComponent();
	}

	private async void OnSaveClicked(object sender, EventArgs e)
	{
		var todoItem = (ToDoItem)BindingContext;
		ToDoItemDatabase database = await ToDoItemDatabase.Instance;
		await database.SaveItemAsync(todoItem);
		await Navigation.PopAsync();
	}

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        var todoItem = (ToDoItem)BindingContext;
        ToDoItemDatabase database = await ToDoItemDatabase.Instance;
        await database.DeleteItemAsync(todoItem);
        await Navigation.PopAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}