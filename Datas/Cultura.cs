using System.Globalization;
namespace Datas
{
    class Cultura
    {
        public static void Culture()
        {
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(string.Format("{0:D}", DateTime.Now));
        }
    }
}