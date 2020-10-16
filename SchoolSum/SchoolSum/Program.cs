using System;

namespace SchoolSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SchoolSort!");
            //string text = System.IO.File.ReadAllText(@"C:\Users\AlexAsenov\source\repos\SchoolSum\files\class-demo.csv");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\AlexAsenov\source\repos\SchoolSum\files\class-demo.csv");
            foreach (string line in lines)
            { 
                Console.WriteLine("\t" + line);
            }
        }
    }
}
