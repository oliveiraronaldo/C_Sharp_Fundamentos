using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        var arr = new int[3];

        try
        {
            Salvar("");
            // System.IndexOutOfRangeException:
            Console.WriteLine(arr[5]);

        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Indice não encontrado");
        }
        catch (MinhaException ex)
        {
            Console.WriteLine(ex.QuandoAconteceu);
            Console.WriteLine("Exceção customizada");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Opa! Foi mal");
        }
        finally
        {
            Console.WriteLine("End");
        }
    }


    static void Salvar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new MinhaException(DateTime.Now);
        }
    }

    public class MinhaException : Exception
    {
        public MinhaException(DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu { get; set; }
    }

}
