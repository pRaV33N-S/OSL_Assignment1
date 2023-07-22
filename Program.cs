using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSL_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\Raven\Practice Exercise\C#\OSL_Assignment1\Rainbow School.txt";
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine("The Students data are \n");
                int index = 1;
                foreach (string line in lines)
                    Console.WriteLine($"  {index++} : "+line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("All the Students data in the files are displayed.");
            }
        }
    }
}
