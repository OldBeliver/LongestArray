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
            string mesage = "";

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    quantity++;
                }
                else
                {
                    quantity = 1;
                }

                if (quantity == maxQuantity)
                {
                    mesage += $"число {array[i]} повторяется {quantity} раза\n";
                }

                if (quantity > maxQuantity)
                {
                    maxQuantity = quantity;
                    mesage = $"число {array[i]} повторяется {maxQuantity} разa\n";
                }
            }

            Console.WriteLine(mesage);
            //string line = "";
            quantity = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{array[i+1]} ");
                    quantity++;
                }
                else if (array[i] != array[i + 1] && quantity == maxQuantity)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{array[i]} ");
                    quantity = 1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{array[i]} ");
                    quantity = 1;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{array[array.Length-1]}\n");
        }
    }
}
