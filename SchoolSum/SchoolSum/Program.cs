using System;

namespace SchoolSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string text = System.IO.File.ReadAllText(@"C:\Users\AlexAsenov\source\repos\SchoolSum\files\class-demo.csv");
            Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
    }
}
