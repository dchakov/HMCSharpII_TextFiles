//Problem 10. Extract text from XML• Write a program that extracts from given XML file all the text without the tags.
//Example:
// <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student> 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ExtractTextFromXML
{
    static void Main()
    {
        //http://www.htmlgoodies.com/primers/html/article.php/3478151

        Console.BufferHeight = Console.BufferHeight = 120;
        StreamReader reader = new StreamReader(@"..\..\problem10.xml", Encoding.GetEncoding(1251));
        StringBuilder htmlText = new StringBuilder();
        StringBuilder result = new StringBuilder();
        using (reader)
        {
            while (!reader.EndOfStream)
            {
                htmlText.Append(reader.ReadLine());
                htmlText.Append(Environment.NewLine);
            }
        }
        bool inbrackets = true;
        for (int i = 0; i < htmlText.Length; i++)
        {
            if (htmlText[i].ToString().IndexOf('<') == 0)
            {
                inbrackets = true;
            }
            else
            {
                if (!inbrackets)
                {
                    result.Append(htmlText[i]);
                }
                if (htmlText[i].ToString().IndexOf('>') == 0)
                {
                    inbrackets = false;
                }
                
                
            }
        }
        Console.WriteLine(result);
    }
}
