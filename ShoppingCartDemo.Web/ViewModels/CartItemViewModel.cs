namespace App.ShoppingCartDemo.Web.ViewModels
{
    public class ProductItemViewModel
    {
        private int _totalPrice;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public bool InStock { get; set; }
        public int Price { get; set; }

        public int TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public int Quantity { get; set; }
    }
}