using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiển_thị_lời_chào
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("mời bạn nhập tên:");
            string sHoten = Console.ReadLine();
            Console.WriteLine("tên của bạn là:" + sHoten);
            Console.ReadKey();
        }
    }
}
