Product mouse = new Product(1, "SSD", 400.00);

Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Price);

struct Product
{
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int Id;
    public string Name;
    public double Price;

    public double PrinceInDolar(double dolar)
    {
        return Price * dolar;
    }
}
