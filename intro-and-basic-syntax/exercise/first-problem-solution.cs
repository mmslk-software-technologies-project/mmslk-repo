//CONFIRMED from <MarinTsankov>
using System;

namespace TEST
{
    class Program
    {
   
            static void Main()
            {
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());
                var thirdNum = int.Parse(Console.ReadLine());
                var forthNum = int.Parse(Console.ReadLine());

                var firstmod = firstNum.ToString("D4");
                var secondmod = secondNum.ToString("D4");
                var thirdmod = thirdNum.ToString("D4");
                var forthmod = forthNum.ToString("D4");

            Console.WriteLine($"{firstmod} {secondmod} {thirdmod} {forthmod}");



        }
    }

}
