using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toán_tử
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("enter height ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("area is " + area);
        }
    }
}
