namespace App.ShoppingCartDemo.Web.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public string Brand { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool InStock { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}