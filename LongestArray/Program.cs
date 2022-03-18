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
            Random random = new Random();
            int arrayLength = 30;
            int[] array = new int[arrayLength];

            int minValue = 1;
            int maxValue = 5;

            Console.WriteLine($"Имеется одномерный массив длинной {arrayLength}, заполненный числами от {minValue} до {maxValue}");

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            int quantity = 1;
            int maxQuantity = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        quantity++;
                    }

                    if (quantity > maxQuantity)
                    {
                        maxQuantity = quantity;
                    }

                    if (array[i] != array[j])
                    {
                        quantity = 1;
                        i = j;
                    }
                }
            }

            Console.WriteLine($"максимальное число повторяемых чисел: {maxQuantity}");

            quantity = 1;
            string line = "";

            for (int i = 0; i < array.Length - maxQuantity+1; i++)
            {
                for (int j = i + 1; j < i + maxQuantity; j++)
                {
                    if (array[i] != array[j])
                    {                        
                        quantity = 1;
                    }

                    if (array[i] == array[j])
                    {                        
                        quantity++;
                    }

                    if(quantity == maxQuantity)
                    {
                        line += $"{maxQuantity} раза повторяется число {array[i]}\n";                        
                    }
                }
            }
            Console.WriteLine(line);
        }
    }
}
