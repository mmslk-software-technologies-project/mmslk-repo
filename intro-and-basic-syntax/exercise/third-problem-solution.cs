//CONFIRMED from <MarinTsankov>
using System;

namespace xcvbnm
{
    class Program
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());

            double kilometerPerMile = 1.60934;

            double kilometer = miles * kilometerPerMile;

            Console.WriteLine($"{kilometer:F2}");
        }
    }
}


