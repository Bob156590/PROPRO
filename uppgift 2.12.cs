using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the car rental company calculater.");
            Console.WriteLine("so how many day will you rent our car?");
            string days=Console.ReadLine();
            Console.WriteLine("and for how many km do will you be driving?");
            string km=Console.ReadLine();
            int days2= int.Parse(days);
            int km2= int.Parse(km);
            int money=500 * days2 + km2 + 300;
            Console.WriteLine("So if we add everything together that comes to" + money + "kr");
        }
    }
}
