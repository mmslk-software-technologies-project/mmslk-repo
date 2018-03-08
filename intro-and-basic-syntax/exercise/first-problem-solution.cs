using System;

namespace TEST
{
    class Program
    {
   
            static void Main()
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                var third = int.Parse(Console.ReadLine());
                var forth = int.Parse(Console.ReadLine());

                var firstmod = first.ToString("D4");
                var secondmod = second.ToString("D4");
                var thirdmod = third.ToString("D4");
                var forthmod = forth.ToString("D4");

            Console.WriteLine($"{firstmod} {secondmod} {thirdmod} {forthmod}");



        }
    }

}
