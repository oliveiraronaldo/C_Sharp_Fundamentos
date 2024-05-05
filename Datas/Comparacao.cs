namespace Datas
{
    class Comparacao
    {
        public static void Compare()
        {
            Console.Clear();
            //var data = new DateTime(2024, 05, 04, 19, 12, 00);
            var data = DateTime.Now;
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(data);
        }
    }
}