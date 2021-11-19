using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] number = new int[7];
            Console.WriteLine("Поочередно введите семь любых чисел");
            Console.WriteLine();
            int n = 0;
            int sum = 0;
              
            number[0] = Convert.ToInt32(Console.ReadLine());
            number[1] = Convert.ToInt32(Console.ReadLine());
            number[2] = Convert.ToInt32(Console.ReadLine());
            number[3] = Convert.ToInt32(Console.ReadLine()); 
            number[4] = Convert.ToInt32(Console.ReadLine());
            number[5] = Convert.ToInt32(Console.ReadLine());
            number[6] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 7; i++)
            {
                //number[i] = Convert.ToInt32(Console.ReadKey());
                n += 1;
                sum += number[i];
                Console.WriteLine();
                Console.WriteLine("Число {0} = {1}", n, number[i]);
                
                
            }
            Console.WriteLine();
            Console.WriteLine("Сумма введеных чисел = {0}", sum);
            Console.WriteLine();
            Console.WriteLine("Среднее арифмитическое значение = {0}", sum / n);
            Console.ReadKey();
        }

    }
}
