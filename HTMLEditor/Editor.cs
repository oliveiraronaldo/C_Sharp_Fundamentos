using System.Text;

namespace HTMLEditor
{

    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("-----------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------");
            Console.WriteLine("--Deseja salvar o arquivo?  [s/n] ");

            var opSalvar = Console.ReadLine();
            if (opSalvar.ToLower() == "s")
            {
                Console.WriteLine("Qual o caminho da pasta para salvar?");
                var path = Console.ReadLine();
                using (var salvar = new StreamWriter(path))
                {
                    salvar.Write(file.ToString());
                }
                Console.WriteLine($"Arquivo salvo em {path} com sucesso!");
                Thread.Sleep(2000);
                Viewer.Show(file.ToString());
            }





        }
    }
}