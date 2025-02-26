using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    /// <summary>
    /// Заполнить одномерный массив случайным образом и выполнить сортировку по возрастанию (через вложенный цикл, с использованием метода Sort()).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[10];
            Randomize(omas);
            Sortfor(omas);
            Console.ReadKey();
        }

        static void Randomize(int[] omas)
        {
            Random random = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = random.Next(-10, 11);
            }
        }

        //static void Sortfor(int[] omas)
        //{
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        for (int j = i + 1; j < omas.Length; j++)
        //        {
        //            if (omas[i] > omas[j])
        //            {
        //                int temp = omas[i];
        //                omas[i] = omas[j];
        //                omas[j] = temp;
                        
        //            }
        //        }
        //    }
        //    Console.WriteLine("Вывод отсортированного массива: ");
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        Console.Write($"{omas[i]} \t");
        //    }
        //}
        static void Sort(int[] omas)
        {
            Array.Sort(omas);
            Console.WriteLine("Вывод отсортированного массива: ");
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"{omas[i]} \t");
            }
        }
    }

}
