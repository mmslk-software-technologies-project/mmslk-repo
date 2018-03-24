//CONFIRMED from <MarinTsankov>
using System;

namespace P04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {/* We receive information for the console*/
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarConetent = int.Parse(Console.ReadLine());
            /* We get the energy and the sugar from multiplying the volume with the energy content/sugar content*/
            double energy = volume * energyContent / 100.0;
            double sugar = volume * sugarConetent / 100.0;
            /* Printing the results in the console*/
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
