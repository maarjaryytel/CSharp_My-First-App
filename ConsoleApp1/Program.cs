using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            Console.WriteLine("What is your name ? ");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
       
            Console.WriteLine("When were you born? Please enter the year: ");
            int year;
            year = int.Parse(Console.ReadLine());
            int age = 2019 - year;
            Console.WriteLine("You are " + age + " years old");
            Console.ReadLine();





        }
    }
}
