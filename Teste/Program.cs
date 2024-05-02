internal class Program
{
    private static void Main(string[] args)
    {
        const String texto = "Testando";
        Console.WriteLine(texto);

        MeuMetodo("Olá Mundo!");
        Console.WriteLine(RetornaNome());

        int valor = 0;
        while (valor <= 5)
        {
            valor++;
            Console.Write(valor);
        }

        do
        {
            valor--;
            Console.WriteLine(valor);
        } while (valor > 0);





        //comentário em linha
        /*
            comentário em bloco
        */
        ///documentação da classe
    }

    static void MeuMetodo(string parametro)
    {
        Console.WriteLine(parametro);
    }

    static string RetornaNome()
    {
        return "Ronaldo";
    }
}