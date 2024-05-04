using System.Text.RegularExpressions;

namespace HTMLEditor
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Visualização");
            Console.WriteLine("-----------");
            Replace(text);
            Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            foreach (var palavra in words)
            {
                if (strong.IsMatch(palavra))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        palavra.Substring(
                            palavra.IndexOf('>') + 1,
                            (palavra.LastIndexOf('<') - 1) - palavra.IndexOf('>')
                        )
                    );
                    Console.Write(' ');
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($"{palavra} ");
                }
            }
        }

        public static void Open()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Digite o caminho de arquivo para abrir:");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                var text = file.ReadToEnd();
                Show(text);
            }
        }
    }


}