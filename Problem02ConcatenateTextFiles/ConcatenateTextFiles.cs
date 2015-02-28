//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstFilePath = @"..\..\textProblem02_1.txt";
        string secondFilePath = @"..\..\textProblem02_2.txt";
        StreamReader firstFile = new StreamReader(firstFilePath, Encoding.GetEncoding(1251));
        StreamReader secondFile = new StreamReader(secondFilePath, Encoding.GetEncoding(1251));
        string fileName = @"..\..\result.txt";
        StreamWriter resultFile = new StreamWriter(fileName,false,Encoding.GetEncoding(1251));
        using (resultFile)
        {
            resultFile.WriteLine(firstFile.ReadToEnd());
            resultFile.WriteLine(secondFile.ReadToEnd());
            Console.WriteLine("Concatenation SUCCESSFUL");
        }

    }
}
