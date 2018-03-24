//CONFIRMED from <MarinTsankov>
using System;

namespace TEST
{
    class Program
    {
   
            static void Main()
            {
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());
                var thirdNumber = int.Parse(Console.ReadLine());
                var forthNumber = int.Parse(Console.ReadLine());

                var firstmod = firstNumber.ToString("D4");
                var secondmod = secondNumber.ToString("D4");
                var thirdmod = thirdNumber.ToString("D4");
                var forthmod = forthNumber.ToString("D4");

            Console.WriteLine($"{firstmod} {secondmod} {thirdmod} {forthmod}");



        }
    }

}
