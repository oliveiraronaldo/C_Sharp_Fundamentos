using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        decimal valor = 10.234M;

        Console.WriteLine(valor);
        var us = CultureInfo.CreateSpecificCulture("en-US");
        var br = CultureInfo.CreateSpecificCulture("pt-BR");
        var es = CultureInfo.CreateSpecificCulture("es-ES");
        var cn = CultureInfo.CreateSpecificCulture("zh-CN");

        Console.WriteLine(valor.ToString("C", br));     //C = currencie

        Console.WriteLine(Math.Round(valor));
        Console.WriteLine(Math.Ceiling(valor));

    }
}