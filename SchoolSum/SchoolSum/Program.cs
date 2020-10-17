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
        private static int countStudentAss = 0;
        private static int count2 = 0;
        private static int count3 = 0;
        private static int count4 = 0;
        private static int count5 = 0;
        private static int count6 = 0;
        private static double averageSuccess;        
        private static int sumSuccess = 0;
        static void SortAss(int ass)
        {
            switch(ass)
            {
                case 2:
                    count2++;
                    break;
                case 3:
                    count3++;
                    break;
                case 4:
                    count4++;
                    break;
                case 5:
                    count5++;
                    break;
                case 6:
                    count6++;
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SchoolSortAss");
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var array = line.Split(',');
                //Console.WriteLine("Nomer {0} = {1}",array[0], array[2]);
                countStudent++;
                if (string.IsNullOrEmpty(array[2]))
                {
                    continue;
                }
                countStudentAss++;
                int ass = int.Parse(array[2]);
                SortAss(ass);
                sumSuccess += ass; 
            }

            Console.WriteLine("CountStudent : {0}", countStudent); 
            averageSuccess = sumSuccess / (countStudentAss*1.0); 
            Console.WriteLine(" ass 2 : {0}", count2);
            Console.WriteLine(" ass 3 : {0}", count3);
            Console.WriteLine(" ass 4 : {0}",count4);
            Console.WriteLine(" ass 5 : {0}", count5);
            Console.WriteLine(" ass 6 : {0}", count6);
            Console.WriteLine("AVG : {0:N2}", averageSuccess);
            Console.WriteLine("Empty Ass : {0}",(countStudent - countStudentAss));
        }
    }
}
