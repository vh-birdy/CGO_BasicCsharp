using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đọc_số_thành_chữ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
                int sonhap = int.Parse(input);
            int donvi = sonhap % 10;
            int hangchuc = sonhap / 10;
            int hangtram = sonhap % 100;
            if (input.Length == 3)
            {

                switch (hangtram)
                {
                    case 0: Console.Write("zero"); break;
                    case 1: Console.Write("one hundred"); break;
                    case 2: Console.Write("two hundred"); break;
                    case 3: Console.Write("three hundred"); break;
                    case 4: Console.Write("four hundred"); break;
                    case 5: Console.Write("five hundred"); break;
                    case 6: Console.Write("six hundred"); break;
                    case 7:
                        Console.Write("seven hundred"); break;
                    case 8:
                        Console.Write("eight hundred"); break;
                    case 9:
                        Console.Write("nine hundred"); break;
                }
               
            }


            else if (input.Length == 2)
            {
                switch (hangchuc)
                {
                    case 0: Console.Write("zero"); break;
                    case 1: Console.Write("ten"); break;
                    case 2: Console.Write("twenty"); break;
                    case 3: Console.Write("thirdty"); break;
                    case 4: Console.Write("fourty"); break;
                    case 5: Console.Write("fifty"); break;
                    case 6: Console.Write("sixty"); break;
                    case 7:
                        Console.Write("seventy"); break;
                    case 8:
                        Console.Write("eighty"); break;
                    case 9:
                        Console.Write("ninety"); break;
                }
               
            }


            else if (input.Length == 1)
            {

                switch (donvi)
                {
                    case 0: Console.Write("zero"); break;
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7:
                        Console.Write("seven"); break;
                    case 8:
                        Console.Write("eight"); break;
                    case 9:
                        Console.Write("nine"); break;
                }
               
            }


        }
    }
}
