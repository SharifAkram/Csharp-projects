using System;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

class WordCountProgram
{
    static void Main()
    {
        string filePath = ""; // Replace with file path

        int wordCount = CountWords(filePath);

        Console.WriteLine($"Word Count: {wordCount}");
    }

    static int CountWords(string filePath)
    {
        try
        {
            string fileExtension = Path.GetExtension(filePath)?.ToLower();
            
            if (fileExtension == ".txt")
            {
                // For .txt files
                string text = File.ReadAllText(filePath);
                return text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
            else if (fileExtension == ".docx")
            {
                // For .docx files using OpenXML
            }

        }
    }
}