using MAUIControls.Models;

namespace MAUIControls.Pages;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo()
	{
		InitializeComponent();

		var items = new List<CollectionItem>
        {
            new CollectionItem("Item 1", "Description 1"),
            new CollectionItem("Item 2", "Description 2"),
            new CollectionItem("Item 3", "Description 3"),
            new CollectionItem("Item 4", "Description 4"),
            new CollectionItem("Item 5", "Description 5"),
        };

        listView.ItemsSource = items;
    }
}