using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int arrayLength = 30;
            int[] array = new int[arrayLength];

            int minValue = 1;
            int maxValue = 5;

            int quantity = 0;
            int maxQuantity = quantity;
            string line = "";

            Console.WriteLine($"Имеется одномерный массив длинной {arrayLength}, заполненный числами от {minValue} до {maxValue}");

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            Array.Sort(array);
            Console.WriteLine($"массив отсортирован:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\n\nсводная таблица повторений чисел:");
            
            for (int i = 0; i < array.Length; i++)
            {
                int index;
                for (index = i; index < array.Length; index++)
                {
                    if (array[i] == array[index])
                    {
                        quantity++;
                    }

                    if (array[i] != array[index] || index == array.Length - 1)
                    {
                        Console.WriteLine($"значение {array[i]} - {quantity} раз");

                        string newLine = $"число {array[i]} повторяется {quantity} раз";

                        if (quantity == maxQuantity)
                        {
                            line += ",\n" + newLine;
                        }

                        if (quantity > maxQuantity)
                        {
                            maxQuantity = quantity;
                            line = newLine;
                        }

                        quantity = 1;
                        i = index;
                    }
                }
            }
            Console.WriteLine($"\nмаксимальное количество повторений:\n{line}");
        }
    }
}
