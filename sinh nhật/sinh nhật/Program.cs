using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sinh_nhật
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap ngay sinh cua ban: ");
            string input = Console.ReadLine();
            DateTime dob = DateTime.Parse(input);
            DateTime dob_year = new DateTime(DateTime.Now.Year, dob.Year, dob.Month, dob.Day);
            if( dob_year > DateTime.now)
             Console.WriteLine("ngày sinh nhật sắp tới, còn " + dob)}    
            Console.WriteLine("dob: " + dob.ToString());

        }
    }
}
