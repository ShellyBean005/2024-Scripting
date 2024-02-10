using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Unit_1b_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Temperature Adviser! Please Enter the current temperature in Fahrenheit");

            //user input

            string stringtemp = Console.ReadLine();

            // convert to int

            int temp = Convert.ToInt32(stringtemp);

            // if else chunk for temperatures
            
            if (temp >= 85
                && temp < 115)
            {
                Console.WriteLine("Make sure to take breaks out of the sun and drink plenty of water.");
            }
            else if (temp < 85
                && temp >= 75)
            {
                Console.WriteLine("Go have some fun outside today! It's gonna feel great!");
            }
            else if (temp < 75
                && temp >= 65)
            {
                Console.WriteLine("It might be a bit chilly for some. Maybe bring a light jacket.");
            }
            else if (temp < 65
                && temp >= 50)
            {
                Console.WriteLine("Definately bring a light jacket");
            }
            else if (temp < 50
                && temp >= 40)
            {
                Console.WriteLine("Its cold outside, wear pants and a jacket.");
            }
            else if (temp < 40
                && temp >= 30)
            {
                Console.WriteLine("Dress warm, if you get cold easily, wear layers.");
            }
            else if (temp < 30
                && temp >= 15)
            {
                Console.WriteLine("Wear some layers");
            }
            else if (temp < 15
                && temp >= 0)
            {
                Console.WriteLine("Maybe don't bother going outside.");
            }
            else
            {
                Console.WriteLine("God has abandanded your area. Stay inside.");
            }
            //read line to keep text open
            Console.ReadLine();
              
        }
    }
}
