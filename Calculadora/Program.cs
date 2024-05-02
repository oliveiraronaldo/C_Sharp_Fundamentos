internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Calculadora dinâmica -- v2.0");
        Console.WriteLine("(1) Soma");
        Console.WriteLine("(2) Subtração");
        Console.WriteLine("(3) Divisão");
        Console.WriteLine("(4) Multiplicação");
        Console.WriteLine("(0) Sair");

        Console.WriteLine($"---------------");
        Console.Write("Selecione a operação: ");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 0: System.Environment.Exit(0); break;
            default: Menu(); break;
        }

    }
    static void Soma()
    {
        Console.Clear();

        Console.Write("Primeiro Valor: ");
        double var1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo Valor: ");
        double var2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = var1 + var2;
        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        double var1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        double var2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = var1 - var2;
        Console.WriteLine($"O Resultado da subtração é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.Write("Primeiro Valor: ");
        double var1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        double var2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = var1 / var2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        double var1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        double var2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = var1 * var2;

        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Console.ReadKey();
        Menu();
    }
}