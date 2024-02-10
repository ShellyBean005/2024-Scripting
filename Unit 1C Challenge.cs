using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1C_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myInt = rnd.Next(1,11); //Random Number Generation

            Console.WriteLine("This is a Number Guesser game!");

            Console.WriteLine("Input a number between 1-10");

            int x = Convert.ToInt32(Console.ReadLine()); //User input

            for (; myInt < x; x = Convert.ToInt32(Console.ReadLine())) //If lower
            {
                Console.WriteLine("Try a little lower!");
              
            }
             
            for (; myInt > x; x = Convert.ToInt32(Console.ReadLine())) //if higher
            {
                Console.WriteLine("Try a bit higher!");
            }
             
            for (; myInt == x; Console.ReadLine()) //if equals
            {
                Console.WriteLine("Right on the money! Good job!");
            }
        }
    }
}
