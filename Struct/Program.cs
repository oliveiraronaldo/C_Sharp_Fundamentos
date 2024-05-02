internal class Program
{
    private static void Main(string[] args)
    {
        var mouse = new Product(1, "Redragon", 120.5, EProductType.Product);
        var manutencaoEletrica = new Product(2, "Manutenção Elétrica", 70.4, EProductType.Service);

        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Price);
        Console.WriteLine(mouse.Type);

        Console.WriteLine(manutencaoEletrica.Id);
        Console.WriteLine(manutencaoEletrica.Name);
        Console.WriteLine(manutencaoEletrica.Price);
        Console.WriteLine(manutencaoEletrica.Type);
    }

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

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}