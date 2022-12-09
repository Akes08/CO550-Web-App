using ExampleBlazorApp.Models;

namespace ExampleBlazorApp.Services
{
    public class CartService
    {
        public static List<ShoppingItem> SelectedItems { get; set; } = new List<ShoppingItem>();

        public void AddProductToCart(int productid)
        {
            if (ProductInCart(productid) is false)
            {
                var product = ProductService.Products.First(p => p.Id == (productid));

                ShoppingItem item = new ShoppingItem();

                item.Product = product;
                item.PurchasePrice = product.Price;


                SelectedItems.Add(item);
                Console.WriteLine(SelectedItems.Count);
            }
        }

        private bool ProductInCart(int productid)
        {
            foreach (ShoppingItem item in SelectedItems)
            {
                if (item.Product.Id == productid)
                {
                    item.Quantity++;
                    return true;
                }
            }
            return false;
        }

    }
}
