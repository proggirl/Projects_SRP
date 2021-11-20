using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------HomeTask1-----------------------------//
            //Console.Write("a =");
            //int a = int.Parse(Console.ReadLine());

            //int b = a / 10;
            //int c = a % 10;

            //Console.WriteLine(c.ToString() + b.ToString());

            //Console.ReadLine();

            //------------------------HomeTask2-----------------------------//
            //Console.Write("Enter weeks:");
            //int weeks = int.Parse(Console.ReadLine());
            //Console.Write("Enter months:");
            //int months = int.Parse(Console.ReadLine());
            //Console.Write("Enter Year:");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Days- {(weeks * 7) + (months * 30) + (year * 365) }");

            //Console.ReadLine();


            //------------------------HomeTask3-----------------------------//

            Console.Write("N секунд = ");
            var n = int.Parse(Console.ReadLine());

            var h = (n / 3600);
            Console.WriteLine("Полных часов прошло с начала суток: " + h);
            var m = (n % 3600) / 60;
            Console.WriteLine("Полных минут прошло с начала очередного часа: " + m);
            var s = (n % 3600) - (m * 60);
            Console.WriteLine("Полных секунд прошло с начала очередной минуты: " + s);

            Console.ReadLine();

          


        }
    }
}
