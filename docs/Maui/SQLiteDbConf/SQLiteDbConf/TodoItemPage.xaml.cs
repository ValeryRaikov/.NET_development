namespace SQLiteDbConf;

public partial class TodoItemPage : ContentPage
{
    private TodoItem _todoItem;

    public TodoItemPage(TodoItem item = null)
	{
		InitializeComponent();

        _todoItem = item ?? new TodoItem();
        BindingContext = _todoItem;
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var database = new TodoItemDatabase();

        await database.SaveItemAsync(_todoItem);
        await Navigation.PopAsync();
    }

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}