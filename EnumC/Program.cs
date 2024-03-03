Product mouse = new Product(1, "SSD", 400.00, EProductType.Produto);

Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Price);
Console.WriteLine(mouse.Type);

struct Product
{
    public Product(int id, string name, double price, EProductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }

    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;


    public double PrinceInDolar(double dolar)
    {
        return Price * dolar;
    }
}

enum EProductType
{
    Produto = 0,
    Servico = 1
}