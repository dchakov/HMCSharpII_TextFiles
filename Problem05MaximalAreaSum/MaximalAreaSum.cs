//Problem 5. Maximal area sum
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:
//input	output
//4 
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2	17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        string filePath = @"..\..\textProblem05.txt";
        StreamReader reader = new StreamReader(filePath);
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        
        int numberN = 0;
        int[,] matrix;
        using (reader)
        {
            numberN = int.Parse(reader.ReadLine());
            matrix = new int[numberN, numberN];
            for (int row = 0; row < numberN; row++)
            {
                string[] text = reader.ReadLine().Split(' ');
                for (int col = 0; col < numberN; col++)
                { 
                    matrix[row, col] = int.Parse(text[col]);
                }
            }
        }
        // Find the maximal sum platform of size 2 x 2
        int bestSum = int.MinValue;
        //int bestRow = 0;
        //int bestCol = 0;

        for (int row = 0; row < numberN - 1; row++)
        {
            for (int col = 0; col < numberN - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    //bestRow = row;
                    //bestCol = col;
                }
            }
        }
        using (writer)
        {
            writer.WriteLine(bestSum);
            Console.WriteLine("Result SUCCESSFUL");
        }
        //for (int row = 0; row < numberN; row++)
        //{
        //    for (int col = 0; col < numberN; col++)
        //    {
        //        Console.Write("{0,3}", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("The best platform from above matrix is");
        //for (int row = bestRow; row < bestRow + 2; row++)
        //{
        //    for (int col = bestCol; col < bestCol + 2; col++)
        //    {
        //        Console.Write("{0,4}", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("The maximal sum is {0}", bestSum);
    }
}

