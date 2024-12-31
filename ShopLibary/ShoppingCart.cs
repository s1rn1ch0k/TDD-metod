using System.Collections.Generic;
using System.Linq;

namespace ShopLibary
{

    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal CalculateTotal()
        {
            if (Items == null || !Items.Any())
                return 0;

            return Items.Sum(item => item.Price * item.Quantity);
        }
    }

    public class CartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }


}