//CONFIRMED from <MarinTsankov>
//CONFIRMED from <krzgo>
using System;

namespace xcvbnm
{
    class Program
    {
        static void Main()
        {
			//We receive digit from the Console.
            double miles = double.Parse(Console.ReadLine());

            double kmPerMile = 1.60934;

			//Convert miles to kilometers
            double kilometer = miles * kmPerMile;

            Console.WriteLine($"{kilometer:F2}");
        }
    }
}


