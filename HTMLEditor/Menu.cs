namespace HTMLEditor
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;

            DrawScreen(10, 30);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);

        }

        public static void DrawScreen(int linhas, int colunas)
        {
            LastLine(colunas);

            Body(linhas, colunas);

            LastLine(colunas);

        }

        static void LastLine(int colunas)
        {
            Console.Write("+");

            for (int i = 0; i <= colunas; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }

        static void Body(int linhas, int colunas)
        {
            for (int lines = 0; lines <= linhas; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= colunas; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");

            }
        }


        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0- Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }


        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Open(); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                    }; break;
                default: Show(); break;
            }
        }
    }



}