using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1a_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Bad Calculator! Where we only work in whole numbers! Please enter your first digit.");

            string firstDig = Console.ReadLine();
            
            int FirstIn = Convert.ToInt32(firstDig);

            Console.WriteLine("Please enter your second digit.");

            string secDig = Console.ReadLine();

            int SecIn = Convert.ToInt32(secDig);

            Console.WriteLine("What would you like to do with these digits? Limit yourseft to + - * /");

            string WhatDo = Console.ReadLine();

            if (WhatDo.Equals("+"))
            {

                Console.WriteLine(FirstIn + SecIn);

            }
            else if (WhatDo.Equals("-"))
            {
                Console.WriteLine(FirstIn - SecIn);

            }
            else if (WhatDo.Equals("*"))
            {
                Console.WriteLine(FirstIn * SecIn);
            }
            else if (WhatDo.Equals("/"))
            {
                Console.WriteLine(FirstIn / SecIn);
            }
            else
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
