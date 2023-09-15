using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elins hopp i meter?");
            double elinLängd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Almas hopp i meter?");
            double almaLängd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(
                "Elin hoppade " + (Math.Round(elinLängd - almaLängd, 3)) + " meter längre än Alma"
            );
            Console.ReadKey();
        }
    }
}
