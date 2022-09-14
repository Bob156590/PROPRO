using System;
namespace Uppgift_2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write the wages of the three employes one by on.");
            int money= int.Parse(Console.ReadLine());
            money= money+ int.Parse(Console.ReadLine());
            money= money+ int.Parse(Console.ReadLine());
            Console.WriteLine("so if add all the wages together the add up to " + money + "kr");
        }
    }
}