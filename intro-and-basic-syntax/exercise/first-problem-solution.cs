//CONFIRMED from <MarinTsankov>
using System;

namespace TEST
{
    class Program
    {
   
            static void Main()
            {   /*We receive the values from the console*/
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());
                var thirdNum = int.Parse(Console.ReadLine());
                var forthNum = int.Parse(Console.ReadLine());
                /*We are rounding the digits to fourth number.If less, adding zeros until the value is four digits*/
                var firstmod = firstNum.ToString("D4");
                var secondmod = secondNum.ToString("D4");
                var thirdmod = thirdNum.ToString("D4");
                var forthmod = forthNum.ToString("D4");
            /*We are printing the result*/
            Console.WriteLine($"{firstmod} {secondmod} {thirdmod} {forthmod}");



        }
    }

}
