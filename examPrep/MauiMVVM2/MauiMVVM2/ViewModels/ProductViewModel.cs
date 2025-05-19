using MauiMVVM2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiMVVM2.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Product _selectedProduct;

        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }

        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                if (_selectedProduct != null)
                {
                    ProductName = _selectedProduct.Name;
                    Price = _selectedProduct.Price.ToString();
                    Stock = _selectedProduct.Stock.ToString();
                }
                OnPropertyChanged(nameof(SelectedProduct));
                OnPropertyChanged(nameof(IsProductSelected));
            }
        }

        public bool IsProductSelected => SelectedProduct != null;

        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand NavigateBackCommand { get; }

        public ProductViewModel()
        {
            Products.Add(new Product("Laptop", 999.99m, 10));
            Products.Add(new Product("Mouse", 19.99m, 50));

            AddCommand = new Command(AddProduct);
            UpdateCommand = new Command(UpdateProduct, () => IsProductSelected);
            DeleteCommand = new Command(DeleteProduct, () => IsProductSelected);
            ClearCommand = new Command(ClearForm);
            NavigateBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        }

        private void AddProduct()
        {
            if (decimal.TryParse(Price, out decimal price) && int.TryParse(Stock, out int stock))
            {
                Products.Add(new Product(ProductName, price, stock));
                ClearForm();
            }
        }

        private void UpdateProduct()
        {
            if (SelectedProduct != null &&
                decimal.TryParse(Price, out decimal price) &&
                int.TryParse(Stock, out int stock))
            {
                SelectedProduct.Name = ProductName;
                SelectedProduct.Price = price;
                SelectedProduct.Stock = stock;

                var temp = Products.ToList();
                Products.Clear();
                foreach (var p in temp) Products.Add(p);

                ClearForm();
            }
        }

        private void DeleteProduct()
        {
            if (SelectedProduct != null)
            {
                Products.Remove(SelectedProduct);
                ClearForm();
            }
        }

        private void ClearForm()
        {
            ProductName = string.Empty;
            Price = string.Empty;
            Stock = string.Empty;
            SelectedProduct = null;
            OnPropertyChanged(nameof(ProductName));
            OnPropertyChanged(nameof(Price));
            OnPropertyChanged(nameof(Stock));
        }

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
