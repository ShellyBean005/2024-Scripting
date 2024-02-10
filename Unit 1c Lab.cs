using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1C_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number, and i will generate a Pyramid");

            int x = Convert.ToInt32(Console.ReadLine()); //user input converted to int

            for (int i = 0; i <= x; i++) //repeat every number up to the input number and making it 'int i'
            {
            
                for (int y = 1; y <= i ; y++) //using 'int i' to loop it 'i' amount of times
                   
                    Console.Write(i + " "); //write 'i' with space, 'i' amount of times

                Console.WriteLine("\n"); //to next line
            }
            Console.ReadLine(); //read user imput to keep window open
        }
    }
}
