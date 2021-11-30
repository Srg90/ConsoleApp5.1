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
            double sum = 0;
            
            for (int i = 0; i < 7; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }  
            
            for (int j = 0; j < 7; j++)
            {
                
                n += 1;
                sum += number[j];
                Console.WriteLine();
                Console.WriteLine("Число {0} = {1}", n, number[j]);
                              
            }
            
            Console.WriteLine();
            Console.WriteLine("Сумма введеных чисел = {0}", sum);
            Console.WriteLine();
            Console.WriteLine("Среднее арифмитическое значение = {0}", Math.Round((sum / n), 1));
            Console.ReadKey();
        }

    }
}
