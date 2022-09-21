using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            DateTime plusmin = new DateTime(1994, 6, 16, hours, min, 0);
            plusmin = plusmin.AddMinutes(30);
            Console.WriteLine(plusmin.Hour + ":"+ plusmin.Minute); ;

             Console.ReadLine();
        }
    }
}
