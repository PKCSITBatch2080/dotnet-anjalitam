using System;

// Interface for items with a method to calculate price
public interface IPriced
{
    decimal CalculatePrice();
}

// Abstract class A representing a basic product
public abstract class ProductA : IPriced
{
    // Abstract property for the product's name
    public abstract string ProductName { get; set; }

    // Readonly property for a unique identifier
    public abstract int ProductId { get; }

    // Field for storing the manufacturer
    private string _manufacturer;

    // Property for accessing and setting the manufacturer
    public string Manufacturer
    {
        get { return _manufacturer; }
        set { _manufacturer = value; }
    }

    // Constructor for initializing manufacturer
    protected ProductA(string manufacturer)
    {
        _manufacturer = manufacturer;
    }

    // Implemented method from IPriced to calculate price
    public abstract decimal CalculatePrice();
}

// Class B representing a specific type of product (e.g., Electronics)
public class Electronics : ProductA
{
    // Property specific to Electronics
    public string Model { get; set; }

    // Constructor for Electronics
    public Electronics(string manufacturer, string model) : base(manufacturer)
    {
        Model = model;
    }

    // Overrides the CalculatePrice method from IPriced
    public override decimal CalculatePrice()
    {
        // Logic to calculate the price for electronics
        return 1000.0m;
    }

    // Overrides the ProductName property from ProductA
    public override string ProductName
    {
        get { return "Electronics"; }
        set { }
    }

    // Overrides the ProductId property from ProductA
    public override int ProductId
    {
        get { return GetHashCode(); }
    }
}
