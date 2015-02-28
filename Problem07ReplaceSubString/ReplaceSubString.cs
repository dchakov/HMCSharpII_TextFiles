//Problem 7. Replace sub-string• Write a program that replaces all occurrences of the sub-string  start  with the sub-string  finish  in a text file.
//• Ensure it will work with large files (e.g.  100 MB ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


class ReplaceSubString
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader( @"..\..\input07.txt", Encoding.GetEncoding(1251));
        StreamWriter resultFile = new StreamWriter(@"..\..\result07.txt", false, Encoding.GetEncoding(1251));

        StringBuilder resultText = new StringBuilder();
        using (inputFile)
        {
            string line = inputFile.ReadLine();
            while (line != null)
            {
                resultText.Append(line);
                resultText.Append(Environment.NewLine);
                line = inputFile.ReadLine();
            }

        }
        string output = string.Empty ;
        output = Regex.Replace(resultText.ToString(),"start", "finish");
        //int counter = 0;
        //while (resultText.ToString().IndexOf("start", counter) >= 0)
        //{
        //    output = resultText.ToString().Replace("start", "finish");
        //    counter++;
        //}
        using (resultFile)
        {
            resultFile.Write(output);
            Console.WriteLine("Result SUCCESSFUL");
        }
    }
}
