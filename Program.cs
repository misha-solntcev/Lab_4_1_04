using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Задан одномерный массив А[1..20]. Найти минимальный элемент 
    среди элементов массива с n-го по k-й (n и k вводятся с клавиатуры) */

namespace Lab_4_1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =
            { 
                1, 2, 3, -4, 5, -6, 8, 9, -10, 11, 12, -13, 14, 15, -16, 17, 18, 19, 20 
            };

            Console.WriteLine("Введите n и k:");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int min = arr[n];
            for (int i = n; i <= k; i++)
            {
                if (arr[i] < min)
                    min = arr[i];                
            }
            Console.WriteLine($"min={min}");
            
            // Linq
            var res = arr.Where((x, i) => i >= n && i <= k).Min();
            Console.WriteLine($"res = {res}");

            Console.ReadKey();
        }
    }
}
