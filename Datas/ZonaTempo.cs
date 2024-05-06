namespace Datas
{
    class ZonaTempo
    {
        public static void Zone()
        {
            var utcDate = DateTime.UtcNow;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();

            // foreach (var item in timezones)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcDate, item.Id));
            //     Console.WriteLine("____________________");
            // }

            var timeSpan = new TimeSpan(5, 34, 34);
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Add(new TimeSpan(5, 34, 34)));


        }
    }
}