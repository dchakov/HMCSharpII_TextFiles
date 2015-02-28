//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string firstFilePath = @"..\..\textProblem04_1.txt";
        string secondFilePath = @"..\..\textProblem04_2.txt";
        StreamReader readerfirstFile = new StreamReader(firstFilePath, Encoding.GetEncoding(1251));
        StreamReader readersecondFile = new StreamReader(secondFilePath, Encoding.GetEncoding(1251));
        int counter = 0;
        int counterDiferent = 0;
        using (readerfirstFile)
        {
            string lineFirstFile = readerfirstFile.ReadLine();
            string lineSecondFile = readersecondFile.ReadLine();
            while (lineSecondFile != null)
            {
                if (lineFirstFile.CompareTo(lineSecondFile) == 0)
                {
                    counter++;
                }
                else
                {
                    counterDiferent++;
                }
                lineFirstFile = readerfirstFile.ReadLine();
                lineSecondFile = readersecondFile.ReadLine();
            }
        }
        Console.WriteLine("Number of lines that are the same = {0}",counter);
        Console.WriteLine("Number of lines that are different = {0}",counterDiferent);
    }
}
