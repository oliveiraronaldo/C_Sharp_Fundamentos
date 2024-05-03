internal class Program
{
    private static void Main(string[] args)
    {
        /*
        //GUID
        var id = Guid.NewGuid();
        id.ToString();

        id = new Guid("e14e35ac-e701-4682-8ff3-f10c303ef1b3");

        Console.WriteLine(id.ToString().Substring(0, 8));
        */


        /*
        //INTERPOLAÇÃO
        var price = 10.2;
        //var texto = "O preço do produto é: " + price + " apenas na promoção";
        //var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
        var texto = $"O preço do produto é: {price} apenas na promoção";
        Console.WriteLine(texto);
        */


        /*
        //COMPARAÇÃO
        var texto = "Testando string";

        Console.WriteLine(texto.CompareTo("Testando string"));
        Console.WriteLine(texto.CompareTo("Testando string um"));
        Console.WriteLine(texto.CompareTo("Testando"));

        Console.WriteLine(texto.Contains("Test"));
        Console.WriteLine(texto.Contains("test"));
        Console.WriteLine(texto.Contains("teSt", StringComparison.OrdinalIgnoreCase));
        */
    }
}