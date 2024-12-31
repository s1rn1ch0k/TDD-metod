using ShopLibary;
using System;


//Cart 

var cart = new ShoppingCart();
// Генерация тестовых данных
cart.Items.Add(new CartItem { Name = "Apple", Price = 1.2m, Quantity = 3 });
cart.Items.Add(new CartItem { Name = "Banana", Price = 0.8m, Quantity = 5 });
cart.Items.Add(new CartItem { Name = "Orange", Price = 1.5m, Quantity = 2 });

Console.WriteLine("Items in Cart:");
foreach (var item in cart.Items)
{
    Console.WriteLine($"{item.Name}: ${item.Price} x {item.Quantity}");
}

Console.WriteLine($"\nTotal: ${cart.CalculateTotal()}");

//Products
try
{
    // Тест на создание корректного продукта
    Console.WriteLine("Creating a valid product...");
    var product = new Product("Laptop", 1000.99m, 5);
    Console.WriteLine($"Product created: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");

    // Тест на ошибку из-за пустого имени
    Console.WriteLine("\nAttempting to create a product with an empty name...");
    var invalidProduct = new Product("", 500.00m, 2);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    // Тест на ошибку из-за отрицательной цены
    Console.WriteLine("\nAttempting to create a product with a negative price...");
    var invalidProduct = new Product("Smartphone", -100.00m, 1);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    // Тест на ошибку из-за отрицательного количества
    Console.WriteLine("\nAttempting to create a product with a negative quantity...");
    var invalidProduct = new Product("Tablet", 250.00m, -3);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}