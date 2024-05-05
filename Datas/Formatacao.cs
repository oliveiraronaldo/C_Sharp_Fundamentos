namespace Datas
{
    class Formatacao
    {
        public static void Formatar()
        {
            Console.Clear();
            //var data = new DateTime(2024, 05, 04, 19, 12, 00);
            var data = DateTime.Now;
            var formatada = String.Format("{0:dd/MM/yyyy HH:mm:ss}", data);
            //var formatada = String.Format("{0:u}", data);
            Console.WriteLine(formatada);



            Console.WriteLine(data.AddDays(11).AddMonths(-2).AddYears(-26));
        }
    }
}