//CONFIRMED from <MarinTsankov>
using System;

namespace xcvbnm
{
    class Program
    {
        static void Main()
        {
			//We receive digit from the Console.
            double miles = double.Parse(Console.ReadLine());

            double kilometerPerMile = 1.60934;

			//Convert miles to kilometers
            double kilometer = miles * kilometerPerMile;

            Console.WriteLine($"{kilometer:F2}");
        }
    }
}


