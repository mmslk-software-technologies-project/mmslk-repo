//CONFIRMED from <krzgo>
using System;

namespace xcvbnm
{
    class Program
    {
        static void Main()
        {   /*We receive the values from the console*/
            string name = Console.ReadLine();

            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());

            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            /*We are getting the value of full capacity without the current condition*/
            var maxHealthfinal = maxHealth - currHealth;
            var maxEnergyfinal = maxEnergy - currEnergy;
            /*We are printing the results*/
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|",new string('|', currHealth), new string('.', maxHealthfinal));
            Console.WriteLine("Energy: |{0}{1}|",new string('|', currEnergy), new string('.', maxEnergyfinal));
        }
    }
}
