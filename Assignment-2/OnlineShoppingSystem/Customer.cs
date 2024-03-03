using System;
using System.Collections.Generic;

public class Customer : IPriced
{
    public string CustomerName { get; set; }
    public int CustomerId { get; }
    
    // List to store orders placed by the customer
    private readonly List<Order> _orders;

    // Constructor for Customer
    public Customer(string customerName, int customerId)
    {
        CustomerName = customerName;
        CustomerId = customerId;
        _orders = new List<Order>();
    }

    // Method to place an order
    public void PlaceOrder(ProductA product, int quantity)
    {
        Order order = new Order(product, quantity);
        _orders.Add(order);
    }

    // Implemented method from IPriced to calculate the total price of all orders
    public decimal CalculatePrice()
    {
        decimal totalPrice = 0.0m;
        foreach (var order in _orders)
        {
            totalPrice += order.CalculateOrderTotal();
        }
        return totalPrice;
    }

    // Getter for the orders list
    public List<Order> Orders => _orders;
}
