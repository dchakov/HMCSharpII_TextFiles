//Problem 8. Replace whole word• Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input08.txt", Encoding.GetEncoding(1251));
        StreamWriter resultFile = new StreamWriter(@"..\..\result08.txt", false, Encoding.GetEncoding(1251));

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
        string output = string.Empty;
        Console.WriteLine(resultText);
        output = Regex.Replace(resultText.ToString(), @"(\s)start(\s)", "finish");
        output = Regex.Replace(resultText.ToString(), @"(\b)start(\b)", "finish");
        //int counter = 0;
        //while (resultText.ToString().IndexOf("start", counter) >= 0)
        //{
        //    char currentEnd = resultText[resultText.ToString().IndexOf("start") +5];
        //    char currentStart;
        //    if (resultText[resultText.ToString().IndexOf("start")] !=0)
        //    {
        //        currentStart = resultText[resultText.ToString().IndexOf("start")-1];
        //    }
        //    if (!char.IsLetter(currentEnd) && !char.IsLetter(currentStart))
        //    {
        //       output = resultText.ToString().Replace("start", "finish"); 
        //    }
            
        //    counter++;
        //}
        Console.WriteLine(output);
        using (resultFile)
        {
            resultFile.Write(output);
            Console.WriteLine("Result SUCCESSFUL");
        }
    }
}
