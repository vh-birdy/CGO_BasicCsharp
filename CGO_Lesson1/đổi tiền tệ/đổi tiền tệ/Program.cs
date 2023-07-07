using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đổi_tiền_tệ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            const int tigia = 23000;
            Console.WriteLine("nhập số tiền usd :");
            string input = Console.ReadLine(); 
            int dollar = int.Parse(input); 
            Console.WriteLine("số tiền vnd của bạn là :" + dollar * tigia);
            Console.ReadKey();
        }
    }
}
