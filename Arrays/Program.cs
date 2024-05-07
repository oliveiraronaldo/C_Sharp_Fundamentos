internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        var array = new int[5] { 3, 5, 4, 3, 4 };
        var novoArray = new int[5];

        // array.CopyTo(novoArray, 0);
        novoArray[0] = array[0];

        array[0] = 12;


        // for (int i = 0; i < array.Length; i++)
        // {
        //     Console.WriteLine(array[i]);
        // }

        // foreach (var item in array)
        // {
        //     Console.WriteLine(item);
        // }

        Console.WriteLine(novoArray[0]);
        Console.WriteLine(array[0]);
    }
}