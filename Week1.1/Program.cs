using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user for first name 
            Console.WriteLine("What is your first name?");
            //Prints out first name
            string name = Console.ReadLine();
            //Asks for last name
            Console.WriteLine("What is your last name?");
            //Prints out last name
            string lastName = Console.ReadLine();
            //Asks for age
            Console.WriteLine("What is your age?");
            //Prints out age
            string age = Console.ReadLine();
            //Asks for favorite color 
            Console.WriteLine("What is your favorite color?");
            //Prints out color
            string color = Console.ReadLine();
            //Finally it writes out a sentence with all the user information put and prints it out
            Console.WriteLine("Hello!" + name + lastName + "You are" + age + "and your favorite color is" + color);
            Console.ReadLine();

        }
    }
}
