//CONFIRMED from <MarinTsankov>
//CONFIRMED from <krzgo>
using System;

namespace P04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {/* We receive information for the console*/
            string name = Console.ReadLine();
            int volumeOfBeverage = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarConetent = int.Parse(Console.ReadLine());
            /* We get the energy and the sugar from multiplying the volume with the energy content/sugar content*/
            double energy = volumeOfBeverage * energyContent / 100.0;
            double sugar = volumeOfBeverage * sugarConetent / 100.0;
            /* Printing the results in the console*/
            Console.WriteLine($"{volumeOfBeverage}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
