// Class representing an order placed by a customer
public class Order
{
    // Properties for order details
    public ProductA OrderedProduct { get; set; }
    public int Quantity { get; set; }

    // Constructor for Order
    public Order(ProductA product, int quantity)
    {
        OrderedProduct = product;
        Quantity = quantity;
    }

    // Method to calculate the total price of the order
    public decimal CalculateOrderTotal()
    {
        return OrderedProduct.CalculatePrice() * Quantity;
    }
}
