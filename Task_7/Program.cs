namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7");
            Console.Write("Podaj ilość elementów w przekątnej : ");
            int elementsCount, a, b;
            bool isCorectCount = int.TryParse(Console.ReadLine(), out elementsCount);
            isCorectCount &= (elementsCount > 0);

            if (isCorectCount)
            {
                for (int i = 0; i < elementsCount / 2; i++)
                {
                    for (int j = 0; j < elementsCount; j++)
                    {
                        if (elementsCount % 2 == 0)
                        {
                            a = elementsCount / 2 - (i + 1);
                            b = elementsCount / 2 + (i);
                        }
                        else
                        {
                            a = elementsCount / 2 - (i);
                            b = elementsCount / 2 + (i);
                        }

                        if (j >= a && j <= b)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < elementsCount; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int i = 0; i < elementsCount / 2; i++)
                {
                    for (int j = 0; j < elementsCount; j++)
                    {
                        a = i;
                        b = elementsCount - (i + 1);
                        if (j > a && j < b)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wprowadzoną złą wartość");
            }
        }
    }
}
