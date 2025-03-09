namespace MAUIControls.Models
{
    class CollectionItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public CollectionItem(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
