using System;

class Program
{
    static void Main()
    {
        // Creating an electronics product
        Electronics electronicProduct = new Electronics("Sony", "Smart TV");

        // Creating a customer
        Customer customer = new Customer("Anjali Tamang", 1);

        // Placing an order for the electronic product
        customer.PlaceOrder(electronicProduct, 2);

        // Displaying information about the order and customer
        Console.WriteLine("Order Details:");
        foreach (var order in customer.Orders)
        {
            Console.WriteLine($"Product: {order.OrderedProduct.ProductName}, Quantity: {order.Quantity}, " +
                $"Total Price: {order.CalculateOrderTotal():C}");
        }

        // Displaying the total price for all orders placed by the customer
        Console.WriteLine($"Total Price for {customer.CustomerName}: {customer.CalculatePrice():C}");
    }
}
