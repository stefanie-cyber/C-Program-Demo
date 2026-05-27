using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace section_B__C__Program_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //first line
            Console.WriteLine("Welcome to the Structure of a C# program Demo!");

            //user
            Console.WriteLine("Enter your name:"); 
            string name = Convert.ToString(Console.ReadLine());

            //desplay user name
            Console.WriteLine("Hello " + name + "!"); Console.ReadLine();


            //list start

            Console.WriteLine("Program Stucture Demonstrated:");
            new LinkedList<string>();

            //list
            Console.WriteLine("1. using system : imports functionality");
            Console.WriteLine("2. namespace : organizes code");
            Console.WriteLine("3. class Program : container for code");
            Console.WriteLine("4. Main() : entry point of program");
            Console.WriteLine("5. Comments : explain Logic and documentation");

            Console.ReadLine();

            Console.WriteLine("Program executed successfully!");
        }
        
    }
}
