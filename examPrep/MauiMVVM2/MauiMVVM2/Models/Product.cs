namespace MauiMVVM2.Models
{
    public class Product
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string DisplayPrice => $"${Price:N2}";
        public string StockStatus => Stock > 0 ? "In Stock" : "Out of Stock";

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
