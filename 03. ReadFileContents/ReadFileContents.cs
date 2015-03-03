/*
 * Problem 3. Read file contents
Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        //Console.WriteLine("Please enter the full path of the file:");
        //string filePath = Console.ReadLine();
        string filePath = @"C:\WINDOWS\win.ini";
        ReadFile(filePath);
    }

    private static void ReadFile(string filePath)
    {
        TextReader reader = new StreamReader(filePath);
        try
        {
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }
        finally
        {
            reader.Close();
        }
    }
}