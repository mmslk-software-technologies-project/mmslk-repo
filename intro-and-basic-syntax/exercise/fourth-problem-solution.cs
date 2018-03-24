//CONFIRMED from <MarinTsankov>
using System;

namespace P04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarConetent = int.Parse(Console.ReadLine());

            double energy = volume * energyContent / 100.0;
            double sugar = volume * sugarConetent / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
