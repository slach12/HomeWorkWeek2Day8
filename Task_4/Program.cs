﻿namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4");
            Console.Write("Podaj ilość elementów w piramidzie : ");
            int elementsCount;
            int number = 1;
            bool isCorectCount = int.TryParse(Console.ReadLine(), out elementsCount);
            isCorectCount &= elementsCount > 0;
            if (isCorectCount)
            {
                for (int i = 1; i <= elementsCount; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(number + " ");
                        number++;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Podano nie właściwą liczbę.");
            }
        }
    }
}