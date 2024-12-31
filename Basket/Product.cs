using System;

namespace ТDD._1
{
    public class Product
    {
   
        public string Name { get; }
        public decimal Price {set; get;}
        
        public int Quantity { get; }

        

        public Product(string name, decimal price, int quantity)
        {

            if (string.IsNullOrWhiteSpace(name)) 
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Price must be a positive value.");
            }

            if (quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }

            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
    
}