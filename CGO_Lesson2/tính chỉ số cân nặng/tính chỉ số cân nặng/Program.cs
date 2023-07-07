using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tính_chỉ_số_cân_nặng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            Console.WriteLine("please enter your height");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("please enter your weight");
            weight = float.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(2, height);
            bmi = Math.Round(bmi, 1);
            Console.Write("BMI: " + bmi);
            if (bmi < 18)
                Console.WriteLine("underweight");
            else if (bmi < 25)
                Console.WriteLine("normal");
            else if (bmi > 25)
                Console.WriteLine("overweight");
            else
                Console.WriteLine("obese");

        }
    }
}
