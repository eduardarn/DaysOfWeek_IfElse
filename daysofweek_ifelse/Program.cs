using System;

namespace daysofweek_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            var dia = DateTime.Now.DayOfWeek;

            if (dia == DayOfWeek.Sunday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Sunday}");
            }
            else if (dia == DayOfWeek.Monday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Monday}");
            }
            else if (dia == DayOfWeek.Tuesday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Tuesday}");
            }
            else if (dia == DayOfWeek.Wednesday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Wednesday}");
            }
            else if (dia == DayOfWeek.Thursday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Thursday}");
            }
            else if (dia == DayOfWeek.Friday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Friday}");
            }
            else if (dia == DayOfWeek.Saturday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Saturday}");
            }
         
        }
    }
}
