using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSum
{
    class Program
    {
           private static string filePath = @"C:\Users\AlexAsenov\source\repos\SchoolSum\files\class-demo.csv";
        private static int countStudent = 0;
        private static int count2 = 0;
        private static int count3 = 0;
        private static int count4 = 0;
        private static int count5 = 0;
        private static int count6 = 0;
        private static double averageSuccess;        
        private static int sumSuccess = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SchoolSort");
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var array = line.Split(',');
                Console.WriteLine("Nomer {0} = {1}",array[0], array[2]);
                if (string.IsNullOrEmpty(array[2]))
                {
                    continue;
                }
                countStudent++; 
                sumSuccess += int.Parse(array[2]);
                
                //Console.WriteLine(line);
            }
            Console.WriteLine("CountStudent: {0}", countStudent); 
            averageSuccess = sumSuccess / (countStudent*1.0);
            Console.WriteLine("CountStudent: {0}, Sum: {1}, AVG: ", countStudent, sumSuccess);
            Console.WriteLine("AVG :{0:N2}",averageSuccess);
        }
    }
}
