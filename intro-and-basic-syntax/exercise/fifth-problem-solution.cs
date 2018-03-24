//CONFIRMED from <krzgo>
//CONFIRMED from <MarinTsankov>
using System;

namespace xcvbnm
{
    class Program
    {
        static void Main()
        {   /*We receive the values from the console*/
            string name = Console.ReadLine();

            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());

            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            /*We are getting the value of full capacity without the current condition*/
            var maxHealthfinal = maxHealth - currentHealth;
            var maxEnergyfinal = maxEnergy - currentEnergy;
            /*We are printing the results*/
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|",new string('|', currentHealth), new string('.', maxHealthfinal));
            Console.WriteLine("Energy: |{0}{1}|",new string('|', currentEnergy), new string('.', maxEnergyfinal));
        }
    }
}
