//CONFIRMED from <MarinTsankov>
using System;

namespace P02_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {   /* We receive the information about sideA and side B's value*/
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            /* We are multiplying sides to get the round value*/
            double area = sideA * sideB;
            /* We are printing the result*/
            Console.WriteLine($"{area:f2}");
        }
    }
}
