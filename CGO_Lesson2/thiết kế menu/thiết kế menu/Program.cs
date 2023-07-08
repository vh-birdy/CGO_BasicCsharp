using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiết_kế_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luachon;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                luachon = Int32.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            } while (luachon != 0);
            {

            }
        }
    }
}
