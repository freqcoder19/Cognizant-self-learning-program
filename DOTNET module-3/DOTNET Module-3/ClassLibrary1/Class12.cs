using System;

class Product
{
    public string Name { get; set; }

    private decimal price;
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product();
        p.Name = "Laptop";
        p.Price = 1500;

        Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");

        p.Price = -500;
        Console.WriteLine($"Updated Price: {p.Price}");
    }
}
