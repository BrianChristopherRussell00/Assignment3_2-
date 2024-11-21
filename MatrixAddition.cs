using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2_Cleanup
{
    public class MatrixAddition
    {


        public static void MatrixAdditionOperation()
        {// Edge Case 1st
            Console.WriteLine("Input the size of the matrix (less than 5):  ");
            int matrixSize = Convert.ToInt32(Console.ReadLine());
            if (matrixSize <= 0 || matrixSize > 5)
            {
                Console.WriteLine("Please enter a number greater than 0 and less than 5"); return;
            }
            // Instantiating matrices
            int[,] firstMatrix = new int[matrixSize, matrixSize];
            int[,] secondMatrix = new int[matrixSize, matrixSize];
            int[,] addedMatrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {

                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"element - [{i}] [{j}]");
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            // second matrix loop and element input
            Console.WriteLine("Input the elements in the second matrix:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"element - [{i}][{j}]");
                    secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                // Added matrix loop while adding matrix together
            }
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    addedMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
                // Next few printing out the matrices 
                Console.WriteLine("The first matrix is: ");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(firstMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The second matrix is: ");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(secondMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The addition of the two matricies is ");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(firstMatrix[i, j] + secondMatrix[i, j]);
                }
                Console.WriteLine() ;
            }
        }

    }



    }
    
