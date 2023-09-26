using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.LoginovMV.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x;
            Console.WriteLine("Введите переменную х:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите переменную y:");
            y = Convert.ToInt32(Console.ReadLine());

            int z;
            Console.WriteLine("Введите переменную z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                *");
            Console.WriteLine("*****************************");

            Console.WriteLine(ds.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
