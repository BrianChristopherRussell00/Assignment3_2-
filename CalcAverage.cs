using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2_Cleanup
{
    public class CalcAverage
    {

      public static void FindingAverage()
        {
            Console.WriteLine("Enter 4 numbers: * Hit enter after each number entry");
           double numberOne=Convert.ToDouble( Console.ReadLine());
            double numberTwo = Convert.ToDouble(Console.ReadLine());
            double numberThree = Convert.ToDouble(Console.ReadLine());
            double numberFour = Convert.ToDouble(Console.ReadLine());
           double myTotal= (numberOne + numberTwo + numberThree + numberFour);
            Console.WriteLine($"The average of {numberOne},{numberTwo},{numberThree},{numberFour} is {myTotal / 4}");
            Console.WriteLine($"Total: {myTotal} ");

        }


    }
}
