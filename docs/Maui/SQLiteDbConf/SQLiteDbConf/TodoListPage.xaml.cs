using System.Collections.ObjectModel;


namespace SQLiteDbConf
{
    public partial class TodoListPage : ContentPage
    {
        private readonly TodoItemDatabase _database;
        public ObservableCollection<TodoItem> Items { get; set; }

        public TodoListPage()
        {
            InitializeComponent();

            _database = new TodoItemDatabase();
            Items = new ObservableCollection<TodoItem>();
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadItems();
        }

        private async Task LoadItems()
        {
            var items = await _database.GetItemsAsync();
            Items.Clear();
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        private async void OnAddItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage());
        }

        private async void OnDeleteItemClicked(object sender, EventArgs e)
        {
            if (TodoListView.SelectedItem is TodoItem selectedItem)
            {
                bool confirm = await DisplayAlert("Confirm", "Delete this item?", "Yes", "No");
                if (confirm)
                {
                    await _database.DeleteItemAsync(selectedItem);
                    Items.Remove(selectedItem);
                }
            }
            else
            {
                await DisplayAlert("Error", "Please select an item to delete.", "OK");
            }
        }
    }
}
