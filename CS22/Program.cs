//Дан одномерный массив целых чисел из 30 элементов.
//Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)
//Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.
//Программа должна работать с массивом любого размера.
//Массив всех локальных максимумов не нужен..
using System;

namespace CS22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 30);
                Console.Write(array[i] + " ");
            }
            
            if (array[0] > array[1])
            { 
                Console.WriteLine(array[0]);
            }
            
            for (int i = 1; i < array.Length - 1; i++)
            { 
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    Console.WriteLine(array[i]); 
                }
            }
           
            if (array[array.Length - 1] > array[array.Length - 2])
            { 
                Console.WriteLine(array[array.Length - 1]);
            }
        }
    }
}
