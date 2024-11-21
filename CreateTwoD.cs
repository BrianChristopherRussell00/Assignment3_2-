using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2_Cleanup
{
    public class CreateTwoD
    {

        public static void CreatedTwoDArray()
        {
            int[,] matrix = { { 2,3,4 },
                               {1,4,6 } };

            Console.WriteLine("2D Array: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" {matrix[i, j]} |");


                }
                Console.WriteLine();

            }

        }





    }
}
