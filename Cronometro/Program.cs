internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("S - Segundos => 10s = 10 segundos");
        Console.WriteLine("M - Minutos => 1m = 1 minuto");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string opcao = Console.ReadLine().ToLower();
        char type = char.Parse(opcao.Substring(opcao.Length - 1, 1));
        int time = int.Parse(opcao.Substring(0, opcao.Length - 1));
        int multiplier = 1;

        if (type == 'm')
        {
            multiplier = 60;
        }
        if (time == 0) System.Environment.Exit(0);

        Start(multiplier * time);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time)
    {
        double currentTime = time;

        while (currentTime >= 0)
        {
            Console.Clear();
            Console.WriteLine($"{currentTime:0.00}");
            currentTime -= 0.01;
            Thread.Sleep(1);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado...");
        Thread.Sleep(1500);
        Menu();
    }
}