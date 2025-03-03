using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    /// <summary>
    /// Задача 3. В одномерном массиве, заполненном с использованием явной инициализации, найти:
    ///1. максимальный элемент и его индекс;
    ///2. минимальный элемент и его индекс;
    ///3. поменять местами максимальный и минимальный элементы, вывести одномерный массив;
    ///4. количество элементов между максимальным и минимальным элементами.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 5, 2, 9, 1, 6, 8, 3, 7 };
            Task1_2(mas);
            Task3(mas, 2, 3);
            Task4(mas, 2, 3);

            Console.ReadKey();

        }
        
        static void Task1_2(int[]mas)
        { 
            int max = mas[0], min = mas[0];
            int maxIndex = 0, minIndex = 0;

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    maxIndex = i;
                }
                if (mas[i] < min)
                {
                    min = mas[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"Максимальный элемент: {max}, индекс: {maxIndex}");
            Console.WriteLine($"Минимальный элемент: {min}, индекс: {minIndex}");
        }

        static void Task3(int [] mas, int maxIndex, int minIndex)
        {
            (mas[maxIndex], mas[minIndex]) = (mas[minIndex], mas[maxIndex]);

            Console.WriteLine("Массив после замены:");
            foreach (int num in mas)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Task4 (int[] mas, int maxIndex, int minIndex)
        { 
            int elementsBetween = (maxIndex > minIndex) ? (maxIndex - minIndex - 1) : (minIndex - maxIndex - 1);
            Console.WriteLine($"Количество элементов между ними: {elementsBetween}");
        }
    }
}

