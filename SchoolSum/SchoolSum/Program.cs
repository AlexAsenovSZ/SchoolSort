using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SchoolSum
{
    class Program
    {
         private static string filePath = "C:\Users\AlexAsenov\source\repos\SchoolSum\files\class-demo.csv";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SchoolSort!");
            //string text = File.ReadAllText(@filePath);
            string[] lines = File.ReadAllLines(@filePath);
            foreach (string line in lines)
            { 
                Console.WriteLine("\t" + line);
            }
        }
    }
}
