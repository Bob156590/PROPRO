using System;
namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many meters did Elin jump?");
            string jump= Console.ReadLine();
            Console.WriteLine("And how meter did Alma jump?");
            string jump2= Console.ReadLine();
            int sub= int.Parse(jump);
            int sub2= int.Parse(jump2);
            int summan = sub - sub2;
            Console.WriteLine("So Elin jumped " + summan + "m futher then Alma.");
        }
    }
}